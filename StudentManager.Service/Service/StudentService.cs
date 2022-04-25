
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

        public string GetEndReason(int endNo)
        {
            StudentDAC dac = new StudentDAC();
            string result = dac.GetEndReason(endNo);
            dac.Dispose();

            return result;
        }

        public bool InsertStudent
            (
                string name, string studentContact, string guardianContact, string guardianRerationship,
                string school, int age, DateTime startDate, string specialNote
            )
        {
            StudentDAC dac = new StudentDAC();
            bool result = dac.InsertStudent
                (
                    name, studentContact, guardianContact, guardianRerationship, school, age, startDate, specialNote
                );
            dac.Dispose();
            return result;
        }

        public bool UpdateStudentInfo
            (
                int studentNo, string name, string stuContact,
                string guardContact, string gaurdRelationship,
                string school, int age, DateTime startDate, string specialNote
            )
        {
            StudentDAC dac = new StudentDAC();
            bool result = dac.UpdateStudentInfo(studentNo, name, stuContact, guardContact, gaurdRelationship, school, age, startDate, specialNote);
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

    }
}
