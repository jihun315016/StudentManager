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

        public bool InsertAttendance(List<int> stuNoList, int courseNo, DateTime date, int empNo, List<int> isAttList)
        {
            AttendanceDAC dac = new AttendanceDAC();
            bool result = dac.InsertAttendance(stuNoList, courseNo, date, empNo, isAttList);
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
    }
}
