using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Data.DAC
{
    public class StudentDAC : IDisposable
    {
        MySqlConnection conn;

        public StudentDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetSchoolList(string keyword)
        {
            string sql = $@"SELECT SCHOOL_NAME 
                        FROM tb_school 
                        WHERE SCHOOL_NAME 
                        LIKE @SCHOOL_NAME 
                        ORDER BY SCHOOL_NAME 
                        LIMIT 30";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            // like는 sql에 ''쓰면 안되는듯
            da.SelectCommand.Parameters.AddWithValue("@SCHOOL_NAME", $"%{keyword}%");

            da.Fill(dt);
            return dt;
        }   

        public bool InsertStudent(string[] data)
        {
            string sql = @"INSERT INTO tb_student 
                            (
                            STUDENT_NAME, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP, 
                            SCHOOL, AGE, START_DATE, SPECIAL_NOTE)
                            VALUES
                            (
                            @STUDENT_NAME, @STUDENT_CONTACT, @GUARDIAN_CONTACT, @GUARDIAN_RERATIONSHIP, 
                            @SCHOOL, @AGE, @START_DATE, @SPECIAL_NOTE
                            )";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@STUDENT_NAME", data[0]);
            cmd.Parameters.AddWithValue("@STUDENT_CONTACT", data[1]);
            cmd.Parameters.AddWithValue("@GUARDIAN_CONTACT", data[2]);
            cmd.Parameters.AddWithValue("@GUARDIAN_RERATIONSHIP", data[3]);
            cmd.Parameters.AddWithValue("@SCHOOL", data[4]);
            cmd.Parameters.AddWithValue("@AGE", data[5]);
            cmd.Parameters.AddWithValue("@START_DATE", Convert.ToDateTime(data[6]));
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", data[7]);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.StackTrace);
                Debug.WriteLine(err.Message);
                return false;
            }
        }
    }
}
