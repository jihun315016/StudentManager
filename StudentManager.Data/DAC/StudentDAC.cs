using MySql.Data.MySqlClient;
using StudentManager.Data.VO;
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

        public StudentVO GetStudentInfoByPk(int stu_no)
        {
            string sql = $@"SELECT 
                                STUDENT_NAME, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP, 
                                SCHOOL, AGE, START_DATE, END_DATE, END_REASON_NO, SPECIAL_NOTE 
                            FROM tb_student
                            WHERE STUDENT_NO=@STUDENT_NO;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@STUDENT_NO", stu_no);

            MySqlDataReader reader = cmd.ExecuteReader();

            StudentVO stu = new StudentVO();

            if (reader.Read())
            {
                stu.Student_Name = reader["STUDENT_NAME"].ToString();
                stu.Student_Contact = reader["STUDENT_CONTACT"].ToString();
                stu.Guardian_Contact = reader["GUARDIAN_CONTACT"].ToString();
                stu.Guardian_ralationship = reader["GUARDIAN_RERATIONSHIP"].ToString();
                stu.School = reader["SCHOOL"].ToString();
                stu.Age = int.Parse(reader["AGE"].ToString());
                stu.StartDate = Convert.ToDateTime(reader["START_DATE"].ToString());
                stu.EndDate = (reader["END_DATE"] == DBNull.Value) ? new DateTime() : Convert.ToDateTime(reader["END_DATE"].ToString());
                stu.EndReasonNo = (reader["END_REASON_NO"] == DBNull.Value) ? -1 : int.Parse(reader["END_REASON_NO"].ToString());
                stu.SpecialNote = reader["SPECIAL_NOTE"].ToString();

                return stu;
            }
            else
            {
                return null;
            }
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

        public DataTable GetAllStudentInfo()
        {
            string sql = @"SELECT STUDENT_NO, STUDENT_NAME, AGE, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP 
                            FROM tb_student";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public bool InsertStudent
            (
                string name, string studentContact, string guardianContact, string guardianRerationship,
                string school, int age, DateTime startDate, string specialNote
            )
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
            cmd.Parameters.AddWithValue("@STUDENT_NAME", name);
            cmd.Parameters.AddWithValue("@STUDENT_CONTACT", studentContact);
            cmd.Parameters.AddWithValue("@GUARDIAN_CONTACT", guardianContact);
            cmd.Parameters.AddWithValue("@GUARDIAN_RERATIONSHIP", guardianRerationship);
            cmd.Parameters.AddWithValue("@SCHOOL", school);
            cmd.Parameters.AddWithValue("@AGE", age);
            cmd.Parameters.AddWithValue("@START_DATE", startDate);
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", specialNote);

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
