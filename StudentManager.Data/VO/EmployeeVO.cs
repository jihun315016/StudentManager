using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Data.VO
{
    public class EmployeeVO
    {
        public int Emp_no { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Contact { get; set; }
        public string Position { get; set; }
        public int Authority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImgUrl { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SpecialNote { get; set; }
    }
}
