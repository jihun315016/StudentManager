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
            Utility.Util.PanelLocateCenter(this, pnlLogin);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginService login = new LoginService();

            if (login.LoginCheck(txtId.Text, txtPw.Text))
            {
                LoginSesstion.Emp_no = Convert.ToInt32(txtId.Text);

                frmManager frm = new frmManager();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.");
            }
        }
        private void lbl_findPw_Click(object sender, EventArgs e)
        {
            frmFindPw frm = new frmFindPw(); 
            frm.ShowDialog();
        }
    }
}
