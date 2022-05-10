using StudentManager.Data.DAC;
using StudentManager.Data.VO;
using System.Data;

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
       
        public DataTable GetCourseName(bool isStop)
        {
            CourseDAC dac = new CourseDAC();
            DataTable dt = dac.GetCourseName(isStop);
            dac.Dispose();
            return dt;
        }

        public DataTable GetCourseByEmpNo(int empNo, bool isStop)
        {
            CourseDAC dac = new CourseDAC();
            DataTable dt = dac.GetCourseByEmpNo(empNo, isStop);
            dac.Dispose();
            return dt;
        }

        public DataTable GetCourseInfoByStuNo(int stuNo)
        {
            CourseDAC dac = new CourseDAC();
            DataTable result = dac.GetCourseInfoByStuNo(stuNo);
            dac.Dispose();
            return result;
        }

        public int GetCountStudentInCourse(int stuNo, int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            int result = dac.GetCountStudentInCourse(stuNo, courseNo);
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


        public bool InsertCourse(CourseVO courseVO)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.InsertCourse(courseVO);
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

        public DataTable SearchByEmpInfo(DataTable dt, int empNo)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"EMP_NO={empNo}";
            return dv.ToTable();
        }

        public DataTable SearchByCourseName(DataTable dt, string courseName)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"COURSE_NAME LIKE '%{courseName}%'";
            return dv.ToTable();
        }
    }
}
