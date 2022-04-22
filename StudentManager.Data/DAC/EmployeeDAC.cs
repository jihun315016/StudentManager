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
    public class EmployeeDAC : IDisposable
    {
        MySqlConnection conn;

        public EmployeeDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetAllEmployeeInfo()
        {
            string sql = @"SELECT EMP_NO, EMP_NAME, POSITION, AUTHORITY, EMAIL FROM tb_employee";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public bool InsertEmployee
            (
                string name, string contact, string position, int authority,
                DateTime startDate, byte[] image, string email, string specialNote
            )
        {
            string sql = @"INSERT INTO tb_employee
                            (EMP_NAME, EMP_CONTACT, POSITION, AUTHORITY, START_DATE, IMAGE, EMAIL, SPECIAL_NOTE)
                            VALUES
                            (@EMP_NAME, @EMP_CONTACT, @POSITION, @AUTHORITY, @START_DATE, @IMAGE, @EMAIL, @SPECIAL_NOTE)";
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@EMP_NAME", name);
            cmd.Parameters.AddWithValue("@EMP_CONTACT", contact);
            cmd.Parameters.AddWithValue("@POSITION", position);
            cmd.Parameters.AddWithValue("@AUTHORITY", authority);
            cmd.Parameters.AddWithValue("@START_DATE", startDate);
            cmd.Parameters.AddWithValue("@IMAGE", image);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", specialNote);

            cmd.ExecuteNonQuery();
            return true;
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

        public List<string> GetEmpInfo(int emp_no, string[] col)
        {
            string sql = $@"SELECT {string.Join(", ", col)} FROM tb_employee WHERE emp_no = @emp_no";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@emp_no", emp_no);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<string> list = new List<string>();

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (!string.IsNullOrEmpty(reader[i].ToString()))
                        list.Add(reader[i].ToString());
                }
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
