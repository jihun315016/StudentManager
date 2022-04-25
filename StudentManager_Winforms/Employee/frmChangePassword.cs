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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(int empNo, string name)
        {
            InitializeComponent();

            lblEmployeeInfo.Text = $"[{empNo}] {name}";
            this.Tag = empNo;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text == txtPassword2.Text)
            {
                MessageBox.Show("비밀번호가 변경되었습니다.");

                EmployeeService empService = new EmployeeService();
                empService.UpdateEmployeePassword(int.Parse(this.Tag.ToString()), txtPassword1.Text);
                this.Close();                    
            }
            else
            {
                MessageBox.Show("비밀번호가 다릅니다.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
