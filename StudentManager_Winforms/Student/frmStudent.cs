using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmStudent : Form
    {
        EmployeeVO user;

        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            user = (EmployeeVO)this.Tag;

            // TextBox PlaceHolder 설정
            ccTxtStudentNo.SetTextBoxPlaceHolder();
            ccTxtClassNo.SetTextBoxPlaceHolder();
            ccTxtSpecialNote.SetTextBoxPlaceHolder();

            // DataGridView 초기 설정
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 번호", "STUDENT_NO");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이름", "STUDENT_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "나이", "AGE", 60);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 연락처", "STUDENT_CONTACT", 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "보호자 연락처", "GUARDIAN_CONTACT", 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "보호자 관계", "GUARDIAN_RERATIONSHIP");

            DataGridViewUtil.SetRowAlignment(dgvList, new string[] { "STUDENT_NO", "AGE" }, DataGridViewContentAlignment.MiddleRight);

            StudentService student = new StudentService();
            dgvList.DataSource = student.GetAllStudentInfo(false);

            // 초기 화면 크기
            this.Width = 645;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();

            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                MessageBox.Show("학생 이름을 입력해주세요.");
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

            // 학생 연락처, 보호자 연락처, 보호자 관계 유효성 검사
            StringBuilder sb = studentService.ValidContactAndGuardian(txtStudentContact.Text, txtGuardianContact.Text, guardianRerationship);
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return;
            }
            

            string specialNote;
            if (!ccTxtSpecialNote.Text.Equals(ccTxtSpecialNote.PlaceHolder))
            {
                specialNote = ccTxtSpecialNote.Text;
            }

            string[] data =
            {
                txtName.Text, txtStudentContact.Text, txtGuardianContact.Text, guardianRerationship,
                txtSchool.Text, txtAge.Text, dtpStartDate.Value.ToString(), ccTxtSpecialNote.Text
            };

            bool result = studentService.InsertStudent
                (
                       txtName.Text, txtStudentContact.Text, txtGuardianContact.Text, guardianRerationship,
                    txtSchool.Text, int.Parse(txtAge.Text), dtpStartDate.Value, ccTxtSpecialNote.Text
                );

            if (result)
            {
                MessageBox.Show("등록이 완료되었습니다.");
                txtName.Text = txtAge.Text = txtStudentContact.Text = txtGuardianContact.Text =
                    txtSchool.Text = ccTxtSpecialNote.Text = txtOtherRalationship.Text = String.Empty;

                ccTxtSpecialNote.SetTextBoxPlaceHolder();

                dtpStartDate.Value = DateTime.Now;

                rdoFather.Checked = rdoMother.Checked = rdoOther.Checked = false;

                dgvList.DataSource = studentService.GetAllStudentInfo(false);
            }
            else
            {
                MessageBox.Show("등록에 실패하였습니다.");
            }
        }

        private void btnOpenInsert_Click(object sender, EventArgs e)
        {
            if (btnOpenInsert.Text.Equals(">>"))
            {
                btnOpenInsert.Text = "<<";
                this.Width = 945;
            }
            else
            {
                btnOpenInsert.Text = ">>";
                this.Width = 645;
            }
        }        

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b'))
                e.Handled = true;
        }

        private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int student_no = int.Parse(dgvList["STUDENT_NO", e.RowIndex].Value.ToString());

            frmStudentDetail frm = new frmStudentDetail(user, student_no);
            frm.ShowDialog();
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
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

        private void txtSchool_MouseClick(object sender, MouseEventArgs e)
        {
            frmSearchSchool pop = new frmSearchSchool();
            if (pop.ShowDialog() == DialogResult.OK)
                txtSchool.Text = pop.SchoolName;
        }

        private void txtSchool_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chkStop_CheckedChanged(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();

            if (chkStop.Checked)
                dgvList.DataSource = studentService.GetAllStudentInfo(true);
            else
                dgvList.DataSource = studentService.GetAllStudentInfo(false);

        }    
    }
}
