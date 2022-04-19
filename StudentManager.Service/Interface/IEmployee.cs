using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Interface
{
    internal interface IEmployee
    {
        List<string> GetUserInfo(int emp_no, string[] col);

        string NullCheck(dynamic text);
    }
}
