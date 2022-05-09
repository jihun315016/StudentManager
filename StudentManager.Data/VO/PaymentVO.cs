using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Data.VO
{
    public class PaymentVO
    {
        public int PaymentNo { get; set; }
        public int CourseNo { get; set; }
        public int StudentNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Money { get; set; }
        public int EmpNo { get; set; }
    }
}
