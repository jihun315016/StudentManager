
using StudentManager.Data.DAC;
using StudentManager.Data.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Service
{
    public class StudentService
    {
        /// <summary>
        /// 특정 키워드가 들어간 학교 리스트 조회
        /// 데이터는 30개까지만 조회된다.
        /// </summary>
        /// <param name="keyword">검색 키워드</param>
        /// <returns></returns>
        public DataTable GetSchoolList(string keyword)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetSchoolList(keyword);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 학생 데이터 조회
        /// 학원에 다니는 학생과 퇴원한 학생 중 선택하여 조회한다.
        /// </summary>
        /// <param name="stop">학생 퇴원 여부</param>
        /// <returns></returns>
        public DataTable GetAllStudentInfo(bool stop)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetAllStudentInfo(stop);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 학생 번호를 통해 특정 학생에 대한 정보 조회
        /// </summary>
        /// <param name="stuNo"></param>
        /// <returns></returns>
        public StudentVO GetStudentInfoByStuNo(int stuNo)
        {
            StudentDAC dac = new StudentDAC();
            StudentVO studentVO = dac.GetStudentInfoByStuNo(stuNo);
            dac.Dispose();
            return studentVO;
        }

        /// <summary>
        /// 출석부 조회
        /// courseNo가 -1이면 전체 학생을 조회하고,
        /// 0보다 크다면 해당 번호에 맞는 수업에 대한 출석부를 조회한다.
        /// </summary>
        /// <param name="couseNo">출석을 조회할 수업 번호</param>
        /// <returns></returns>
        public DataTable GetAttendanceBook(int couseNo = -1)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetAttendanceBook(couseNo);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 퇴원한 학생이 그만둔 이유 조회
        /// </summary>
        /// <param name="endNo"></param>
        /// <returns></returns>
        public string GetEndReason(int endNo)
        {
            StudentDAC dac = new StudentDAC();
            string result = dac.GetEndReason(endNo);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// 특정 수업을 듣는 학생 조회
        /// </summary>
        /// <param name="courseNo"></param>
        /// <returns></returns>
        public DataTable GetStudentListByCourse(int courseNo)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetStudentListByCourse(courseNo);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 학생 퇴원시 그만두는 이유 리스트 조회
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllEndReason()
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetAllEndReason();
            dac.Dispose();

            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
                list.Add(dr["END_CONTENT"].ToString());

            return list;
        }

        /// <summary>
        /// 학생 등록
        /// </summary>
        /// <param name="stuVO">등록할 학생 정보</param>
        /// <returns></returns>
        public bool InsertStudent(StudentVO stuVO)            
        {
            StudentDAC dac = new StudentDAC();
            bool result = dac.InsertStudent(stuVO);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 학생 정보 수정
        /// </summary>
        /// <param name="stuVO">수정할 학생 정보</param>
        /// <returns></returns>
        public bool UpdateStudentInfo(StudentVO stuVO)            
        {
            StudentDAC dac = new StudentDAC();
            bool result = dac.UpdateStudentInfo(stuVO);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 학생 퇴원 또는 재등록 처리(퇴원 또는 재등록 날짜 수정)
        /// </summary>
        /// <param name="student">퇴원 또는 재등록할 학생 정보</param>
        /// <param name="isStop">퇴원인지 재등록인지 판단</param>
        /// <returns></returns>
        public bool UpdateEndDate(StudentVO student, bool isStop)
        {
            StudentDAC dac = new StudentDAC();
            bool result = dac.UpdateEndDate(student, isStop);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 연락처 유효성 검사
        /// 학생 연락처 or 보호자 연락처 중 하나는 입력해야 하고,
        /// 호보자 연락처를 입력했다면 보호자 관계도 입력해야 한다.
        /// 연락처도 13자리의 숫자가 되지 않는다면 잘못된 입력으로 처리한다.
        /// </summary>
        /// <param name="stuContact">학생 연락처</param>
        /// <param name="guardContact">보호자 연락처</param>
        /// <param name="guardRelationship">보호자 관계</param>
        /// <returns></returns>
        public StringBuilder ValidContactAndGuardian(string stuContact, string guardContact, string guardRelationship)
        {
            StringBuilder sb = new StringBuilder();

            int studentCnt = ValidContactCnt(stuContact);
            int GuardianCnt = ValidContactCnt(guardContact);

            // 보호자 연락처 13자리 모두 입력하면서 보호자 관계가 비어있지 않는 경우
            bool allInput = guardContact.Length == 13 && !string.IsNullOrWhiteSpace(guardRelationship);

            // 보호자 연락처와 보호자 관계가 모두 비워진 경우
            bool noInput = ValidContactCnt(guardContact) == 0 && string.IsNullOrWhiteSpace(guardRelationship);

            if (studentCnt + GuardianCnt == 0)
            {
                sb.Append("학생 연락처와 보호자 연락처 중 하나는 입력해주세요.");
            }

            else if (studentCnt > 0 && studentCnt < 11)
            {
                sb.Append("잘못된 학생 연락처입니다.");
            }

            else if (GuardianCnt > 0 && GuardianCnt < 11)
            {
                sb.Append("잘못된 보호자 연락처입니다.");
            }

            else if (!(allInput || noInput))
            {
                if (guardContact.Length < 13)
                    sb.Append("보호자 연락처를 입력해주세요.");
                else
                    sb.Append("보호자 관계를 입력해주세요.");
            }

            return sb;
        }

        /// <summary>
        /// ValidContactAndGuardian() 메서드로 연락처 유효성 검사를 할 때,
        /// 연락처가 13자리의 숫자로 이루어져 있는지 검사
        /// </summary>
        /// <param name="text"></param>
        /// <returns>연락처가 몇 개의 숫자로 이루어져 있는지 리턴한다.</returns>
        int ValidContactCnt(string text)
        {
            int contactCnt = 0;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    contactCnt++;
            }

            return contactCnt;
        }

        /// <summary>
        /// 학생 리스트에서 학생 이름을 통해 검색한다.
        /// </summary>
        /// <param name="dt">기존 데이터 테이블</param>
        /// <param name="stuName">검색된 학생 이름 키워드</param>
        /// <returns></returns>
        public DataTable SearchByStudentName(DataTable dt, string stuName)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"STUDENT_NAME LIKE '%{stuName}%'";
            return dv.ToTable();
        }

        /// <summary>
        /// 학생 리스트에서 등록 또는 퇴원 날짜를 통해 검색한다.
        /// </summary>
        /// <param name="start">검색할 날짜 범위 시작 지점</param>
        /// <param name="end">검색할 날짜 범위 종료 지점</param>
        /// <param name="dt">기존 데이터 테이블</param>
        /// <param name="isStop">퇴원 여부</param>
        /// <returns></returns>
        public DataTable SearchByDate(DateTime start, DateTime end, DataTable dt, bool isStop)
        {
            DataView dv = new DataView(dt);

            if (isStop)            
                dv.RowFilter = $"END_DATE >= #{start.ToString("yyyy/MM/dd")}# and END_DATE <= #{end.ToString("yyyy/MM/dd")}#";
            else            
                dv.RowFilter = $"START_DATE >= #{start.ToString("yyyy/MM/dd")}# and START_DATE <= #{end.ToString("yyyy/MM/dd")}#";

            return dv.ToTable();
        }
    }
}
