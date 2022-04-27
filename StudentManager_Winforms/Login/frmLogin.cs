using StudentManager.Service.Service;
using System;
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
    }
}
