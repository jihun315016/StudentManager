using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Data.VO
{
    public class CourseVO
    {
        public int CourseNo { get; set; }
        public int EmpNo { get; set; }
        public string CourseName { get; set; }
        public int Payment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
