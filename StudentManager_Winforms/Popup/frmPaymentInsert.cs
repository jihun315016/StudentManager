using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmPaymentInsert : Form
    {
        EmployeeVO user;

        public frmPaymentInsert()
        {
            InitializeComponent();
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void frmPaymentInsert_Load(object sender, EventArgs e)
        {
            this.user = (EmployeeVO)this.Tag;

            EmployeeService empService = new EmployeeService();
            DataTable dt = empService.GetAllEmpNoName(true);
            DataRow dr = dt.NewRow();
            dr["EMP_NO"] = -1;
            dr["EMP_NAME"] = string.Empty;
            dr["EMP_INFO"] = "선택";
            dt.Rows.InsertAt(dr, 0);

            cboEmp.DataSource = dt;
            cboEmp.DisplayMember = "EMP_INFO";
            cboEmp.ValueMember = "EMP_NO";
        }
       

        private void cboEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmp.SelectedIndex > 0)
            {
                CourseService courseService = new CourseService();
                DataTable dt = courseService.GetCourseByEmpNo(int.Parse(cboEmp.SelectedValue.ToString()), chkCourseExist.Checked);
                DataRow dr = dt.NewRow();
                dr["COURSE_NO"] = -1;
                dr["COURSE_NAME"] = "선택";
                dt.Rows.InsertAt(dr, 0);

                cboCourse.DataSource = dt;
                cboCourse.DisplayMember = "COURSE_NAME";
                cboCourse.ValueMember = "COURSE_NO";
            }
            else
            {
                cboStudent.DataSource = null;
                cboCourse.DataSource = null;
            }

        }

        private void chkCourseExist_CheckedChanged(object sender, EventArgs e)
        {
            cboEmp_SelectedIndexChanged(this, null);
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourse.SelectedIndex > 0)
            {
                StudentService stuService = new StudentService();
                cboStudent.DataSource = stuService.GetStudentListByCourse(int.Parse(cboCourse.SelectedValue.ToString()));
                cboStudent.DisplayMember = "STUDENT_NAME";
                cboStudent.ValueMember = "STUDENT_NO";
            }
            else
            {
                cboStudent.DataSource = null;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cboEmp.SelectedIndex <= 0)            
                MessageBox.Show("선생님을 선택해주세요.");
            else if (cboCourse.SelectedIndex <= 0)
                MessageBox.Show("수업을 선택해주세요.");
            else if (cboStudent.SelectedIndex < 0)
                MessageBox.Show("학생을 선택해주세요.");
            else
            {
                PaymentVO paymentVO = new PaymentVO()
                {
                    CourseNo = int.Parse(cboCourse.SelectedValue.ToString()),
                    StudentNo = int.Parse(cboStudent.SelectedValue.ToString()),
                    PaymentDate = Convert.ToDateTime(dtpDate.Value.ToString("yyyy-MM-dd")),
                    Money = int.Parse(txtMoney.Text),
                    EmpNo = int.Parse(cboEmp.SelectedValue.ToString())
                };

                PaymentService payService = new PaymentService();
                bool insertResult = payService.InsertPayment(paymentVO);
                if (insertResult)
                {
                    MessageBox.Show("결제가 등록되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("결제 등록에 실패하셨습니다.");
                }
            }

        }
    }
}
