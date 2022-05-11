using StudentManager.Data.DAC;
using StudentManager.Data.VO;
using System;
using System.Collections.Generic;
using System.Data;

namespace StudentManager.Service.Service
{
    public class PaymentService
    {
        /// <summary>
        /// 결제 내역 조회
        /// 내역은 300개까지만 표시된다.
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllPaymentList()
        {
            PaymentDAC dac = new PaymentDAC();
            DataTable dt = dac.GetAllPaymentList();
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 특정 학생에 대한 결제 내역 조회
        /// </summary>
        /// <param name="stuNo">조회할 학생 번호</param>
        /// <returns></returns>
        public DataTable GetPaymentListByStuNo(int stuNo)
        {
            PaymentDAC dac = new PaymentDAC();
            DataTable dt = dac.GetPaymentListByStuNo(stuNo);
            dac.Dispose();
            return dt;
        }

        /// <summary>
        /// 결제 등록 처리
        /// </summary>
        /// <param name="paymentVO">등록할 결제 정보</param>
        /// <returns></returns>
        public bool InsertPayment(PaymentVO paymentVO)
        {
            PaymentDAC dac = new PaymentDAC();
            bool result = dac.InsertPayment(paymentVO);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 결제 취소 처리
        /// </summary>
        /// <param name="paymentNo">최소할 결제 번호</param>
        /// <returns></returns>
        public bool DeletePayment(int paymentNo)
        {
            PaymentDAC dac = new PaymentDAC();
            bool result = dac.DeletePayment(paymentNo);
            dac.Dispose();

            return result;
        }

        /// <summary>
        /// 날짜 범위에 대한 결제 조회(필터링)
        /// </summary>
        /// <param name="dt">기존 데이터 테이블</param>
        /// <param name="start">조회 시작 날짜</param>
        /// <param name="end">조회 종료 날짜</param>
        /// <returns></returns>
        public DataTable SearchPaymentInList(DataTable dt, DateTime start, DateTime end)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"PAYMENT_DATE >=#{start.ToString("yyyy/MM/dd")}# and PAYMENT_DATE <=#{end.ToString("yyyy/MM/dd")}#";
            return dv.ToTable();
        }
    }
}
