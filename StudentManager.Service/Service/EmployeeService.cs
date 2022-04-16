using StudentManager.Data.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Service
{
    public class EmployeeService
    {
        public List<string> GetUserInfo(int emp_no, string[] col)
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<string> list = dac.GetEmpInfo(emp_no, col);
            dac.Dispose();
            return list;
        }
    }
}
