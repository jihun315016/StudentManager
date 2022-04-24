using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmEmployDetail : Form
    {
        public frmEmployDetail(int emp_no)
        {
            InitializeComponent();            

            EmployeeService empService = new EmployeeService();          

            // 콤보 박스 초기화
            List<string> list = empService.GetPosition();
            cboPosition.Items.AddRange(new string[] { "원장", "강사", "행정" });

            foreach (string item in list)
            {
                if (!item.Equals("기타") && !item.Equals("원장") &&!item.Equals("강사") && !item.Equals("행정"))
                    cboPosition.Items.Add(item);
            }    
            cboPosition.Items.Add("기타");

            string[] authoritys = { "1", "2", "3" };
            cboAuthority.Items.AddRange(authoritys);

            // 초기 데이터 설정
            txtEmpNo.Text = emp_no.ToString();
            txtEmpNo.ReadOnly = true;

            EmployeeVO employeeVO = empService.GetEmpInfoByPk(emp_no);

            lblEmployeeInfo.Text = $"[{employeeVO.Position}] {employeeVO.Emp_Name}";
            txtName.Text = employeeVO.Emp_Name;
            txtContact.Text = employeeVO.Emp_Contact;
            ccTxtEmail.FrontEmail = employeeVO.Email.Split('@')[0];
            ccTxtEmail.RearEmail = employeeVO.Email.Split('@')[1];
            cboPosition.Text = employeeVO.Position;
            cboAuthority.Text = employeeVO.Authority.ToString();            
            ccTxtSpecialNote.Text = employeeVO.SpecialNote;
            ccTxtSpecialNote.SetTextBoxPlaceHolder();

            // 이미지가 있다면 불러오기
            if(employeeVO.Image != null)
            {
                ptbEmployee.Tag = null;
                MemoryStream mStream = new MemoryStream(employeeVO.Image);
                ptbEmployee.Image = Image.FromStream(mStream);
            }

            // 근무중인 직원과 퇴사한 직원 구분
            if (employeeVO.EndDate.Year > 1)
            {
                lblDate.Text = "퇴사 날짜";
                dtpDate.Value = employeeVO.EndDate;
                btnEditInfo.Tag = false;
            }
            else
            {
                lblDate.Text = "고용 날짜";
                dtpDate.Value = employeeVO.StartDate;
                btnEditInfo.Tag = true;
            }

            TextBoxUtil.SetReadOnly(new TextBox[] { txtName, ccTxtSpecialNote }, true);
            ccTxtEmail.ReadOnly(true);
            txtContact.ReadOnly = true;
            dtpDate.Enabled = cboPosition.Enabled = cboAuthority.Enabled = false;
            txtPosition.Visible = btnUpload.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!(bool)btnEditInfo.Tag)
            {
                MessageBox.Show("퇴사한 직원은 수정할 수 없습니다.");
                return;
            }

            if(btnEditInfo.Text == "저장")
            {
                string[] textBoxValue = { txtName.Text, txtContact.Text, ccTxtEmail.Email, cboAuthority.Text};
                string[] textBoxName = { "이름", "연락처", "이메일", "권한"};
                
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

                string position;

                if (cboPosition.SelectedIndex != cboPosition.Items.Count - 1)
                {
                    position = cboPosition.SelectedItem.ToString();
                }
                else if (!string.IsNullOrWhiteSpace(txtPosition.Text.Trim()))
                {
                    position = txtPosition.Text.Trim();
                }
                else
                {
                    MessageBox.Show("직무를 입력해주세요.");
                    return;
                }
                


                // 수정 정보 업데이트
                EmployeeService empService = new EmployeeService();
                bool result = empService.UpdateEmployee
                    (
                        int.Parse(txtEmpNo.Text), txtName.Text, txtContact.Text, ccTxtEmail.Email, position,
                        int.Parse(cboAuthority.Text), dtpDate.Value, ccTxtSpecialNote.Text, (string)ptbEmployee.Tag
                    );

                if (result)
                {
                    MessageBox.Show("직원 정보가 수정되었습니다.");
                }
                else
                {
                    MessageBox.Show("정보 수정에 실패했습니다.");
                    return;
                }

                TextBoxUtil.SetReadOnly(new TextBox[] { txtName, ccTxtSpecialNote }, true);
                ccTxtEmail.ReadOnly(true);
                txtContact.ReadOnly = true;
                dtpDate.Enabled = cboPosition.Enabled = cboAuthority.Enabled = false;
                txtPosition.Visible = btnUpload.Visible = false;
                btnEditInfo.Text = "수정";
            }
            else
            {
                TextBoxUtil.SetReadOnly(new TextBox[] { txtName, ccTxtSpecialNote }, false);
                ccTxtEmail.ReadOnly(false);
                txtContact.ReadOnly = false;
                dtpDate.Enabled = cboPosition.Enabled = cboAuthority.Enabled = true;
                btnUpload.Visible = true;
                btnEditInfo.Text = "저장";
            }
        }

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPosition.SelectedIndex == cboPosition.Items.Count - 1)
            {
                txtPosition.Text = string.Empty;
                txtPosition.Visible = true;
            }
            else
            {
                txtPosition.Visible = false;
                txtPosition.Text = cboPosition.Text;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
