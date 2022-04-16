using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Interface
{
    internal interface ILogin
    {
        bool LoginCheck(string id, string pw);
    }
}
