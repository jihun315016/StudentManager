using MySql.Data.MySqlClient;
using StudentManager.Data.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
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

        public DataTable GetAllEmployeeInfo(bool isResignation)
        {
            string sql;
            if(isResignation)
                sql = @"SELECT EMP_NO, EMP_NAME, POSITION, EMAIL, START_DATE, END_DATE FROM tb_employee WHERE END_DATE IS NOT NULL";
            else
                sql = @"SELECT EMP_NO, EMP_NAME, POSITION, EMAIL, START_DATE, END_DATE FROM tb_employee WHERE END_DATE IS NULL";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }
        public DataTable GetAllEmpNoName(bool isOnlyTeacher = false)
        {
            string sql;
            if (isOnlyTeacher == true)
                sql = @"SELECT EMP_NO, EMP_NAME, concat(EMP_NO, '-' ,EMP_NAME) EMP_INFO FROM tb_employee WHERE POSITION in ('원장', '강사')";
            else
                sql = @"SELECT EMP_NO, EMP_NAME, concat(EMP_NO, '-' ,EMP_NAME) EMP_INFO FROM tb_employee";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public EmployeeVO GetEmployeeInfoByPk(int emp_no)
        {
            string sql = $@"SELECT 
                            EMP_NAME, EMP_CONTACT, POSITION, START_DATE, END_DATE, 
                            IMAGE, EMAIL, PASSWORD, SPECIAL_NOTE
                            FROM tb_employee WHERE emp_no = @emp_no";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@emp_no", emp_no);

            MySqlDataReader reader = cmd.ExecuteReader();

            EmployeeVO emp = new EmployeeVO();

            if (reader.Read())
            {
                emp.EmpName = reader["EMP_NAME"].ToString();
                emp.EmpContact = reader["EMP_CONTACT"].ToString();
                emp.Position = reader["POSITION"].ToString();
                emp.StartDate = Convert.ToDateTime(reader["START_DATE"].ToString());

                //"System.DBNull"

                emp.EndDate = (reader["END_DATE"] == DBNull.Value) ? new DateTime() : Convert.ToDateTime(reader["END_DATE"].ToString());
                emp.Image = (reader["IMAGE"] == DBNull.Value) ? null : (byte[])reader["IMAGE"];
                emp.Email = reader["EMAIL"].ToString();
                emp.Password = reader["PASSWORD"].ToString();
                emp.SpecialNote = reader["SPECIAL_NOTE"].ToString();

                return emp;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetPosition()
        {
            string sql = "SELECT POSITION FROM tb_employee GROUP BY POSITION";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool InsertEmployee(EmployeeVO empVO)            
        {
            string sql = @"INSERT INTO tb_employee
                            (EMP_NAME, EMP_CONTACT, POSITION, START_DATE, IMAGE, EMAIL, SPECIAL_NOTE)
                            VALUES
                            (@EMP_NAME, @EMP_CONTACT, @POSITION, @START_DATE, @IMAGE, @EMAIL, @SPECIAL_NOTE)";
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@EMP_NAME", empVO.EmpName);
            cmd.Parameters.AddWithValue("@EMP_CONTACT", empVO.EmpContact);
            cmd.Parameters.AddWithValue("@POSITION", empVO.Position);
            cmd.Parameters.AddWithValue("@START_DATE", empVO.StartDate);
            cmd.Parameters.AddWithValue("@IMAGE", empVO.Image);
            cmd.Parameters.AddWithValue("@EMAIL", empVO.Email);
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", empVO.SpecialNote);

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

        public bool UpdateEmployeeInfo(EmployeeVO empVO, string imagePath)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(@"UPDATE tb_employee 
                        SET 
	                        EMP_NAME=@EMP_NAME, EMP_CONTACT=@EMP_CONTACT, EMAIL=@EMAIL, POSITION=@POSITION, 
                            START_DATE=@START_DATE, SPECIAL_NOTE=@SPECIAL_NOTE ");            


            // 이미지가 수정되지 않았다면 아예 건들지 않는다.
            byte[] imageByteArr;
            if (imagePath != null)
            {
                sql.Append(",IMAGE=@IMAGE WHERE EMP_NO=@EMP_NO");
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    BinaryReader br = new BinaryReader(fs);
                    imageByteArr = br.ReadBytes((int)fs.Length);
                }
            }   
            else
            {
                sql.Append("WHERE EMP_NO=@EMP_NO");
                imageByteArr = null;
            }

            MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);

            cmd.Parameters.AddWithValue("@EMP_NO", empVO.EmpNo);
            cmd.Parameters.AddWithValue("@EMP_NAME", empVO.EmpName);
            cmd.Parameters.AddWithValue("@EMP_CONTACT", empVO.EmpContact);
            cmd.Parameters.AddWithValue("@EMAIL", empVO.Email);
            cmd.Parameters.AddWithValue("@POSITION", empVO.Position);
            cmd.Parameters.AddWithValue("@START_DATE", empVO.StartDate);
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", empVO.SpecialNote);
            cmd.Parameters.AddWithValue("@IMAGE", imageByteArr);

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

        public bool UpdateEmployeePassword(int empNo, string newPassword)
        {
            string sql = @"UPDATE tb_employee SET password=@password WHERE emp_no=@emp_no";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@emp_no", empNo);
            cmd.Parameters.AddWithValue("@password", newPassword);

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

        public bool UpdateEndDate(EmployeeVO empVO, bool isResignation)
        {
            string sql;
            if (isResignation) // 퇴사
                sql = @"UPDATE tb_employee SET END_DATE=@NEW_DATE WHERE EMP_NO=@EMP_NO";
            else // 재입사
                sql = @"UPDATE tb_employee SET START_DATE=@NEW_DATE, END_DATE=NULL WHERE EMP_NO=@EMP_NO";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@EMP_NO", empVO.EmpNo);
            cmd.Parameters.AddWithValue("@NEW_DATE", empVO.EndDate);
            
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
