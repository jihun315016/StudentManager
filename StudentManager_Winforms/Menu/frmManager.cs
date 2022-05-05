using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Drawing;
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
            user.EmpNo = empNo;
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            lblUserInfo.Text = $"[{user.Position}] {user.EmpName}";
        }
       
        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmStudent>();

            //if (isExist)
            //{
            //    btnStudent.ForeColor = Color.White;
            //    btnStudent.BackColor = Color.Blue;
            //}
            //else
            //{
            //    btnStudent.ForeColor = Color.Black;
            //    this.btnStudent.BackColor = SystemColors.Control;
            //}
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmEmployee>();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenCreateForm<frmPayment>();
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

        private void btnMyPage_Click(object sender, EventArgs e)
        {
            frmEmployDetail pop = new frmEmployDetail(user);
            pop.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
