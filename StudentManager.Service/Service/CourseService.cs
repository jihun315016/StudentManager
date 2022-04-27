using StudentManager.Data.DAC;
using StudentManager.Data.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Service
{
    public class CourseService
    {
        public CourseVO GetCourseInfoByPk(int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            CourseVO courseVO = dac.GetCourseInfoByPk(courseNo);
            dac.Dispose();
            return courseVO;
        }

        public DataTable GetAllCourseInfo(bool isFinal)
        {
            CourseDAC dac = new CourseDAC();
            DataTable dt = dac.GetAllCourseInfo(isFinal);
            dac.Dispose();
            return dt;
        }

        public bool InsertCourse(int empNo, string courseName, int payment, DateTime startDate, DateTime endDate)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.InsertCourse(empNo, courseName, payment, startDate, endDate);
            dac.Dispose();

            return result;
        }

        public string CheckDirectorOrTeacherByEmpNo(int empNo, out bool result)
        {
            EmployeeDAC dac = new EmployeeDAC();
            EmployeeVO empVO = dac.GetEmployeeInfoByPk(empNo);

            if (empVO == null)
            {
                result = false;
                return "존재하지 않는 직원 번호입니다.";
            }
            else if (!empVO.Position.Equals("강사") && !empVO.Position.Equals("원장"))
            {
                result = false;
                return "원장 또는 강사만 수업을 등록할 수 있습니다.";
            }
            else
            {
                result = true;
                return empVO.Emp_Name;
            }
        }

        public int SearchCourseInList(int courseNo, DataTable dt, string sortCol)
        {
            DataView dv = new DataView(dt);

            dv.Sort = sortCol;
            return dv.Find(courseNo);
        }
    }
}
