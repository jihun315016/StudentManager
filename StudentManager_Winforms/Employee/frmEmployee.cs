﻿using StudentManager.Service.Service;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();

            ccTxtEmpNo.SetTextBoxPlaceHolder();
            ccTxtSpecialNote.SetTextBoxPlaceHolder();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            txtOtherPosition.Visible = false;
            string[] positions = { "강사", "행정", "기타" };
            cboPosition.Items.AddRange(positions);

            string[] authoritys = { "1", "2", "3" };
            cboAuthority.Items.AddRange(authoritys);

            ptbEmployee.Tag = null;

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "직원 번호", "EMP_NO");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이름", "EMP_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "직무", "POSITION", 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "권한", "AUTHORITY", 60);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이메일", "EMAIL", 160);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "퇴사 날짜", "END_DATE", isVisible: false);

            EmployeeService empService = new EmployeeService();
            dgvList.DataSource = empService.GetAllEmployeeInfo();

            this.Width = 545;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeService empService = new EmployeeService();

            string position = empService.NullCheck(cboPosition.SelectedItem);
            if (cboPosition.SelectedIndex == cboPosition.Items.Count - 1)
                position = txtOtherPosition.Text;

            string authority = empService.NullCheck(cboAuthority.SelectedItem);
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

            string[] textBoxValue = { txtName.Text, txtContact.Text, ucEmail.Email, position, authority };
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

            bool result = empService.InsertEmployee
                (
                    txtName.Text, txtContact.Text, position, int.Parse(authority),
                    dtpStartDate.Value, imageByteArr, ucEmail.Email, ccTxtSpecialNote.Text
                );

            if (result)
                MessageBox.Show("직원이 등록되었습니다.");
            else
                MessageBox.Show("직원 등록이 실패했습니다.");
            
            ptbEmployee.Tag = null;
            txtName.Text = txtContact.Text = txtOtherPosition.Text = String.Empty;
            cboAuthority.SelectedItem = null;
            cboPosition.SelectedItem = null;
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
                this.Width = 865;
            }
            else
            {
                btnOpenInsert.Text = ">>";
                this.Width = 545;
            }
        }

        private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {           
            int emp_no = int.Parse(dgvList["EMP_NO", e.RowIndex].Value.ToString());

            frmEmployDetail frm = new frmEmployDetail(emp_no);
            frm.ShowDialog();
        }
    }
}
