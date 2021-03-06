using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmEmployee : Form
    {
        EmployeeVO user;

        public frmEmployee()
        {
            InitializeComponent();
            
            ccTxtEmpName.SetTextBoxPlaceHolder();
            ccTxtSpecialNote.SetTextBoxPlaceHolder();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            user = (EmployeeVO)this.Tag;            

            txtOtherPosition.Visible = false;
            string[] positions = { "강사", "행정", "기타" };
            cboPosition.Items.AddRange(positions);

            ptbEmployee.Tag = null;

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "직원 번호", "EMP_NO", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이름", "EMP_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "직무", "POSITION", 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "권한", "AUTHORITY", 40, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이메일", "EMAIL", 160);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "입사 날짜", "START_DATE", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "퇴사 날짜", "END_DATE", isVisible: false, alignContent: DataGridViewContentAlignment.MiddleCenter);

            EmployeeService empService = new EmployeeService();
            dgvList.DataSource = empService.GetAllEmployeeInfo(false);

            this.Width = 635;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!user.Position.Equals("원장"))
            {
                MessageBox.Show("권한이 없습니다.");
                return;
            }

            EmployeeService empService = new EmployeeService();

            string position = string.Empty;
            if (cboPosition.SelectedItem is string)
                position = cboPosition.SelectedItem.ToString();

            if (cboPosition.SelectedIndex == cboPosition.Items.Count - 1)
                position = txtOtherPosition.Text;

            byte[] imageByteArr;

            // ptbEmployee.Tag는 이미지 경로가 저장되어 있을 것이고
            // 업로드를 하지 않았다면 Tag 값은 null
            if (ptbEmployee.Tag is string)
            {
                using (FileStream fs = new FileStream(ptbEmployee.Tag.ToString(), FileMode.Open, FileAccess.Read))
                {
                    BinaryReader br = new BinaryReader(fs);
                    imageByteArr = br.ReadBytes((int)fs.Length);
                }
            }
            else
            {
                imageByteArr = null;
            }            

            string[] textBoxValue = { txtName.Text, txtContact.Text, ucEmail.Email, position };
            string[] textBoxName = { "이름", "연락처", "이메일", "직무", "권한" };

            StringBuilder sb = TextBoxUtil.IsEmptyOrWhiteSpaceArr(textBoxValue, textBoxName);
            if (sb.Length > 0)
            {
                MessageBox.Show($"{sb.ToString()}를 입력해주세요.");
                return;
            }

            if (txtContact.Text.Length < 13)
            {
                MessageBox.Show("올바른 연락처를 입력해주세요.");
                return;
            }

            // 특이사항 검사
            string specialNote = string.Empty;
            if (!ccTxtSpecialNote.Text.Equals(ccTxtSpecialNote.PlaceHolder))
            {
                specialNote = ccTxtSpecialNote.Text;
            }

            EmployeeVO empVO = new EmployeeVO()
            {
                EmpName = txtName.Text,
                EmpContact = txtContact.Text,
                Position = position,
                StartDate = dtpStartDate.Value,
                Image = imageByteArr,
                Email = ucEmail.Email,
                SpecialNote = specialNote
            };

            bool result = empService.InsertEmployee(empVO);                

            if (result)
            {
                MessageBox.Show("직원이 등록되었습니다.");
                dgvList.DataSource = empService.GetAllEmployeeInfo(false);
            }
            else
            {
                MessageBox.Show("직원 등록이 실패했습니다.");
            }
            
            ptbEmployee.Tag = null;
            txtName.Text = txtContact.Text = txtOtherPosition.Text = String.Empty;
            cboPosition.SelectedItem = null;
            ptbEmployee.Image = Properties.Resources.image;
            ucEmail.ClearText();
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp";

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptbEmployee.Image = Image.FromFile(dlg.FileName);
                ptbEmployee.Tag = dlg.FileName;
            }
        }

        private void btnOpenInsert_Click(object sender, EventArgs e)
        {
            if (btnOpenInsert.Text.Equals(">>"))
            {
                btnOpenInsert.Text = "<<";
                this.Width = 935;
            }
            else
            {
                btnOpenInsert.Text = ">>";
                this.Width = 635;
            }
        }

        private void chkResignation_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeService empService = new EmployeeService();

            if (chkResignation.Checked)
            {
                dgvList.Columns["START_DATE"].Visible = false;
                dgvList.Columns["END_DATE"].Visible = true;
                dgvList.DataSource = empService.GetAllEmployeeInfo(true);
            }
            else
            {
                dgvList.Columns["START_DATE"].Visible = true;
                dgvList.Columns["END_DATE"].Visible = false;
                dgvList.DataSource = empService.GetAllEmployeeInfo(false);
            }

            ccTxtEmpName.Text = ccTxtEmpName.PlaceHolder;
            ccTxtEmpName.ForeColor = Color.Gray;
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (user.Position.Equals("원장") && e.Button == MouseButtons.Right)
            {
                dgvList.CurrentCell = dgvList[e.ColumnIndex, e.RowIndex];
                cmsSetting.Show(Cursor.Position);

                if (chkResignation.Checked)
                {
                    tsmReJoin.Visible = true;
                    tsmResignation.Visible = false;
                }
                else
                {
                    tsmReJoin.Visible = false;
                    tsmResignation.Visible = true;
                }
            }
        }

        private void tsmResignation_Click(object sender, EventArgs e)
        {
            int empNo = int.Parse(dgvList.CurrentRow.Cells["EMP_NO"].Value.ToString());
            string ResignationName = dgvList.CurrentRow.Cells["EMP_NAME"].Value.ToString();
            DialogResult msgBox = MessageBox.Show($"{ResignationName}님을 퇴사 처리하시겠습니까?", "퇴사 확인", MessageBoxButtons.YesNo);
            if (msgBox == DialogResult.Yes)
            {
                frmSetDate pop = new frmSetDate("퇴사 날짜", "퇴사");
                if (pop.ShowDialog() == DialogResult.OK)
                {

                    EmployeeService empService = new EmployeeService();
                    EmployeeVO empVO = new EmployeeVO()
                    {
                        EmpNo = empNo,
                        EndDate = pop.CommitDate
                    };

                    bool result = empService.UpdateEndDate(empVO, true);

                    if (result)
                    {
                        MessageBox.Show($"{ResignationName}님을 퇴사 처리하셨습니다.");

                        dgvList.DataSource = empService.GetAllEmployeeInfo(false);
                    }
                    else
                    {
                        MessageBox.Show("퇴사에 실패했습니다.");
                    }
                }
            }
        }

        private void tsmReJoin_Click(object sender, EventArgs e)
        {
            int empNo = int.Parse(dgvList.CurrentRow.Cells["EMP_NO"].Value.ToString());
            string RejoinName = dgvList.CurrentRow.Cells["EMP_NAME"].Value.ToString();
            DialogResult msgBox = MessageBox.Show($"{RejoinName}님을 다시 입사 처리하시겠습니까?", "재입사 확인", MessageBoxButtons.YesNo);
            if (msgBox == DialogResult.Yes)
            {
                frmSetDate pop = new frmSetDate("입사 날짜", "재입사");
                if (pop.ShowDialog() == DialogResult.OK)
                {

                    EmployeeService empService = new EmployeeService();
                    EmployeeVO empVO = new EmployeeVO()
                    {
                        EmpNo = empNo,
                        EndDate = pop.CommitDate
                    };

                    bool result = empService.UpdateEndDate(empVO, false);

                    if (result)
                    {
                        MessageBox.Show($"{RejoinName}님이 다시 입사하셨습니다.");
                        dgvList.DataSource = empService.GetAllEmployeeInfo(true);
                    }
                    else
                    {
                        MessageBox.Show("재입사를 실패했습니다.");                    
                    }
                }
            }
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            EmployeeService empService = new EmployeeService();
            dgvList.DataSource = empService.GetAllEmployeeInfo(chkResignation.Checked);

            if (!ccTxtEmpName.Text.Trim().Equals(ccTxtEmpName.PlaceHolder) && !ccTxtEmpName.Text.Trim().Equals(string.Empty))            
                dgvList.DataSource = empService.SearchByEmpName((DataTable)dgvList.DataSource, ccTxtEmpName.Text.Trim());
            else
                dgvList.DataSource = empService.GetAllEmployeeInfo(chkResignation.Checked);


            dgvList.DataSource = empService.SearchDateInList(ucDateFilter.StartDate, ucDateFilter.EndDate, (DataTable)dgvList.DataSource, chkResignation.Checked);
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int emp_no = int.Parse(dgvList["EMP_NO", e.RowIndex].Value.ToString());
            if (user.Position.Equals("원장") || user.EmpNo == emp_no)
            {
                frmEmployDetail pop = new frmEmployDetail(user, emp_no);
                pop.ShowDialog();

                EmployeeService empService = new EmployeeService();

                dgvList.Columns["START_DATE"].Visible = !chkResignation.Checked;
                dgvList.Columns["END_DATE"].Visible = chkResignation.Checked;
                dgvList.DataSource = empService.GetAllEmployeeInfo(chkResignation.Checked);
            }
            else
            {
                MessageBox.Show("권한이 없습니다.");
            }
        }
    }
}
