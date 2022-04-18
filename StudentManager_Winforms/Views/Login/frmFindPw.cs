using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmFindPw : Form
    {
        public frmFindPw()
        {
            InitializeComponent();
        }

        private void frmFindPw_Load(object sender, EventArgs e)
        {
            frmFindPw_Resize(this, null);

            string[] items =
            {
                "gmail.com",
                "naver.com",
                "daum.net"
            };
            cboEmail.Items.AddRange(items);            
        }

        private void frmFindPw_Resize(object sender, EventArgs e)
        {
            pnlFindPw.Left = this.Width / 2 - pnlFindPw.Width / 2;
            pnlFindPw.Top = this.Height / 2 - pnlFindPw.Height / 2 - this.Height / 20;
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string[] column = { "EMP_NAME", "EMAIL" };
            EmployeeService user = new EmployeeService();

            int emp_no = Convert.ToInt32(txtEmp_no.Text);            

            List<string> list = user.GetUserInfo(emp_no, column);

            string name = list[0];
            string email = list[1];
            string inputEmail = $"{txtEmail1.Text}@{txtEmail2.Text}";

            if (txtName.Text == name && inputEmail == email)
            {
                LoginService login = new LoginService();
                if (login.SendEmail(inputEmail))
                {
                    lblMessage.Text = "임시 비밀번호가 발송되었습니다.";
                    lblMessage.ForeColor = Color.SeaGreen;
                }
                else
                {
                    lblMessage.Text = "메일 발송에 실패했습니다.";
                    lblMessage.ForeColor = Color.Red;
                }
            }
            else
            {
                lblMessage.Text = "잘못된 사용자 정보입니다.";
                lblMessage.ForeColor = Color.Red;
            }            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmp_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b'))
                e.Handled = true;
        }
    }
}
