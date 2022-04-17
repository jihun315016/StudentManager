using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
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

            int emp_no;
            if (!int.TryParse(txtEmp_no.Text, out emp_no))
            {
                lblMessage.Text = "잘못된 사번입니다.";
                return;
            }

            List<string> list = user.GetUserInfo(emp_no, column);

            string name = list[0];
            string email = list[1];
            string inputEmail = $"{txtEmail1.Text}@{txtEmail2.Text}";

            if (txtName.Text == name && inputEmail == email)
            {
                LoginService login = new LoginService();
                if (login.SendEmail(inputEmail))
                    lblMessage.Text = "임시 비밀번호가 발송되었습니다.";
                else
                    lblMessage.Text = "메일 발송에 실패했습니다.";
            }
            else
            {
                lblMessage.Text = "잘못된 사용자 정보입니다.";
            }            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
