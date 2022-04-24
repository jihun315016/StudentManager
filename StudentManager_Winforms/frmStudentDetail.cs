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
        }
    }
}
