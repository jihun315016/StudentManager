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
        public DataTable GetNotAttendanceList(int courseNo, DateTime attDate)
        {            
            AttendanceDAC dac = new AttendanceDAC();
            DataTable dt = dac.GetNotAttendanceList(courseNo, attDate);

            // attDate에 출석 등록을 안 했다면 출석 테이블에 데이터 자체가 없다.
            // -> attDate에 출석 관리를 한 적이 없다.
            // 특정 수업에 대한 모든 학생을 불러온다.
            if (dt.Rows.Count < 1)
            {
                dt = dac.GetAllStudentListInCourse(courseNo);
                foreach (DataRow dr in dt.Rows)
                    dr["IS_ATTENDANCE"] = 0;
            }

            dac.Dispose();
            return dt;
        }

        public bool InsertAttendance(List<int> stuNoList, int courseNo, DateTime date, int empNo, List<int> isAttList)
        {
            AttendanceDAC dac = new AttendanceDAC();
            bool result = dac.InsertAttendance(stuNoList, courseNo, date, empNo, isAttList);
            dac.Dispose();

            return result;
        }
    }
}
