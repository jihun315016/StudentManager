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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            ccTxtStudentNo.SetTextBoxHint();
            ccTxtClassNo.SetTextBoxHint();
            ccTxtSpecialNote.SetTextBoxHint();
            
            //this.Width = 675;            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StudentService student = new StudentService();

            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                MessageBox.Show("학생 이름을 입력해주세요.");
                return;
            }


            StringBuilder sb = student.ValidContact(txtStudentContact.Text, txtGuardianContact.Text);
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return;
            }
        }    

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOther.Checked)
            {
                txtOtherRalationship.Visible = true;
                txtOtherRalationship.Text = String.Empty;
            }
            else
            {
                txtOtherRalationship.Visible = false;
            }
        }

        private void TxtSchool_MouseClick(object sender, MouseEventArgs e)
        {
            frmSearchSchool pop = new frmSearchSchool();
            if (pop.ShowDialog() == DialogResult.OK)
                TxtSchool.Text = pop.SchoolName;
        }

        private void TxtSchool_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
