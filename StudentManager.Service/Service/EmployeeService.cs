using StudentManager.Data.DAC;
using StudentManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Service
{
    public class EmployeeService : IEmployee
    {
        public List<string> GetUserInfo(int emp_no, string[] col)
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<string> list = dac.GetEmpInfo(emp_no, col);
            dac.Dispose();
            return list;
        }

        public string[] NullCheck(object position, object authority)
        {
            if (!(position is string))
                position = string.Empty;

            if (!(authority is string))
                authority = string.Empty;

            return new string[2] { position.ToString(), authority.ToString() };
        }
    }
}
