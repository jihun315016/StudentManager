using StudentManager.Data.DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Service
{
    public class AttendanceService
    {
        public DataTable GetAllAttendanceList(DateTime start, DateTime end)
        {
            AttendanceDAC dac = new AttendanceDAC();
            DataTable dt = dac.GetAllAttendanceList(start, end);
            dac.Dispose();

            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                int isAtt = int.Parse(dr["IS_ATTENDANCE"].ToString());
                list.Add(isAtt == 1 ? "O" : "X");
            }

            dt.Columns.Remove("IS_ATTENDANCE");
            dt.Columns.Add("IS_ATTENDANCE");

            for (int i = 0; i < list.Count; i++) 
            {
                dt.Rows[i]["IS_ATTENDANCE"] = list[i];
            }

            return dt;
        }

        public List<bool> IsAttendanceCheck(List<int> stuNoList, int courseNo, DateTime attDate, out bool isExist)
        {
            AttendanceDAC dac = new AttendanceDAC();
            List<bool> list = new List<bool>();
            int isExistNum = 0;

            foreach (int stuNo in stuNoList)
            {
                int attResult = dac.IsAttendanceCheck(stuNo, courseNo, attDate);
                isExistNum += attResult;
                bool isAtt = attResult == 1 ? true : false;
                list.Add(isAtt);
            }

            if (isExistNum > 0)
                isExist = true;
            else
                isExist = false;

            return list;
        }

        public bool InsertAttendance(List<int> stuNoList, int courseNo, DateTime date, List<int> isAttList)
        {
            AttendanceDAC dac = new AttendanceDAC();
            bool result = dac.InsertAttendance(stuNoList, courseNo, date, isAttList);
            dac.Dispose();

            return result;
        }

        public bool UpdateAttendance(List<int> stuNoList, int courseNo, DateTime date, int empNo, List<int> isAttList)
        {
            AttendanceDAC dac = new AttendanceDAC();
            bool result = dac.UpdateAttendance(stuNoList, courseNo, date, empNo, isAttList);
            dac.Dispose();

            return result;
        }

        public DataTable SearchAttInList(DataTable dt, string stuNo, string courseNo)
        {
            DataView dv = new DataView(dt);
            List<string> list = new List<string>();

            // 아무것도 입력하지 않으면 텍스트박스의 PalceHolder 값(문자열)이 되기 때문에
            // int 형 변환이 가능한지 체크가 필요함
            if (int.TryParse(stuNo, out int temp1))
                list.Add($"STUDENT_NO = {stuNo}");

            if (int.TryParse(courseNo, out int temp2))
                list.Add($"COURSE_NO = {courseNo}");

            dv.RowFilter = String.Join(" and ", list);

            return dv.ToTable();
        }
    }
}
