using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
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
            lblMessage.Text = string.Empty;

            string[] txtArr = { txtName.Text, ccTxtEmp_no.Text, ucInputEmail.email};
            string[] txtNameArr = { "이름", "사번", "이메일" };

            StringBuilder sb = TextBoxUtil.IsEmptyOrWhiteSpaceArr(txtArr, txtNameArr);
            if (sb.Length > 0)
            {
                MessageBox.Show($"{sb.ToString()}를 입력해주세요.");
                return;
            }            

            string[] column = { "EMP_NAME", "EMAIL" };
            int emp_no = Convert.ToInt32(ccTxtEmp_no.Text);

            EmployeeService user = new EmployeeService();
            List<string> list = user.GetEmpInfo(emp_no, column);            

            if (list != null)
            {
                LoginService login = new LoginService();

                string name = list[0];
                string email = list[1];
                string newPassword = login.MakePassword();

                if (txtName.Text == name && ucInputEmail.email == email)
                {
                    if (login.SendEmail(name, ucInputEmail.email, newPassword) && login.ChangePassword(emp_no, newPassword))
                    {
                        lblMessage.Text = "임시 비밀번호가 발송되었습니다.";
                        lblMessage.ForeColor = Color.SeaGreen;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("메일 발송에 실패했습니다.");
                        return;
                    }
                }
            }
            
            lblMessage.Text = "잘못된 사용자 정보입니다.";
            lblMessage.ForeColor = Color.Red;                        
        }

        private void txtEmp_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b'))
                e.Handled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
