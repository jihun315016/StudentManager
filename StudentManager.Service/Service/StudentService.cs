using MySql.Data.MySqlClient;
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
        public StringBuilder ValidContact(string stuContact, string guardContact)
        {
            StringBuilder sb = new StringBuilder();

            int studentCnt = ValidContactCnt(stuContact);
            int GuardianCnt = ValidContactCnt(guardContact);

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

        public string test()
        {
            string sql = "SELECT SCHOOL_NAME, ADDRESS FROM TB_SCHOOL LIMIT 10";
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            // conn.Open();
            da.Fill(dt);
            conn.Close();

            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append($"{dr["SCHOOL_NAME"].ToString()} {dr["ADDRESS"].ToString()}\n");
            }

            return sb.ToString();
        }
    }
}
