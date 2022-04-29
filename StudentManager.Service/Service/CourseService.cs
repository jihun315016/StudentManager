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
        public EmployeeCourseVO GetCourseInfoByPk(int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            EmployeeCourseVO courseEmpVO = dac.GetCourseInfoByPk(courseNo);
            dac.Dispose();
            return courseEmpVO;
        }

        public DataTable GetAllCourseInfo(bool isFinal)
        {
            CourseDAC dac = new CourseDAC();
            DataTable dt = dac.GetAllCourseInfo(isFinal);
            dac.Dispose();
            return dt;
        }

        public DataTable GetStudentListByCourse(int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            DataTable dt = dac.GetStudentListByCourse(courseNo);
            dac.Dispose();
            return dt;
        }

        public int DetCountStudentInCourse(int studentNo, int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            int result = dac.DetCountStudentInCourse(studentNo, courseNo);
            dac.Dispose();

            return result;
        }

        public bool InsertStudentInCourse(int studentNo, int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.InsertStudentInCourse(studentNo, courseNo);
            dac.Dispose();
            return result;
        }


        public bool InsertCourse(int empNo, string courseName, int payment, DateTime startDate, DateTime endDate)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.InsertCourse(empNo, courseName, payment, startDate, endDate);
            dac.Dispose();

            return result;
        }

        public bool InsertPayment(int studentNo, int courseNo, DateTime date)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.InsertPayment(studentNo, courseNo, date);
            dac.Dispose();

            return result;
        }

        public bool DeleteCourse(int courseNo)
        {

            CourseDAC dac = new CourseDAC();
            bool result = dac.DeleteCourse(courseNo);
            dac.Dispose();

            return result;
        }

        public string CheckDirectorOrTeacherByEmpNo(string strEmpNo, out bool result)
        {
            EmployeeDAC dac;
            EmployeeVO empVO;
            int empNo;

            // strEmpNo가 빈 문자열인 경우
            if (int.TryParse(strEmpNo, out empNo))
            {
                dac = new EmployeeDAC();
                empVO = dac.GetEmployeeInfoByPk(empNo);
            }
            else
            {
                result = false;
                return "직원 번호를 입력해주세요.";
            }
            
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
                return empVO.EmpName;
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
