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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();

            ccTxtEmpNo.SetTextBoxHint();
            ccTxtSpecialNote.SetTextBoxHint();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            txtOtherPosition.Visible = false;
            string[] positions = { "강사", "행정", "기타" };
            cboPosition.Items.AddRange(positions);

            string[] authoritys = { "1", "2", "3" };
            cboAuthority.Items.AddRange(authoritys);
        }        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StringBuilder contact = new StringBuilder();            

            foreach (char c in txtContact.Text)
            {
                if (char.IsDigit(c))
                    contact.Append(c);
            }

            EmployeeService employee = new EmployeeService();

            string position = employee.NullCheck(cboPosition.SelectedItem);
            string authority = employee.NullCheck(cboAuthority.SelectedItem);

            string[] txtArr = { txtName.Text, contact.ToString(), ucInputEmail.email, position, authority };
            string[] txtNameArr = { "이름", "연락처", "이메일", "직무", "권한" };

            StringBuilder sb = TextBoxUtil.IsEmptyOrWhiteSpaceArr(txtArr, txtNameArr);
            if (sb.Length > 0)
            {
                MessageBox.Show($"{sb.ToString()}를 입력해주세요.");
                return;
            }

            if (contact.ToString().Length < 11)
                MessageBox.Show("올바른 연락처를 입력해주세요.");
        }

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPosition.SelectedIndex == cboPosition.Items.Count - 1)
            {
                txtOtherPosition.Text = string.Empty;
                txtOtherPosition.Visible = true;
            }
            else
            {
                txtOtherPosition.Visible = false;
                txtOtherPosition.Text = cboPosition.Text;
            }
        }
    }
}
