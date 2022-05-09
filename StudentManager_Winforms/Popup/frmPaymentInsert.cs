using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
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
            cboEmp.DataSource = empService.GetAllEmpNoName("선택", true);
            cboEmp.DisplayMember = "EMP_INFO";
            cboEmp.ValueMember = "EMP_NO";
        }
       

        private void cboEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmp.SelectedIndex > 0)
            {
                CourseService courseService = new CourseService();
                cboCourse.DataSource = courseService.GetCourseByEmpNo("선택", int.Parse(cboEmp.SelectedValue.ToString()), chkCourseExist.Checked);
                cboCourse.DisplayMember = "COURSE_NAME";
                cboCourse.ValueMember = "COURSE_NO";
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
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
