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
    public class CourseDAC : IDisposable
    {
        MySqlConnection conn;

        public CourseDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public EmployeeCourseVO GetCourseInfoByPk(int courseNo)
        {
            string sql = $@"SELECT COURSE_NO, c.EMP_NO, EMP_NAME, COURSE_NAME, PAYMENT, c.START_DATE, c.END_DATE 
                            FROM tb_course c
                            JOIN tb_employee e
                            ON c.EMP_NO = e.EMP_NO
                            WHERE COURSE_NO=@COURSE_NO";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);

            MySqlDataReader reader = cmd.ExecuteReader();

            EmployeeCourseVO courseEmp = new EmployeeCourseVO();

            if (reader.Read())
            {
                courseEmp.CourseNo = int.Parse(reader["COURSE_NO"].ToString());
                courseEmp.EmpNo = int.Parse(reader["EMP_NO"].ToString());
                courseEmp.EmpName = reader["EMP_NAME"].ToString();
                courseEmp.Payment = int.Parse(reader["PAYMENT"].ToString());
                courseEmp.CourseName = reader["COURSE_NAME"].ToString();
                courseEmp.CourseStartDate = Convert.ToDateTime(reader["START_DATE"].ToString());
                courseEmp.CourseEndDate = Convert.ToDateTime(reader["END_DATE"].ToString());

                return courseEmp;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetAllCourseInfo(bool isFinal)
        {
            string sql;
            if (isFinal)
                sql = @"SELECT COURSE_NO, EMP_NO, COURSE_NAME, PAYMENT, START_DATE, END_DATE 
                        FROM tb_course 
                        WHERE date_format(now(), '%Y-%m-%d') < START_DATE or date_format(now(), '%Y-%m-%d') > END_DATE";
            else
                sql = @"SELECT COURSE_NO, EMP_NO, COURSE_NAME, PAYMENT, START_DATE, END_DATE 
                        FROM tb_course 
                        WHERE date_format(now(), '%Y-%m-%d') >= START_DATE and date_format(now(), '%Y-%m-%d') <= END_DATE";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetStudentListByCourse(int courseNo)
        {
            string sql = @"SELECT STUDENT_NO, COURSE_NO FROM tb_course_student WHERE COURSE_NO=@COURSE_NO";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@COURSE_NO", courseNo);
            da.Fill(dt);

            return dt;
        }

        public int DistinctCheckStudentList(int studentNo, int courseNo)
        {
            string sql = @"SELECT count(STUDENT_NO) FROM tb_course_student WHERE STUDENT_NO=@STUDENT_NO and COURSE_NO=@COURSE_NO";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@STUDENT_NO", studentNo);
            cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool InsertCourse(int empNo, string courseName, int payment, DateTime startDate, DateTime endDate)
        {
            string sql = @"INSERT INTO tb_course
                            (EMP_NO, COURSE_NAME, PAYMENT, START_DATE, END_DATE)
                            VALUES
                            (@EMP_NO, @COURSE_NAME, @PAYMENT, @START_DATE, @END_DATE)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@EMP_NO", empNo);
            cmd.Parameters.AddWithValue("@COURSE_NAME", courseName);
            cmd.Parameters.AddWithValue("@PAYMENT", payment);
            cmd.Parameters.AddWithValue("@START_DATE", startDate);
            cmd.Parameters.AddWithValue("@END_DATE", endDate);

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

        public bool InsertStudentInCourse(int studentNo, int courseNo)
        {
            string sql = @"INSERT INTO tb_course_student 
                            (STUDENT_NO, COURSE_NO) 
                            VALUES (@STUDENT_NO, @COURSE_NO)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@STUDENT_NO", studentNo);
            cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);

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
