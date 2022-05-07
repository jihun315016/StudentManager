using StudentManager.Service.Service;
using System;
using System.Text;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLogin_Resize(this, null);
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Left = this.Width / 2 - pnlLogin.Width / 2;
            pnlLogin.Top = this.Height / 2 - pnlLogin.Height / 2 - this.Height / 20;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginService login = new LoginService();

            if (login.LoginCheck(txtId.Text, txtPw.Text))
            {
                int empNo = Convert.ToInt32(txtId.Text);

                frmManager frm = new frmManager(empNo);
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.");
            }
        }

        private void lbl_findPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFindPw frm = new frmFindPw();
            frm.ShowDialog();
        }

        private void txtPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                string[] textBoxValue = { txtId.Text, txtPw.Text };
                string[] textBoxName = { "아이디", "비밀번호" };
                StringBuilder sb = TextBoxUtil.IsEmptyOrWhiteSpaceArr(textBoxValue, textBoxName);
                if (sb.Length > 0)
                {
                    MessageBox.Show($"{sb.ToString()}를 입력해주세요.");
                    return;
                }
                btnLogin_Click(this, null);
            }
        }
    }
}
