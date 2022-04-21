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

            // 수정할 것 : 보호자 연락처 13글자 입력은 체크했으니까 관계만 체크하도록 수정할 것
            sb = student.ValidGuardian(txtGuardianContact.Text, guardianRerationship);
            if (sb.Length > 1)
            {
                MessageBox.Show(sb.ToString());
                return;
            }


            MessageBox.Show($"{guardianRerationship} {ccTxtSpecialNote.Text}");



            /* 학생 등록 테스트 */
            //string sql = @"INSERT INTO tb_student 
            //                (STUDENT_NAME, STUDENT_CONTACT, GUARDIAN_CONTACT, GUARDIAN_RERATIONSHIP, SCHOOL, AGE, START_DATE, SPECIAL_NOTE)
            //                VALUES
            //                (@STUDENT_NAME, @STUDENT_CONTACT, @GUARDIAN_CONTACT, @GUARDIAN_RERATIONSHIP, @SCHOOL, @AGE, @START_DATE, @SPECIAL_NOTE)";

            //string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            //MySqlConnection conn = new MySqlConnection(connStr);

            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@STUDENT_NAME", txtName.Text);
            //cmd.Parameters.AddWithValue("@STUDENT_CONTACT", txtStudentContact.Text);
            //cmd.Parameters.AddWithValue("@GUARDIAN_CONTACT", txtGuardianContact.Text);
            ////cmd.Parameters.AddWithValue("@GUARDIAN_RERATIONSHIP", guard.Text);
            //cmd.Parameters.AddWithValue("@SCHOOL", txtName.Text);
            //cmd.Parameters.AddWithValue("@AGE", txtName.Text);
            //cmd.Parameters.AddWithValue("@START_DATE", txtName.Text);
            //cmd.Parameters.AddWithValue("@SPECIAL_NOTE", txtName.Text);
            //conn.Open();

            //conn.Close();
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
