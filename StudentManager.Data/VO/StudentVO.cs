using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Data.VO
{
    public class StudentVO
    {
        public int Student_no { get; set; }
        public string Student_Name { get; set; }
        public string Student_Contact { get; set; }
        public string Guardian_Contact { get; set; }
        public string Guardian_ralationship { get; set; }
        public string School { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EndReasonNo { get; set; }
        public string SpecialNote { get; set; }
    }
}
