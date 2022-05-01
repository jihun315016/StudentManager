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
            string sql = @"SELECT a.STUDENT_NO, STUDENT_NAME, EMP_NAME, COURSE_NAME, ATTENDANCE_DATE, a.EMP_NO, IS_ATTENDANCE 
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

        public bool InsertAttendance(List<int> stuNoList, int courseNo, DateTime date, int empNo, List<int> isAttList)
        {
            

            MySqlTransaction trans = conn.BeginTransaction();

            for (int i = 0; i < stuNoList.Count; i++)
            {                
                string sql = @"INSERT INTO tb_attendance (STUDENT_NO, COURSE_NO, ATTENDANCE_DATE, EMP_NO, IS_ATTENDANCE) 
                                VALUES (@STUDENT_NO, @COURSE_NO, @ATTENDANCE_DATE, @EMP_NO, @IS_ATTENDANCE);";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

                cmd.Parameters.AddWithValue("@STUDENT_NO", stuNoList[i]);
                cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);
                cmd.Parameters.AddWithValue("@ATTENDANCE_DATE", date);
                cmd.Parameters.AddWithValue("@EMP_NO", empNo);
                cmd.Parameters.AddWithValue("@IS_ATTENDANCE", isAttList[i]);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    Debug.WriteLine($"[{sql}]");
                    Debug.WriteLine(err.StackTrace);
                    Debug.WriteLine(err.Message);
                    trans.Rollback();
                    return false;
                }
            }

            trans.Commit();
            return true;
        }

        public bool UpdateAttendance(List<int> stuNoList, int courseNo, DateTime date, int empNo, List<int> isAttList)
        {


            MySqlTransaction trans = conn.BeginTransaction();

            for (int i = 0; i < stuNoList.Count; i++)
            {
                string sql = @"UPDATE tb_attendance SET EMP_NO=@EMP_NO, IS_ATTENDANCE=@IS_ATTENDANCE 
                                WHERE STUDENT_NO=@STUDENT_NO and COURSE_NO=@COURSE_NO and ATTENDANCE_DATE=@ATTENDANCE_DATE;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = trans;

                cmd.Parameters.AddWithValue("@STUDENT_NO", stuNoList[i]);
                cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);
                cmd.Parameters.AddWithValue("@ATTENDANCE_DATE", date);
                cmd.Parameters.AddWithValue("@EMP_NO", empNo);
                cmd.Parameters.AddWithValue("@IS_ATTENDANCE", isAttList[i]);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    Debug.WriteLine($"[{sql}]");
                    Debug.WriteLine(err.StackTrace);
                    Debug.WriteLine(err.Message);
                    trans.Rollback();
                    return false;
                }
            }

            trans.Commit();
            return true;
        }
    }
}
