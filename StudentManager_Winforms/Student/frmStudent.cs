using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
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
            ccTxtStudentName.SetTextBoxPlaceHolder();
            ccTxtSpecialNote.SetTextBoxPlaceHolder();

            // DataGridView 초기 설정
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 번호", "STUDENT_NO", 80, alignContent:DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이름", "STUDENT_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "나이", "AGE", 60, alignContent:DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 연락처", "STUDENT_CONTACT", 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "보호자 연락처", "GUARDIAN_CONTACT", 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "보호자 관계", "GUARDIAN_RERATIONSHIP");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "등록 날짜", "START_DATE", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "퇴원 날짜", "END_DATE", isVisible: false, alignContent: DataGridViewContentAlignment.MiddleCenter);

            StudentService student = new StudentService();
            dgvList.DataSource = student.GetAllStudentInfo(false);

            // 초기 화면 크기
            this.Width = 755;
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
            

            string specialNote = null;
            if (!ccTxtSpecialNote.Text.Equals(ccTxtSpecialNote.PlaceHolder))
            {
                specialNote = ccTxtSpecialNote.Text;
            }

            string[] data =
            {
                txtName.Text, txtStudentContact.Text, txtGuardianContact.Text, guardianRerationship,
                txtSchool.Text, txtAge.Text, dtpStartDate.Value.ToString(), ccTxtSpecialNote.Text
            };

            StudentVO stuVO = new StudentVO()
            {
                StudentName = txtName.Text,
                StudentContact = txtStudentContact.Text,
                GuardianContact = txtGuardianContact.Text,
                GuardianRalationship = guardianRerationship,
                School = txtSchool.Text,
                Age = int.Parse(txtAge.Text),
                StartDate = dtpStartDate.Value,
                SpecialNote = specialNote
            };

            bool result = studentService.InsertStudent(stuVO);

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
                this.Width = 1035;
            }
            else
            {
                btnOpenInsert.Text = ">>";
                this.Width = 755;
            }
        }        

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
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
            {
                dgvList.Columns["START_DATE"].Visible = false;
                dgvList.Columns["END_DATE"].Visible = true;
                dgvList.DataSource = studentService.GetAllStudentInfo(true);
            }
            else
            {
                dgvList.Columns["START_DATE"].Visible = true;
                dgvList.Columns["END_DATE"].Visible = false;
                dgvList.DataSource = studentService.GetAllStudentInfo(false);
            }

            ccTxtStudentName.Text = ccTxtStudentName.PlaceHolder;
            ccTxtStudentName.ForeColor = Color.Gray;
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (user.Position.Equals("원장") && e.Button == MouseButtons.Right)
            {
                dgvList.CurrentCell = dgvList[e.ColumnIndex, e.RowIndex];
                cmsSetting.Show(Cursor.Position);

                if (chkStop.Checked)
                {
                    tsmReJoin.Visible = true;
                    tsmStop.Visible = false;
                }
                else
                {
                    tsmReJoin.Visible = false;
                    tsmStop.Visible = true;
                }
            }
        }

        private void tsmStop_Click(object sender, EventArgs e)
        {
            int stuNo = int.Parse(dgvList.CurrentRow.Cells["STUDENT_NO"].Value.ToString());
            string stuName = dgvList.CurrentRow.Cells["STUDENT_NAME"].Value.ToString();
            DialogResult msgBox = MessageBox.Show($"{stuName} 학생을 퇴원 처리하시겠습니까?", "퇴원 확인", MessageBoxButtons.YesNo);
            if (msgBox == DialogResult.Yes)
            {
                frmSetDate pop = new frmSetDate("퇴원 날짜", true);

                if (pop.ShowDialog() == DialogResult.OK)
                {

                    StudentService stuService = new StudentService();
                    StudentVO student = new StudentVO()
                    {
                        StudentNo = stuNo,
                        EndDate = pop.CommitDate,
                        EndReasonNo = pop.EndReasonNo
                    };

                    bool result = stuService.UpdateEndDate(student, true);

                    if (result)
                    {
                        MessageBox.Show($"{stuName}님을 퇴원 처리하셨습니다.");
                        dgvList.DataSource = stuService.GetAllStudentInfo(false);
                    }
                    else
                    {
                        MessageBox.Show("퇴원에 실패했습니다.");
                    }
                }
            }
        }

        private void tsmReJoin_Click(object sender, EventArgs e)
        {
            int stuNo = int.Parse(dgvList.CurrentRow.Cells["STUDENT_NO"].Value.ToString());
            string stuName = dgvList.CurrentRow.Cells["STUDENT_NAME"].Value.ToString();
            DialogResult msgBox = MessageBox.Show($"{stuName}님을 재등록 처리하시겠습니까?", "재등록 확인", MessageBoxButtons.YesNo);
            if (msgBox == DialogResult.Yes)
            {
                frmSetDate pop = new frmSetDate("등록 날짜");
                if (pop.ShowDialog() == DialogResult.OK)
                {

                    StudentService stuService = new StudentService();
                    StudentVO student = new StudentVO()
                    {
                        StudentNo = stuNo,
                        EndDate = pop.CommitDate,
                        EndReasonNo = pop.EndReasonNo
                    };
                    bool result = stuService.UpdateEndDate(student, false);

                    if (result)
                    {
                        MessageBox.Show($"{stuName}님을 재등록 하셨습니다.");
                        dgvList.DataSource = stuService.GetAllStudentInfo(true);
                    }
                    else
                    {
                        MessageBox.Show("재등록에 실패했습니다.");
                    }
                }
            }
        }

        private void btnSearchStu_Click(object sender, EventArgs e)
        {
            StudentService stuService = new StudentService();
            dgvList.DataSource = stuService.GetAllStudentInfo(chkStop.Checked);

            if (!ccTxtStudentName.Text.Trim().Equals(ccTxtStudentName.PlaceHolder) & !ccTxtStudentName.Text.Trim().Equals(string.Empty))            
                dgvList.DataSource = stuService.SearchByStudentName((DataTable)dgvList.DataSource, ccTxtStudentName.Text.Trim());
            else
                dgvList.DataSource = stuService.GetAllStudentInfo(chkStop.Checked);


            dgvList.DataSource = stuService.SearchByDate(ucDateFilter.StartDate, ucDateFilter.EndDate, (DataTable)dgvList.DataSource, chkStop.Checked);
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int student_no = int.Parse(dgvList["STUDENT_NO", e.RowIndex].Value.ToString());

            frmStudentDetail pop = new frmStudentDetail(user, student_no);
            pop.ShowDialog();

            StudentService stuService = new StudentService();
            dgvList.Columns["START_DATE"].Visible = !chkStop.Checked;
            dgvList.Columns["END_DATE"].Visible = chkStop.Checked;
            dgvList.DataSource = stuService.GetAllStudentInfo(chkStop.Checked);
        }
    }
}
