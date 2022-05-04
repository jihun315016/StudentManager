using StudentManager.Data.DAC;
using System;
using System.Collections.Generic;
using System.Data;

namespace StudentManager.Service.Service
{
    public class PaymentService
    {
        public DataTable GetAllPaymentList()
        {
            PaymentDAC dac = new PaymentDAC();
            DataTable dt = dac.GetAllPaymentList();
            dac.Dispose();
            return dt;
        }

        public DataTable GetPaymentListByStuNo(int stuNo)
        {
            PaymentDAC dac = new PaymentDAC();
            DataTable dt = dac.GetPaymentListByStuNo(stuNo);
            dac.Dispose();
            return dt;
        }

        public bool InsertPayment(int studentNo, int courseNo, DateTime date, int money, int empNo)
        {
            PaymentDAC dac = new PaymentDAC();
            bool result = dac.InsertPayment(studentNo, courseNo, date, money, empNo);
            dac.Dispose();

            return result;
        }

        public bool DeletePayment(int paymentNo)
        {
            PaymentDAC dac = new PaymentDAC();
            bool result = dac.DeletePayment(paymentNo);
            dac.Dispose();

            return result;
        }

        public DataTable SearchPaymentInList(DataTable dt, DateTime start, DateTime end, string stuNo, string courseNo)
        {
            DataView dv = new DataView(dt);
            List<string> list = new List<string>();

            list.Add($"PAYMENT_DATE >=#{start.ToString("yyyy/MM/dd")}#");
            list.Add($"PAYMENT_DATE <=#{end.ToString("yyyy/MM/dd")}#");
            
            // 아무것도 입력하지 않으면 텍스트박스의 PalceHolder 값(문자열)이 된다.
            // 따라서 int 형 변환이 가능한지 체크가 필요함
            if (int.TryParse(stuNo, out int temp1))
                list.Add($"STUDENT_NO = {stuNo}");

            if (int.TryParse(courseNo, out int temp2))
                list.Add($"COURSE_NO = {courseNo}");

            dv.RowFilter = String.Join(" and ", list);

            return dv.ToTable();
        }
    }
}
