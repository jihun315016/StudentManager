
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
        public DataTable GetSchoolList(string keyword)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetSchoolList(keyword);
            dac.Dispose();
            return dt;
        }

        public DataTable GetAllStudentInfo(bool stop)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetAllStudentInfo(stop);
            dac.Dispose();
            return dt;
        }

        public StudentVO GetStudentInfoByPk(int stuNo)
        {
            StudentDAC dac = new StudentDAC();
            StudentVO studentVO = dac.GetStudentInfoByPk(stuNo);
            dac.Dispose();

            return studentVO;
        }

        public DataTable GetAttendanceBook(int couseNo = -1)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetAttendanceBook(couseNo);
            dac.Dispose();

            return dt;
        }

        public string GetEndReason(int endNo)
        {
            StudentDAC dac = new StudentDAC();
            string result = dac.GetEndReason(endNo);
            dac.Dispose();

            return result;
        }

        public DataTable GetStudentListByCourse(int courseNo)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetStudentListByCourse(courseNo);
            dac.Dispose();
            return dt;
        }

        public DataTable GetStudentListByEmp(int empNo)
        {
            StudentDAC dac = new StudentDAC();
            DataTable dt = dac.GetStudentListByEmp(empNo);
            dac.Dispose();
            return dt;
        }

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

        public bool InsertStudent(StudentVO stuVO)            
        {
            StudentDAC dac = new StudentDAC();
            bool result = dac.InsertStudent(stuVO);
            dac.Dispose();
            return result;
        }

        public bool UpdateStudentInfo(StudentVO stuVO)            
        {
            StudentDAC dac = new StudentDAC();
            bool result = dac.UpdateStudentInfo(stuVO);
            dac.Dispose();
            return result;
        }

        public bool UpdateEndDate(int stuNo, DateTime newDate, int endReasonNo, bool isStop)
        {
            StudentDAC dac = new StudentDAC();
            bool result = dac.UpdateEndDate(stuNo, newDate, endReasonNo, isStop);
            dac.Dispose();
            return result;
        }

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

        public DataTable SearchByStudentName(DataTable dt, string stuName)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"STUDENT_NAME LIKE '%{stuName}%'";
            return dv.ToTable();
        }

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
