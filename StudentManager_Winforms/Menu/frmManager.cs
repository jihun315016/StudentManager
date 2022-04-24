using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }        
        private void frmManager_Load(object sender, EventArgs e)
        {
#if DEBUG
            lblUserInfo.Text = $"[직무] 디버그";
            return;
#endif
            EmployeeService employee = new EmployeeService();

            EmployeeVO user = employee.GetEmpInfoByPk(LoginSesstion.Emp_no);

            lblUserInfo.Text = $"[{user.Position}] {user.Emp_Name}";
        }
       
        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmStudent>();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmEmployee>();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmAttendance>();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmPayment>();
        }

        private void btnContest_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmContest>();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmCourse>();
        }

        void OpenCreateForm<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }
            }

            T frm = new T();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
