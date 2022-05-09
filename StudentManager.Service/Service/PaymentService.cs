using StudentManager.Data.DAC;
using StudentManager.Data.VO;
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

        public bool InsertPayment(PaymentVO paymentVO)
        {
            PaymentDAC dac = new PaymentDAC();
            bool result = dac.InsertPayment(paymentVO);
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

        public DataTable SearchPaymentInList(DataTable dt, DateTime start, DateTime end)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"PAYMENT_DATE >=#{start.ToString("yyyy/MM/dd")}# and PAYMENT_DATE <=#{end.ToString("yyyy/MM/dd")}#";
            return dv.ToTable();
        }
    }
}
