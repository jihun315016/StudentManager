using StudentManager.Data.DAC;
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
        public DataTable GetAllEmployeeInfo(bool isResignation)
        {
            EmployeeDAC dac = new EmployeeDAC();
            DataTable dt = dac.GetAllEmployeeInfo(isResignation);
            dac.Dispose();
            return dt;
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

        public bool UpdateEmployeeInfo
            (
                int empNo, string name, string contact, string email, string position, int authority,
                DateTime startDate, string specialNote, string imagePath
            )
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateEmployeeInfo(empNo, name, contact, email, position, authority, startDate, specialNote, imagePath);            
            dac.Dispose();

            return result;
        }

        public bool UpdateEmployeePassword(int empNo, string newPassword)
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateEmployeePassword(empNo, newPassword);
            dac.Dispose();

            return result;
        }

        public bool UpdateEndDate(int empNo, DateTime newDate, bool isResignation)
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateEndDate(empNo, newDate, isResignation);
            dac.Dispose();
            return result;
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

        public int SearchEmpInList(int empNo, DataTable dt, string sortCol)
        {
            DataView dv = new DataView(dt);

            dv.Sort = sortCol;
            return dv.Find(empNo);
        }

        public DataTable SearchDateInList(DateTime start, DateTime end, DataTable dt, bool isResignations)
        {
            DataView dv = new DataView(dt);

            if (isResignations)            
                dv.RowFilter = $"END_DATE >= #{start.ToString("yyyy/MM/dd")}# and END_DATE <= #{end.ToString("yyyy/MM/dd")}#";
            else            
                dv.RowFilter = $"START_DATE >= #{start.ToString("yyyy/MM/dd")}# and START_DATE <= #{end.ToString("yyyy/MM/dd")}#";

            return dv.ToTable();
        }        
    }
}
