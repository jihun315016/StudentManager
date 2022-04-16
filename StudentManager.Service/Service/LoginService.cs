using StudentManager.Data.DAC;
using StudentManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Service.Service
{
    public class LoginService : ILogin
    {
        public bool LoginCheck(string id, string pw)
        {
            int emp_no;

            if (!int.TryParse(id, out emp_no))
                return false;
            
            LoginDAC dac = new LoginDAC();
            return dac.GetLoginInfo(emp_no, pw) > 0;
        }        
    }
}
;