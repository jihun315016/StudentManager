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

        public StudentVO GetStudentInfoByStuNo(int stu_no)
        {
            string sql = $@"SELECT 
                                STUDENT_NO, STUDENT_NAME, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP, 
                                SCHOOL, AGE, START_DATE, END_DATE, END_REASON_NO, SPECIAL_NOTE 
                            FROM tb_student
                            WHERE STUDENT_NO=@STUDENT_NO;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@STUDENT_NO", stu_no);

            MySqlDataReader reader = cmd.ExecuteReader();

            StudentVO stu = new StudentVO();

            if (reader.Read())
            {
                stu.StudentNo = int.Parse(reader["STUDENT_NO"].ToString());
                stu.StudentName = reader["STUDENT_NAME"].ToString();
                stu.StudentContact = reader["STUDENT_CONTACT"].ToString();
                stu.GuardianContact = reader["GUARDIAN_CONTACT"].ToString();
                stu.GuardianRalationship = reader["GUARDIAN_RERATIONSHIP"].ToString();
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

        public DataTable GetStudentListByCourse(int courseNo)
        {
            string sql = @"SELECT s.STUDENT_NO, STUDENT_NAME, SCHOOL, AGE
                            FROM tb_student s
                            JOIN tb_course_detail c
                            ON s.student_no = c.student_no
                            WHERE c.COURSE_NO=@COURSE_NO and s.END_DATE IS NULL";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@COURSE_NO", courseNo);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetStudentListByEmp(int empNo)
        {
            string sql = @"SELECT s.STUDENT_NO, STUDENT_NAME, AGE, c.COURSE_NAME
                            FROM tb_student s
                            JOIN tb_course_detail cd ON s.student_no = cd.student_no
                            JOIN tb_course c ON cd.COURSE_NO = c.COURSE_NO
                            WHERE EMP_NO=@EMP_NO and s.END_DATE IS NULL;";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@EMP_NO", empNo);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetAttendanceBook(int couseNo = -1)
        {
            string sql;

            if (couseNo > 0)
            {
                sql = @"SELECT 
                        s.STUDENT_NO, STUDENT_NAME, AGE, SCHOOL, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP
                        FROM tb_student s
                        JOIN tb_course_detail cs ON s.STUDENT_NO=cs.STUDENT_NO
                        WHERE COURSE_NO=@COURSE_NO";
            }
            else
            {
                sql = @"SELECT 
                        STUDENT_NO, STUDENT_NAME, AGE, SCHOOL, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP
                        FROM tb_student
                        WHERE END_DATE IS NULL";
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@COURSE_NO", couseNo);
            da.Fill(dt);
            return dt;
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

        public DataTable GetAllStudentInfo(bool stop)
        {           
            string sql;
            if (stop)
                sql = @"SELECT STUDENT_NO, STUDENT_NAME, AGE, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP, START_DATE, END_DATE 
                        FROM tb_student 
                        WHERE END_DATE IS NOT NULL";
            else
                sql = @"SELECT STUDENT_NO, STUDENT_NAME, AGE, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP, START_DATE, END_DATE
                        FROM tb_student 
                        WHERE END_DATE IS NULL";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public string GetEndReason(int endNo)
        {
            string sql = @"SELECT END_CONTENT FROM tb_end_reason WHERE END_NO = @END_NO";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("END_NO", endNo);

            return cmd.ExecuteScalar().ToString();
        }

        public DataTable GetAllEndReason()
        {
            string sql = @"SELECT END_CONTENT FROM tb_end_reason";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool InsertStudent(StudentVO stuVO)
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
            cmd.Parameters.AddWithValue("@STUDENT_NAME", stuVO.StudentName);
            cmd.Parameters.AddWithValue("@STUDENT_CONTACT", stuVO.StudentContact);
            cmd.Parameters.AddWithValue("@GUARDIAN_CONTACT", stuVO.GuardianContact);
            cmd.Parameters.AddWithValue("@GUARDIAN_RERATIONSHIP", stuVO.GuardianRalationship);
            cmd.Parameters.AddWithValue("@SCHOOL", stuVO.School);
            cmd.Parameters.AddWithValue("@AGE", stuVO.Age);
            cmd.Parameters.AddWithValue("@START_DATE", stuVO.StartDate);
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", stuVO.SpecialNote);

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

        public bool UpdateStudentInfo(StudentVO stuVO)        
        {
            string sql = @"UPDATE tb_student 
                            SET
                            STUDENT_NAME=@STUDENT_NAME, STUDENT_CONTACT=@STUDENT_CONTACT, 
                            GUARDIAN_CONTACT=@GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP=@GUARDIAN_RERATIONSHIP, 
                            SCHOOL=@SCHOOL, AGE=@AGE, START_DATE=@START_DATE, SPECIAL_NOTE = @SPECIAL_NOTE
                            WHERE
                            STUDENT_NO=@STUDENT_NO";
            

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@STUDENT_NO", stuVO.StudentNo);
            cmd.Parameters.AddWithValue("@STUDENT_NAME", stuVO.StudentName);
            cmd.Parameters.AddWithValue("@STUDENT_CONTACT", stuVO.StudentContact);
            cmd.Parameters.AddWithValue("@GUARDIAN_CONTACT", stuVO.GuardianContact);
            cmd.Parameters.AddWithValue("@GUARDIAN_RERATIONSHIP", stuVO.GuardianRalationship);
            cmd.Parameters.AddWithValue("@SCHOOL", stuVO.School);
            cmd.Parameters.AddWithValue("@AGE", stuVO.Age);
            cmd.Parameters.AddWithValue("@START_DATE", stuVO.StartDate);
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", stuVO.SpecialNote);


            try
            {
                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.StackTrace);
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool UpdateEndDate(StudentVO student, bool isStop)
        {
            string sql;
            if (isStop) // 퇴원
                sql = @"UPDATE tb_student SET END_DATE=@NEW_DATE, END_REASON_NO=@END_REASON_NO WHERE STUDENT_NO=@STUDENT_NO";
            else // 재등록
                sql = @"UPDATE tb_student SET START_DATE=@NEW_DATE, END_DATE=NULL, END_REASON_NO=NULL WHERE STUDENT_NO=@STUDENT_NO";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@STUDENT_NO", student.StudentNo);
            cmd.Parameters.AddWithValue("@NEW_DATE", student.EndDate);
            cmd.Parameters.AddWithValue("@END_REASON_NO", student.EndReasonNo);

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
