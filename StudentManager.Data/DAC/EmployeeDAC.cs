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

        //public bool InsertEmployee()
        //{
        //    string sql = @"INSERT INTO tb_employee
        //                    (EMP_NAME, EMP_CONTACT, POSITION, AUTHORITY, START_DATE, IMAGE, EMAIL, SPECIAL_NOTE)
        //                    VALUES
        //                    (@EMP_NAME, @EMP_CONTACT, @POSITION, @AUTHORITY, @START_DATE, @IMAGE, @EMAIL, @SPECIAL_NOTE)";
            
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);

        //    cmd.Parameters.AddWithValue("@EMP_NAME", txtName.Text);
        //    cmd.Parameters.AddWithValue("@EMP_CONTACT", txtContact.Text);
        //    cmd.Parameters.AddWithValue("@POSITION", position);
        //    cmd.Parameters.AddWithValue("@AUTHORITY", authority);
        //    cmd.Parameters.AddWithValue("@START_DATE", dtpStartDate.Value);
        //    cmd.Parameters.AddWithValue("@IMAGE", imageByteArr);
        //    cmd.Parameters.AddWithValue("@EMAIL", ucEmail.email);
        //    cmd.Parameters.AddWithValue("@SPECIAL_NOTE", ccTxtSpecialNote.Text);

        //    cmd.ExecuteNonQuery();
        //}

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
