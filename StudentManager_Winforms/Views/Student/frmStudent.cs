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
            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                MessageBox.Show("학생 이름을 입력해주세요.");
                return;
            }

            int studentCnt = TextBoxUtil.ValidContactCnt(txtStudentContact.Text);
            int GuardianCnt = TextBoxUtil.ValidContactCnt(txtGuardianContact.Text);            

            if(studentCnt + GuardianCnt == 0)
            {
                MessageBox.Show("학생 연락처와 보호자 연락처 중 하나는 입력해주세요.");
                return;
            }
            
            if (studentCnt > 0 && studentCnt < 11)
            {
                MessageBox.Show("잘못된 학생 연락처입니다.");
                return;
            }

            if (GuardianCnt > 0 && GuardianCnt < 11)
            {
                MessageBox.Show("잘못된 보호자 연락처입니다.");
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
    }
}
