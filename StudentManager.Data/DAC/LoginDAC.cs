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
    public class LoginDAC : IDisposable
    {
        MySqlConnection conn;

        public LoginDAC()
        {
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public int GetLoginInfo(int emp_no, string password)
        {
            string sql = @"SELECT count(emp_no) FROM tb_employee WHERE emp_no = @emp_no AND password = @password";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@emp_no", emp_no);
            cmd.Parameters.AddWithValue("@password", password);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
