using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager_Winforms.Controls
{
    public partial class ucInputEmail : UserControl
    {
        public string Email 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtEmail1.Text) && string.IsNullOrWhiteSpace(txtEmail2.Text))
                    return string.Empty;

                return $"{txtEmail1.Text}@{txtEmail2.Text}";
            }
        }

        public string FrontEmail 
        { 
            get { return txtEmail1.Text; }
            set { txtEmail1.Text = value; }
        }

        public string RearEmail
        {
            get { return txtEmail2.Text; }
            set { txtEmail2.Text = value; }
        }

        public ucInputEmail()
        {
            InitializeComponent();
        }

        private void ucInputEmail_Load(object sender, EventArgs e)
        {
            string[] items =
            {
                "gmail.com",
                "naver.com",
                "daum.net",
                "직접 입력"
            };

            cboEmail.Items.AddRange(items);
            txtEmail2.Enabled = false;
        }

        private void cboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 직접 입력
            if (cboEmail.SelectedIndex == cboEmail.Items.Count - 1)
            {
                txtEmail2.Text = string.Empty;
                txtEmail2.Enabled = true;
            }
            else
            {
                txtEmail2.Enabled = false;
                txtEmail2.Text = cboEmail.Text;
            }
        }

        public void ClearText()
        {
            txtEmail1.Text = txtEmail2.Text = String.Empty;
            cboEmail.Text = string.Empty;
            cboEmail.SelectedItem = null;
        }

        public void ReadOnly(bool isReadOnly)
        {
            txtEmail1.ReadOnly = isReadOnly;
            txtEmail2.ReadOnly = isReadOnly;
            cboEmail.Visible = !isReadOnly;
        }

        private void txtEmail1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isLower = e.KeyChar >= 'a' && e.KeyChar <= 'z';
            bool isUpper = e.KeyChar >= 'A' && e.KeyChar <= 'Z';
            bool isNumber = e.KeyChar >= 0 && e.KeyChar <= 9;
            bool isSpecial = e.KeyChar == '\b';

            if (!isLower && !isUpper && isNumber && !isSpecial)
                e.Handled = true;
        }
    }
}
