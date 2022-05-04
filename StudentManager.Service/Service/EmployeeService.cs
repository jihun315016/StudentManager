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

        public DataTable GetAllEmpNoName(string defaultMsg, bool isOnlyTeacher = false)
        {
            EmployeeDAC dac = new EmployeeDAC();
            DataTable dt = dac.GetAllEmpNoName(isOnlyTeacher);
            dac.Dispose();

            DataRow dr = dt.NewRow();
            dr["EMP_NO"] = -1;
            dr["EMP_NAME"] = string.Empty;
            dr["EMP_INFO"] = defaultMsg;
            dt.Rows.InsertAt(dr, 0);
            
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

        public bool InsertEmployee(EmployeeVO empVO)            
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.InsertEmployee(empVO);
            dac.Dispose();

            return result;
        }

        public bool UpdateEmployeeInfo(EmployeeVO empVO, string imagePath)
        {
            EmployeeDAC dac = new EmployeeDAC();
            bool result = dac.UpdateEmployeeInfo(empVO, imagePath);            
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

        public DataTable SearchByEmpName(DataTable dt, string empName)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"EMP_NAME LIKE '%{empName}%'";
            return dv.ToTable();
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
