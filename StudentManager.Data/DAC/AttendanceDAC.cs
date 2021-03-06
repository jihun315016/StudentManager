using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace StudentManager.Data.DAC
{
    public class AttendanceDAC : IDisposable
    {
        MySqlConnection conn;

        public AttendanceDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetAllAttendanceList(DateTime start, DateTime end)
        {
            string sql = @"SELECT a.STUDENT_NO, STUDENT_NAME, EMP_NAME, COURSE_NAME, ATTENDANCE_DATE, IS_ATTENDANCE, a.COURSE_NO
                            FROM tb_attendance a
                            JOIN tb_student s ON a.STUDENT_NO=s.STUDENT_NO
                            JOIN tb_course c ON a.COURSE_NO=c.COURSE_NO
                            JOIN tb_employee e ON c.EMP_NO=e.EMP_NO
                            WHERE ATTENDANCE_DATE >= @START and ATTENDANCE_DATE <= @END";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@START", start);
            da.SelectCommand.Parameters.AddWithValue("@END", end);
            da.Fill(dt);

            return dt;
        }

        // 특정한 날 출석 안 한 학생 리스트 조회
        public DataTable GetNotAttendanceList(int courseNo, DateTime attDate)
        {
            string sql = @"SELECT a.STUDENT_NO, STUDENT_NAME, ATTENDANCE_DATE, IS_ATTENDANCE 
                            FROM tb_attendance a
                            JOIN tb_student s ON a.student_no = s.student_no
                            WHERE COURSE_NO=@COURSE_NO and ATTENDANCE_DATE=@ATTENDANCE_DATE";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@COURSE_NO", courseNo);
            da.SelectCommand.Parameters.AddWithValue("@ATTENDANCE_DATE", attDate);
            da.Fill(dt);

            return dt;
        }

        // 특정 수업에 대한 전체 학생 리스트
        public DataTable GetAllStudentListInCourse(int courseNo)
        {
            string sql = @"SELECT a.STUDENT_NO, STUDENT_NAME, ATTENDANCE_DATE, IS_ATTENDANCE 
                            FROM tb_attendance a
                            JOIN tb_student s ON a.student_no = s.student_no
                            WHERE COURSE_NO=@COURSE_NO GROUP BY STUDENT_NO";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@COURSE_NO", courseNo);

            da.Fill(dt);

            return dt;
        }

        public DataTable GetAttendanceListByStuNo(int stuNo)
        {
            string sql = @"SELECT c.COURSE_NO, COURSE_NAME, EMP_NAME, ATTENDANCE_DATE
                            FROM tb_course c
                            JOIN tb_attendance a ON c.COURSE_NO = a.COURSE_NO
                            JOIN tb_employee e ON c.EMP_NO = e.EMP_NO
                            WHERE STUDENT_NO = @STUDENT_NO
                            LIMIT 50";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@STUDENT_NO", stuNo);
            da.Fill(dt);
            return dt;
        }

        public int IsAttendanceCheck(int stuNo, int courseNo, DateTime attDate)
        {
            string sql = @"SELECT count(STUDENT_NO) FROM tb_attendance
                            WHERE STUDENT_NO=@STUDENT_NO 
                            and COURSE_NO=@COURSE_NO 
                            and ATTENDANCE_DATE=@ATTENDANCE_DATE 
                            and IS_ATTENDANCE=1";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@STUDENT_NO", stuNo);
            cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);
            cmd.Parameters.AddWithValue("@ATTENDANCE_DATE", attDate);

            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        public int isAttendance(int courseNo, DateTime attDate)
        {
            string sql = @"SELECT count(ATTENDANCE_NO) FROM tb_attendance
                            WHERE COURSE_NO=@COURSE_NO and ATTENDANCE_DATE=@ATTENDANCE_DATE";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);
            cmd.Parameters.AddWithValue("@ATTENDANCE_DATE", attDate);
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        public bool InsertAttendance(List<int> stuNoList, int courseNo, DateTime date, List<int> isAttList)
        {
            

            MySqlTransaction trans = conn.BeginTransaction();

            string sql = @"INSERT INTO tb_attendance (STUDENT_NO, COURSE_NO, ATTENDANCE_DATE, IS_ATTENDANCE) 
                            VALUES (@STUDENT_NO, @COURSE_NO, @ATTENDANCE_DATE, @IS_ATTENDANCE);";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Transaction = trans;
            cmd.Parameters.Add("@STUDENT_NO", MySqlDbType.Int32);
            cmd.Parameters.Add("@IS_ATTENDANCE", MySqlDbType.Int32);
            cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);
            cmd.Parameters.AddWithValue("@ATTENDANCE_DATE", date);

            try
            {
                for (int i = 0; i < stuNoList.Count; i++)
                {
                    cmd.Parameters["@STUDENT_NO"].Value = stuNoList[i];
                    cmd.Parameters["@IS_ATTENDANCE"].Value = isAttList[i];
                    cmd.ExecuteNonQuery();                    
                }

            }
            catch (Exception err)
            {
                Debug.WriteLine(err.StackTrace);
                Debug.WriteLine(err.Message);
                trans.Rollback();
                return false;
            }

            trans.Commit();
            return true;
        }

        public bool UpdateAttendance(List<int> stuNoList, int courseNo, DateTime date, List<int> isAttList)
        {


            MySqlTransaction trans = conn.BeginTransaction();

            string sql = @"UPDATE tb_attendance SET IS_ATTENDANCE=@IS_ATTENDANCE 
                            WHERE STUDENT_NO=@STUDENT_NO and COURSE_NO=@COURSE_NO and ATTENDANCE_DATE=@ATTENDANCE_DATE;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Transaction = trans;
            cmd.Parameters.Add("@STUDENT_NO", MySqlDbType.Int32);
            cmd.Parameters.Add("@IS_ATTENDANCE", MySqlDbType.Int32);
            cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);
            cmd.Parameters.AddWithValue("@ATTENDANCE_DATE", date);

            try
            {
                for (int i = 0; i < stuNoList.Count; i++)
                {
                    cmd.Parameters["@STUDENT_NO"].Value = stuNoList[i];
                    cmd.Parameters["@IS_ATTENDANCE"].Value = isAttList[i];
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.StackTrace);
                Debug.WriteLine(err.Message);
                trans.Rollback();
                return false;
            }

            trans.Commit();
            return true;
        }
    }
}
