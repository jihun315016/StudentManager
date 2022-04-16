using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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
