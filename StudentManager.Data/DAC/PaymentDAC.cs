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
    public class PaymentDAC : IDisposable
    {
        MySqlConnection conn;

        public PaymentDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();

        }
        public DataTable GetAllPaymentList()
        {
            string sql = @"SELECT PAYMENT_NO, p.STUDENT_NO, STUDENT_NAME, p.COURSE_NO, COURSE_NAME, MONEY, P.EMP_NO, e.EMP_NAME, PAYMENT_DATE
                            FROM tb_payment p
                            JOIN tb_course c ON p.COURSE_NO = c.COURSE_NO
                            JOIN tb_student s ON p.STUDENT_NO = s.STUDENT_NO
                            JOIN tb_employee e ON p.EMP_NO = e.EMP_NO
                            ORDER BY PAYMENT_DATE ASC";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetPaymentListByStuNo(int stuNo)
        {
            string sql = @"SELECT p.COURSE_NO, COURSE_NAME, MONEY, PAYMENT_DATE
                            FROM tb_payment p
                            JOIN tb_course c ON p.COURSE_NO = c.COURSE_NO
                            WHERE STUDENT_NO = @STUDENT_NO
                            LIMIT 30";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@STUDENT_NO", stuNo);
            da.Fill(dt);
            return dt;
        }

        public bool InsertPayment(int studentNo, int courseNo, DateTime date, int money, int empNo)
        {
            string sql = @"INSERT INTO tb_payment 
                            (COURSE_NO, STUDENT_NO, PAYMENT_DATE, MONEY, EMP_NO) 
                            VALUES (@COURSE_NO, @STUDENT_NO, @PAYMENT_DATE, @MONEY, @EMP_NO)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@COURSE_NO", courseNo);
            cmd.Parameters.AddWithValue("@STUDENT_NO", studentNo);
            cmd.Parameters.AddWithValue("@PAYMENT_DATE", date);
            cmd.Parameters.AddWithValue("@MONEY", money);
            cmd.Parameters.AddWithValue("@EMP_NO", empNo);

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

        public bool DeletePayment(int paymentNo)
        {
            string sql = @"DELETE FROM tb_payment WHERE PAYMENT_NO = @PAYMENT_NO";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@PAYMENT_NO", paymentNo);

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
