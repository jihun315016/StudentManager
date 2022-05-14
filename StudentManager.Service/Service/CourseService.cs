using StudentManager.Data.DAC;
using StudentManager.Data.VO;
using System.Data;

namespace StudentManager.Service.Service
{
    public class CourseService
    {
        /// <summary>
        /// 특정 수업에 대한 정보 조회
        /// </summary>
        /// <param name="courseNo"></param>
        /// <returns></returns>
        public EmployeeCourseVO GetCourseInfoByPk(int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            EmployeeCourseVO courseEmpVO = dac.GetCourseInfoByPk(courseNo);
            dac.Dispose();
            return courseEmpVO;
        }

        /// <summary>
        /// 진행 중 또는 종강, 예정인 수업 조회
        /// </summary>
        /// <param name="isFinalOrPlan">수업 종강, 예정 여부</param>
        /// <returns></returns>
        public DataTable GetAllCourseInfo(bool isFinalOrPlan)
        {
            CourseDAC dac = new CourseDAC();
            DataTable dt = dac.GetAllCourseInfo(isFinalOrPlan);
            dac.Dispose();
            return dt;
        }
       
        /// <summary>
        /// 수업 이름 조회
        /// "(강사명) 수업" 형태의 데이터로 조회된다.
        /// </summary>
        /// <param name="isFinalOrPlan">수업 종강, 예정 여부</param>
        /// <returns></returns>
        public DataTable GetCourseName(bool isFinalOrPlan)
        {
            CourseDAC dac = new CourseDAC();
            DataTable dt = dac.GetCourseName(isFinalOrPlan);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 특정 강사의 진행중인 또는 종강, 예정인 수업 조회
        /// 각 데이터는 5개 까지만 제공된다.
        /// 학원이 오래돼서 진행된 수업이 많아지면 가독성이 떨어질 수 있기 때문
        /// </summary>
        /// <param name="empNo">조회할 강사 번호</param>
        /// <param name="isFinalOrPlan">수업 종강, 예정 여부</param>
        /// <returns></returns>
        public DataTable GetCourseByEmpNo(int empNo, bool isFinalOrPlan)
        {
            CourseDAC dac = new CourseDAC();
            DataTable dt = dac.GetCourseByEmpNo(empNo, isFinalOrPlan);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 특정 학생이 듣는 수업 정보 조회
        /// </summary>
        /// <param name="stuNo">학생 번호</param>
        /// <returns></returns>
        public DataTable GetCourseInfoByStuNo(int stuNo)
        {
            CourseDAC dac = new CourseDAC();
            DataTable result = dac.GetCourseInfoByStuNo(stuNo);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 학생 등록시 이미 등록된 학생인지 검사
        /// </summary>
        /// <param name="stuNo">등록할 학생 번호</param>
        /// <param name="courseNo">등록할 수업 번호</param>
        /// <returns></returns>
        public int GetCountStudentInCourse(int stuNo, int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            // 결과가 0보다 크면 이미 등록된 학생
            int result = dac.GetCountStudentInCourse(stuNo, courseNo);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 특정 수업에 대해서 학생 수강 신청 처리
        /// </summary>
        /// <param name="studentNo">수강 신청할 학생 번호</param>
        /// <param name="courseNo">신청받은 수업 번호</param>
        /// <returns></returns>
        public bool InsertStudentInCourse(int studentNo, int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.InsertStudentInCourse(studentNo, courseNo);
            dac.Dispose();
            return result;
        }


        /// <summary>
        /// 수업 등록
        /// </summary>
        /// <param name="courseVO">등록할 수업 정보</param>
        /// <returns></returns>
        public bool InsertCourse(CourseVO courseVO)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.InsertCourse(courseVO);
            dac.Dispose();
            return result;
        } 

        /// <summary>
        /// 수업 취소 처리
        /// </summary>
        /// <param name="courseNo">취소할 수업 번호</param>
        /// <returns></returns>
        public bool DeleteCourse(int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.DeleteCourse(courseNo);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stuNo"></param>
        /// <param name="courseNo"></param>
        /// <returns></returns>
        public bool DeleteStudent(int stuNo, int courseNo)
        {
            CourseDAC dac = new CourseDAC();
            bool result = dac.DeleteStudent(stuNo, courseNo);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 특정 강사 또는 원장의 직원 번호를 통해 이름 조회
        /// </summary>
        /// <param name="strEmpNo">조회할 직원 번호</param>
        /// <param name="result">호출한 쪽에서 strEnoNo가 유효한 직원인지 검사</param>
        /// <returns></returns>
        public string CheckDirectorOrTeacherByEmpNo(string strEmpNo, out bool result)
        {
            EmployeeDAC dac;
            EmployeeVO empVO;
            int empNo;

            // 빈 문자열 검사
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

        /// <summary>
        /// 특정 직원이 진행하는 수업 조회(필터링)
        /// </summary>
        /// <param name="dt">기존 데이터 테이블</param>
        /// <param name="empNo">조회할 직원 번호</param>
        /// <returns></returns>
        public DataTable SearchByEmpInfo(DataTable dt, int empNo)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"EMP_NO={empNo}";
            return dv.ToTable();
        }

        /// <summary>
        /// 수업 검색 기능
        /// </summary>
        /// <param name="dt">기존 데이터 테이블</param>
        /// <param name="courseName">검색 키워드</param>
        /// <returns></returns>
        public DataTable SearchByCourseName(DataTable dt, string courseName)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"COURSE_NAME LIKE '%{courseName}%'";
            return dv.ToTable();
        }
    }
}
