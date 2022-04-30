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
    public partial class frmPaymentInsert : Form
    {
        EmployeeVO user;

        public frmPaymentInsert()
        {
            InitializeComponent();
        }
        private void frmPaymentInsert_Load(object sender, EventArgs e)
        {
            this.user = (EmployeeVO)this.Tag;

            lblStudentName.Visible = false;
            lblEmpName.Visible = false;
            lblCourseName.Visible = false;
        }
        
        private void txtOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtStudentNo_Leave(object sender, EventArgs e)
        {
            if (txtStudentNo.Text == string.Empty)
            {
                lblStudentName.Visible = true;
                lblStudentName.Text = "학생 번호를 입력해주세요.";
                lblStudentName.ForeColor = Color.Red;
                return;
            }

            lblStudentName.Visible = true;
            StudentService stuService = new StudentService();

            StudentVO studentVO = stuService.GetStudentInfoByPk(int.Parse(txtStudentNo.Text));

            if (studentVO == null)
            {
                lblStudentName.Text = "잘못된 학생 번호입니다.";
                lblStudentName.ForeColor = Color.Red;
            }
            else
            {
                lblStudentName.Text = studentVO.StudentName;
                lblStudentName.ForeColor = Color.Green;
            }
        }

        private void txtCourseNo_Leave(object sender, EventArgs e)
        {
            if (txtCourseNo.Text == string.Empty)
            {
                lblCourseName.Visible = true;
                lblCourseName.Text = "수업 번호를 입력해주세요.";
                lblCourseName.ForeColor = Color.Red;
                return;
            }

            lblEmpName.Visible = true;
            lblCourseName.Visible = true;

            CourseService courseService = new CourseService();
            EmployeeCourseVO empCourseVO = courseService.GetCourseInfoByPk(int.Parse(txtCourseNo.Text));

            if (empCourseVO == null)
            {
                lblCourseName.Text = "잘못된 수업 번호입니다.";
                lblCourseName.ForeColor = Color.Red;
                lblEmpName.Visible = false;
            }
            else
            {
                lblCourseName.Text = empCourseVO.CourseName;
                lblEmpName.Text = empCourseVO.EmpName;

                lblCourseName.ForeColor = Color.Green;
                lblEmpName.ForeColor = Color.Green;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("결제 처리 하시겠습니까?", "결제 등록", MessageBoxButtons.YesNo);

            if (msgResult == DialogResult.Yes)
            {
                int stuNo = int.Parse(txtStudentNo.Text);
                int courseNo = int.Parse(txtCourseNo.Text);
                int money = int.Parse(txtMoney.Text);
                int empNo = user.EmpNo;
                DateTime date = dtpDate.Value;

                CourseService courseService = new CourseService();
                PaymentService payService = new PaymentService();
                int stuCnt = courseService.GetCountStudentInCourse(stuNo, courseNo);

                // 해당 수업과 학생이 일치하지 않거나 결제에 실패할 결우
                if (stuCnt == 0 || !payService.InsertPayment(stuNo, courseNo, date, money, empNo))
                {                    
                    MessageBox.Show("잘못된 입력입니다.");
                }
                else
                {
                    MessageBox.Show("결제를 등록했습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }
    }
}
