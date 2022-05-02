using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Text;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmStudentDetail : Form
    {
        EmployeeVO user;

        public frmStudentDetail(EmployeeVO user, int studentNo)
        {
            InitializeComponent();

            this.user = user;

            txtStudentNo.Text = studentNo.ToString();
        }

        private void frmStudentDetail_Load(object sender, EventArgs e)
        {
            int studentNo = int.Parse(txtStudentNo.Text);
            StudentService stuService = new StudentService();
            StudentVO studentVO = stuService.GetStudentInfoByPk(studentNo);

            // 초기 데이터 입력
            lblStudentInfo.Text = $"[{studentVO.StudentNo}] {studentVO.StudentName}";
            txtStudentNo.Text = studentVO.StudentNo.ToString();
            txtName.Text = studentVO.StudentName.ToString();
            txtStudentContact.Text = studentVO.StudentContact.ToString();
            txtGuardianContact.Text = studentVO.GuardianContact.ToString();
            lblGuardianRerationship.Text = studentVO.GuardianRalationship.ToString();
            txtAge.Text = studentVO.Age.ToString();
            txtSchool.Text = studentVO.School.ToString();
            dtpDate.Value = studentVO.StartDate;
            ccTxtSpecialNote.Text = studentVO.SpecialNote.ToString();

            txtStudentNo.Enabled = txtName.Enabled = txtStudentContact.Enabled = txtGuardianContact.Enabled =
                txtAge.Enabled = txtSchool.Enabled = dtpDate.Enabled = ccTxtSpecialNote.Enabled = false;
            pnlEndReason.Visible = pnlGuardianRerationship.Visible = false;

            // 등록 중인 학생과 그만둔 학생 구분
            if (studentVO.EndDate.Year > 1)
            {
                lblDate.Text = "그만둔 날짜";
                pnlEndReason.Visible = true;
                txtEndReason.Text = stuService.GetEndReason(studentVO.EndReasonNo);
                txtEndReason.Enabled = false;
                dtpDate.Value = studentVO.EndDate;
                btnEditInfo.Tag = false;
            }
            else
            {
                lblDate.Text = "등록 날짜";
                dtpDate.Value = studentVO.StartDate;
                btnEditInfo.Tag = true;
            }
        }

        private void btnEditInfo_Click(object sender, System.EventArgs e)
        {
            if (!(bool)btnEditInfo.Tag)
            {
                MessageBox.Show("그만둔 학생은 수정할 수 없습니다.");
                return;
            }

            if (btnEditInfo.Text.Equals("저장")) 
            {
                if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
                {
                    MessageBox.Show("학생 이름을 입력해주세요.");
                    return;
                }

                // 보호자 관계 radio button 처리
                string guardianRerationship = null;
                if (rdoOther.Checked)
                    guardianRerationship = txtOtherRalationship.Text.Trim();
                else if (rdoFather.Checked)
                    guardianRerationship = rdoFather.Text.Trim();
                else if (rdoMother.Checked)
                    guardianRerationship = rdoMother.Text.Trim();

                // 학생 연락처, 보호자 연락처, 보호자 관계 유효성 검사
                StudentService studentService = new StudentService();
                StringBuilder sb = studentService.ValidContactAndGuardian(txtStudentContact.Text, txtGuardianContact.Text, guardianRerationship);
                if (sb.Length > 0)
                {
                    MessageBox.Show(sb.ToString());
                    return;
                }

                // 특이사항 처리
                string specialNote = string.Empty;
                if (!ccTxtSpecialNote.Text.Equals(ccTxtSpecialNote.PlaceHolder))
                {
                    specialNote = ccTxtSpecialNote.Text;
                }

                bool result = studentService.UpdateStudentInfo
                    (
                        int.Parse(txtStudentNo.Text), txtName.Text, txtStudentContact.Text, txtGuardianContact.Text, guardianRerationship,
                        txtSchool.Text, int.Parse(txtAge.Text), Convert.ToDateTime(dtpDate.Value), ccTxtSpecialNote.Text
                    );

                if (result)
                {
                    MessageBox.Show("학생 정보가 수정되었습니다.");
                    lblGuardianRerationship.Text = guardianRerationship;
                }
                else
                {
                    MessageBox.Show("정보 수정에 실패했습니다.");
                    return;
                }

                txtName.Enabled = txtStudentContact.Enabled = txtGuardianContact.Enabled =
                    txtAge.Enabled = txtSchool.Enabled = dtpDate.Enabled = ccTxtSpecialNote.Enabled = false;
                pnlGuardianRerationship.Visible = false;
                lblGuardianRerationship.Visible = true;
                btnEditInfo.Text = "수정";
            }
            else // 수정 버튼 상태
            {
                if (!string.IsNullOrWhiteSpace(lblGuardianRerationship.Text))
                {
                    rdoOther.Checked = true;
                    txtOtherRalationship.Text = lblGuardianRerationship.Text;

                    foreach (Control control in pnlGuardianRerationship.Controls)
                    {
                        if (control is RadioButton rdo && lblGuardianRerationship.Text == rdo.Text)
                        {
                            rdo.Checked = true;                            
                            txtOtherRalationship.Text = string.Empty;
                            break;
                        }
                    }
                }

                txtName.Enabled = txtStudentContact.Enabled = txtGuardianContact.Enabled =
                txtAge.Enabled = txtSchool.Enabled = dtpDate.Enabled = ccTxtSpecialNote.Enabled = true;
                pnlGuardianRerationship.Visible = true;
                lblGuardianRerationship.Visible = false;
                btnEditInfo.Text = "저장";
            }
        }       

        private void txtSchool_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSchool_MouseClick(object sender, MouseEventArgs e)
        {
            frmSearchSchool pop = new frmSearchSchool();
            if (pop.ShowDialog() == DialogResult.OK)
                txtSchool.Text = pop.SchoolName;
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOther.Checked)
            {
                txtOtherRalationship.Visible = true;
                txtOtherRalationship.Text = string.Empty;
            }
            else if (rdoNone.Checked)
            {
                txtGuardianContact.Text = String.Empty;
            }
            else
            {
                txtOtherRalationship.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
