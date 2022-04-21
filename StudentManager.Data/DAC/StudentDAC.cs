using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
    }
}
