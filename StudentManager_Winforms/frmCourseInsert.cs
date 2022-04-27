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
    public partial class frmCourseInsert : Form
    {
        public frmCourseInsert()
        {
            InitializeComponent();
        }

        private void frmCourseInsert_Load(object sender, EventArgs e)
        {
            int x = ((frmCourse)this.Tag).Left + ((frmCourse)this.Tag).Width;
            int y = ((frmCourse)this.Tag).Top;

            this.Location = new Point(x, y);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string[] textBoxValue = { txtEmpNo.Text, txtCourse.Text, txtPayment.Text };
            string[] textBoxName = { "직원 번호", "수업", "회비" };
            StringBuilder sb = TextBoxUtil.IsEmptyOrWhiteSpaceArr(textBoxValue, textBoxName);
            if (sb.Length > 0)
            {
                MessageBox.Show($"{sb.ToString()}을 입력해주세요.");
                return;
            }

            EmployeeService dac = new EmployeeService();
            EmployeeVO empVO = dac.GetEmpInfoByPk(int.Parse(txtEmpNo.Text));
        }

        private void txtEmpNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtEmpNo_Leave(object sender, EventArgs e)
        {
            EmployeeService dac = new EmployeeService();

            int empNo;

            if (!int.TryParse(txtEmpNo.Text, out empNo))
                lblEmpName.Text = "잘못된 사원번호 입니다.";
            else
                lblEmpName.Text = dac.CheckDirectorOrTeacherByEmpNo(empNo);
        }

    }
}
