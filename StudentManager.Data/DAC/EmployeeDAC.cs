﻿using MySql.Data.MySqlClient;
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
                sql = @"SELECT EMP_NO, EMP_NAME, POSITION, AUTHORITY, EMAIL, END_DATE FROM tb_employee WHERE end_date IS NOT NULL";
            else
                sql = @"SELECT EMP_NO, EMP_NAME, POSITION, AUTHORITY, EMAIL, END_DATE FROM tb_employee WHERE end_date IS NULL";

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

        public bool UpdateEmployee
            (
                int empNo, string name, string contact, string email, string position, int authority,
                DateTime startDate, string specialNote, string imagePath
            )
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(@"UPDATE tb_employee 
                        SET 
	                        EMP_NAME=@EMP_NAME, EMP_CONTACT=@EMP_CONTACT, EMAIL=@EMAIL, POSITION=@POSITION, AUTHORITY=@AUTHORITY, 
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

            cmd.Parameters.AddWithValue("@EMP_NO", empNo);
            cmd.Parameters.AddWithValue("@EMP_NAME", name);
            cmd.Parameters.AddWithValue("@EMP_CONTACT", contact);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@POSITION", position);
            cmd.Parameters.AddWithValue("@AUTHORITY", authority);
            cmd.Parameters.AddWithValue("@START_DATE", startDate);
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", specialNote);
            cmd.Parameters.AddWithValue("@IMAGE", imageByteArr);

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

        public EmployeeVO GetEmployeeInfoByPk(int emp_no)
        {
            string sql = $@"SELECT 
                            EMP_NAME, EMP_CONTACT, POSITION, AUTHORITY, START_DATE, END_DATE, 
                            IMAGE, SALARY, EMAIL, PASSWORD, SPECIAL_NOTE
                            FROM tb_employee WHERE emp_no = @emp_no";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@emp_no", emp_no);

            MySqlDataReader reader = cmd.ExecuteReader();
            
            EmployeeVO emp = new EmployeeVO();

            if (reader.Read())
            {
                emp.Emp_Name = reader["EMP_NAME"].ToString();
                emp.Emp_Contact = reader["EMP_CONTACT"].ToString();
                emp.Position = reader["POSITION"].ToString();
                emp.Authority = int.Parse(reader["AUTHORITY"].ToString());
                emp.StartDate = Convert.ToDateTime(reader["START_DATE"].ToString());
               
                //"System.DBNull"

                emp.EndDate = (reader["END_DATE"] == DBNull.Value) ? new DateTime() : Convert.ToDateTime(reader["END_DATE"].ToString());
                emp.Image = (reader["IMAGE"] == DBNull.Value) ? null : (byte[])reader["IMAGE"];
                emp.Salary = (reader["SALARY"] == DBNull.Value) ? -1 : int.Parse(reader["SALARY"].ToString());
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
    }
}
