using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmPayment : Form
    {
        EmployeeVO user;

        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            this.user = (EmployeeVO)this.Tag;

            ccTxtStudentNo.SetTextBoxPlaceHolder();
            ccTxtCourseNo.SetTextBoxPlaceHolder();

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 번호", "STUDENT_NO", alignContent:DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생", "STUDENT_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수업 번호  ", "COURSE_NO", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수업", "COURSE_NAME", 140);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "결제 금액", "MONEY", 80, alignContent:DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "결제 직원", "EMP_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "날짜", "PAYMENT_DATE", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "직원 번호", "EMP_NO", isVisible:false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "결제 번호", "PAYMENT_NO", isVisible: false);

            PaymentService payService = new PaymentService();
            bdsPaymentSoarse.DataSource = payService.GetAllPaymentList();
            dgvList.DataSource = payService.GetAllPaymentList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PaymentService payService = new PaymentService();

            int stuNo; // = int.Parse(ccTxtStudentNo.Text);
            int courseNo; // = int.Parse(ccTxtCourseNo.Text);
            
            dgvList.DataSource = payService.SearchPaymentInList
                (
                    (DataTable)bdsPaymentSoarse.DataSource, ucDateFilter.StartDate, ucDateFilter.EndDate, ccTxtStudentNo.Text, ccTxtCourseNo.Text
                )
                .Copy();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (user.Authority > 2)
            {
                MessageBox.Show("권한이 없습니다.");
                return;
            }

            frmPaymentInsert pop = new frmPaymentInsert();
            pop.Tag = this.user;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                PaymentService payService = new PaymentService();
                dgvList.DataSource = payService.GetAllPaymentList();
                bdsPaymentSoarse.DataSource = payService.GetAllPaymentList();
            }
        }

        private void txtOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (user.Authority == 1 && e.Button == MouseButtons.Right)
            {
                dgvList.CurrentCell = dgvList[e.ColumnIndex, e.RowIndex];
                cmsSetting.Show(Cursor.Position);

                tsmCancelPayment.Visible = true;
            }
        }

        private void tsmCancelPayment_Click(object sender, EventArgs e)
        {
            int courseNo = int.Parse(dgvList.CurrentRow.Cells["PAYMENT_NO"].Value.ToString());

            DialogResult deleteChk = MessageBox.Show("결제를 취소하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
            if (deleteChk == DialogResult.Yes)
            {
                PaymentService payService = new PaymentService();
                bool deleteResult = payService.DeletePayment(courseNo);
                if (deleteResult)
                {
                    MessageBox.Show("결제가 취소되었습니다.");
                    dgvList.DataSource = payService.GetAllPaymentList();
                    bdsPaymentSoarse.DataSource = payService.GetAllPaymentList();
                }
                else
                {
                    MessageBox.Show("삭제에 실패했습니다.");
                }
            }
        }
    }
}
