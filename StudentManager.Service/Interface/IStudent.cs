using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Service.Interface
{
    interface IStudent
    {
        StringBuilder ValidContact(string stuContact, string guardContact);
    }
}
