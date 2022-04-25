using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmStudentDetail : Form
    {
        public frmStudentDetail(int studentNo)
        {
            InitializeComponent();

            StudentService stuService = new StudentService();
            StudentVO studentVO = stuService.GetStudentInfoByPk(studentNo);

            txtName.Text = studentVO.Student_Name.ToString();
            txtStudentContact.Text = studentVO.Student_Contact.ToString();
            txtGuardianContact.Text = studentVO.Guardian_Contact.ToString();
            lblGuardianRerationship.Text = studentVO.Guardian_ralationship.ToString();
            txtAge.Text = studentVO.Age.ToString();
            txtSchool.Text = studentVO.School.ToString();
            dtpDate.Value = studentVO.StartDate;

            txtStudentNo.Enabled = txtName.Enabled = txtStudentContact.Enabled = txtGuardianContact.Enabled =
                txtAge.Enabled = txtSchool.Enabled = dtpDate.Enabled = false;
            pnlGuardianRerationship.Visible = false;
        }

        private void btnEditInfo_Click(object sender, System.EventArgs e)
        {
            if (btnEditInfo.Text == "저장") 
            {
                txtStudentNo.Enabled = txtName.Enabled = txtStudentContact.Enabled = txtGuardianContact.Enabled =
                    txtAge.Enabled = txtSchool.Enabled = dtpDate.Enabled = false;
                pnlGuardianRerationship.Visible = false;

                btnEditInfo.Text = "수정";
            }
            else
            {
                // 보호자 관계가 null인지 확인하기

                txtStudentNo.Enabled = txtName.Enabled = txtStudentContact.Enabled = txtGuardianContact.Enabled =
                    txtAge.Enabled = txtSchool.Enabled = dtpDate.Enabled = true;
                pnlGuardianRerationship.Visible = true;
                btnEditInfo.Text = "저장";
            }
        }
    }
}
