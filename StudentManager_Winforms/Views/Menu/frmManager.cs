using MySql.Data.MySqlClient;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string[] column = { "EMP_NAME", "POSITION" };
            EmployeeService user = new EmployeeService();

            List<string> list = user.GetUserInfo(LoginSesstion.Emp_no, column);

            string name = list[0];
            string position = list[1];

            lblUserInfo.Text = $"[{position}] {name}";
        }
       
        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent frm = new frmStudent();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance frm = new frmAttendance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnContest_Click(object sender, EventArgs e)
        {
            frmContest frm = new frmContest();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            frmCourse frm = new frmCourse();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
