using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Data.VO
{
    public class StudentVO
    {
        public int StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentContact { get; set; }
        public string GuardianContact { get; set; }
        public string GuardianRalationship { get; set; }
        public string School { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EndReasonNo { get; set; }
        public string SpecialNote { get; set; }
    }
}
