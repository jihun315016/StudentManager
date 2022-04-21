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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            ccTxtStudentNo.SetTextBoxPlaceHolder();
            ccTxtClassNo.SetTextBoxPlaceHolder();
            ccTxtSpecialNote.SetTextBoxPlaceHolder();
            
            this.Width = 675;            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StudentService student = new StudentService();

            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                MessageBox.Show("학생 이름을 입력해주세요.");
                return;
            }


            // 학생 연락처 or 보호자 연락처 중 하나라도 입력했는지 확인
            StringBuilder sb = student.ValidContact(txtStudentContact.Text, txtGuardianContact.Text);
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return;
            }
            
            // 보호자 관계 확인
            string guardianRerationship = txtOtherRalationship.Text;
            if (!rdoOther.Checked)
            {
                foreach (Control control in pnlGuardianRerationship.Controls)
                {
                    if (control is RadioButton rdo && rdo.Checked)
                    {
                        guardianRerationship = rdo.Text;
                        break;
                    }
                }                
            }

            // 보호자 정보가 입력되었다면 연락처와 관계가 모두 입력되었는지 확인
            sb = student.ValidGuardian(txtGuardianContact.Text, guardianRerationship);
            if (sb.Length > 1)
            {
                MessageBox.Show(sb.ToString());
                return;
            }

            string specialNote = string.Empty;
            if (!ccTxtSpecialNote.Text.Equals(ccTxtSpecialNote.PlaceHolder))
            {
                specialNote = ccTxtSpecialNote.Text;
            }

            string[] data =
            {
                txtName.Text, txtStudentContact.Text, txtGuardianContact.Text, guardianRerationship,
                TxtSchool.Text, ccTxtAge.Text, dtpStartDate.Value.ToString(), specialNote
            };

            bool result = student.InsertStudent(data);
            if (result)
            {
                MessageBox.Show("등록이 완료되었습니다.");
                txtName.Text = ccTxtAge.Text = txtStudentContact.Text = txtGuardianContact.Text = 
                    ccTxtSpecialNote.Text = txtOtherRalationship.Text = String.Empty;

                ccTxtSpecialNote.SetTextBoxPlaceHolder();

                rdoFather.Checked = rdoMother.Checked = rdoOther.Checked = false;
            }
            else
            {
                MessageBox.Show("등록에 실패하였습니다.");
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

        private void btnOpenInsert_Click(object sender, EventArgs e)
        {
            if (btnOpenInsert.Text.Equals(">>"))
            {
                btnOpenInsert.Text = "<<";
                this.Width = 1000;
            }
            else
            {
                btnOpenInsert.Text = ">>";
                this.Width = 675;
            }
        }
    }
}
