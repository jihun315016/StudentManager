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
            string[] column = { "EMP_NAME", "POSITION" };
            EmployeeService user = new EmployeeService();

            List<string> list = user.GetEmpInfo(LoginSesstion.Emp_no, column);

            string name = list[0];
            string position = list[1];

            lblUserInfo.Text = $"[{position}] {name}";
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
