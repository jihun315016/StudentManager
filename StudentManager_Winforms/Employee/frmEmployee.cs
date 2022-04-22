using MySql.Data.MySqlClient;
using StudentManager.Service.Service;
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
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeService employee = new EmployeeService();

            string position = employee.NullCheck(cboPosition.SelectedItem);
            string authority = employee.NullCheck(cboAuthority.SelectedItem);
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

            string[] txtTexts = { txtName.Text, txtContact.Text, ucEmail.email, position, authority };
            string[] txtNames = { "이름", "연락처", "이메일", "직무", "권한" };

            StringBuilder sb = TextBoxUtil.IsEmptyOrWhiteSpaceArr(txtTexts, txtNames);
            if (sb.Length > 0)
            {
                MessageBox.Show($"{sb.ToString()}를 입력해주세요.");
                return;
            }

            if (txtContact.Text.Length < 13)
                MessageBox.Show("올바른 연락처를 입력해주세요.");

            /* INSERT 테스트 */
            string connStr = "Server=whyfi8888.ddns.net;Port=13307;Uid=gudi01;Pwd=gudi01$$;Database=gudi01";
            string sql = @"INSERT INTO tb_employee
                            (EMP_NAME, EMP_CONTACT, POSITION, AUTHORITY, START_DATE, IMAGE, EMAIL, SPECIAL_NOTE)
                            VALUES
                            (@EMP_NAME, @EMP_CONTACT, @POSITION, @AUTHORITY, @START_DATE, @IMAGE, @EMAIL, @SPECIAL_NOTE)";

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@EMP_NAME", txtName.Text);
            cmd.Parameters.AddWithValue("@EMP_CONTACT", txtContact.Text);
            cmd.Parameters.AddWithValue("@POSITION", position);
            cmd.Parameters.AddWithValue("@AUTHORITY", authority);
            cmd.Parameters.AddWithValue("@START_DATE", dtpStartDate.Value);
            cmd.Parameters.AddWithValue("@IMAGE", imageByteArr);
            cmd.Parameters.AddWithValue("@EMAIL", ucEmail.email);
            cmd.Parameters.AddWithValue("@SPECIAL_NOTE", ccTxtSpecialNote.Text);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("오오옹");

            /* --------------------------------------------------*/

            ptbEmployee.Tag = null;
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
    }
}
