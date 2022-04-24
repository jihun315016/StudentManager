﻿using StudentManager.Data.DAC;
using StudentManager.Data.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Service
{
    public class EmployeeService
    {
        public DataTable GetAllEmployeeInfo()
        {
            EmployeeDAC dac = new EmployeeDAC();
            DataTable dt = dac.GetAllEmployeeInfo();
            dac.Dispose();
            return dt;
        }

        public bool InsertEmployee
            (
                string name, string contact, string position, int authority,
                DateTime startDate, byte[] image, string email, string specialNote
            )
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.InsertEmployee(name, contact, position, authority, startDate, image, email, specialNote);
            dac.Dispose();

            return result;
        }

        public bool UpdateEmployee
            (
                int empNo, string name, string contact, string email, string position, int authority,
                DateTime startDate, string specialNote, string imagePath
            )
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateEmployee(empNo, name, contact, email, position, authority, startDate, specialNote, imagePath);            
            dac.Dispose();

            return result;
        }

        public EmployeeVO GetEmpInfoByPk(int empNo)
        {
            EmployeeDAC dac = new EmployeeDAC();
            EmployeeVO emploeyeeVO = dac.GetEmployeeInfoByPk(empNo);
            dac.Dispose();
            return emploeyeeVO;
        }

        public List<string> GetPosition()
        {
            EmployeeDAC dac = new EmployeeDAC();
            DataTable dt = dac.GetPosition();
            List<string> list = new List<string>();

            foreach (DataRow dr in dt.Rows)
                list.Add(dr["POSITION"].ToString());

            return list;
        }

        // text가 null이면 ToString() 메서드를 사용할 때
        // 오류가 발생하기 때문에 메서드로 만든 것
        public string NullCheck(object text)
        {
            string result = string.Empty;
            if (text is string)
                result = text.ToString();

            return result;
        }
    }
}
