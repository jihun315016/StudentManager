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
        public List<string> GetEmpInfo(int emp_no, string[] col)
        {
            EmployeeDAC dac = new EmployeeDAC();
            List<string> list = dac.GetEmpInfo(emp_no, col);
            dac.Dispose();
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
