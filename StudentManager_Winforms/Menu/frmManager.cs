using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmManager : Form
    {
        public EmployeeVO user { get; set; }

        public frmManager(int empNo)
        {
            InitializeComponent();

            EmployeeService employee = new EmployeeService();
            user = employee.GetEmpInfoByPk(empNo);
            user.Emp_no = empNo;
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
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
            frm.Tag = user;
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
