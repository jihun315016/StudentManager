using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmCourseDetail : Form
    {
        EmployeeCourseVO courseEmpVO;
        public frmCourseDetail(int courseNo)
        {
            InitializeComponent();

            CourseService courseService = new CourseService();
            courseEmpVO = courseService.GetCourseInfoByPk(courseNo);
        }

        private void frmCourseDetail_Load(object sender, EventArgs e)
        {
            tsmCancelCourse.Visible = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmCourse))
                {
                    this.Location = new Point(form.Location.X + form.Width, form.Location.Y);
                    break;
                }
            }

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 번호", "STUDENT_NO", 90, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이름", "STUDENT_NAME", 60);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "나이", "AGE", 40, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학교", "SCHOOL", 110);

            lblCourseInfo.Text = $"[{courseEmpVO.EmpName}] {courseEmpVO.CourseName}";
            lblCourseNo.Text = courseEmpVO.CourseNo.ToString();
            lblPayment.Text = courseEmpVO.Payment.ToString("###,#");

            string start = courseEmpVO.CourseStartDate.ToString("d");
            string end = courseEmpVO.CourseEndDate.ToString("d");
            lblDate.Text = $"{start} ~ {end}";

            StudentService stuService = new StudentService();
            dgvList.DataSource = stuService.GetStudentListByCourse(int.Parse(lblCourseNo.Text));
        }

        private void txtStudentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b'))
                e.Handled = true;
        }

        private void btnApplyCourse_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Today, courseEmpVO.CourseEndDate) > 0)
            {
                MessageBox.Show("신청 가능한 수업이 아닙니다.");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtStudentNo.Text.Trim()))
                {
                    MessageBox.Show("학생 번호를 입력해주세요.");
                    return;
                }
                int studentNo = int.Parse(txtStudentNo.Text);
                int courseNo = int.Parse(lblCourseNo.Text);

                StudentService stuService = new StudentService();
                StudentVO stuVO = stuService.GetStudentInfoByStuNo(studentNo);

                if (stuVO == null)
                {
                    lblStudentName.Text = "잘못된 학생 번호입니다.";
                    lblStudentName.ForeColor = Color.Red;
                    return;
                }

                DialogResult msgResult = MessageBox.Show($"{stuVO.StudentName} 학생을 등록하시겠습니까?", "수강 신청", MessageBoxButtons.YesNo);
                if (msgResult == DialogResult.Yes)
                {
                    CourseService courseService = new CourseService();
                    int distinctCheck = courseService.GetCountStudentInCourse(studentNo, courseNo);
                    if (distinctCheck > 0)
                    {
                        MessageBox.Show("이미 등록된 학생입니다.");
                        return;
                    }

                    bool insertResult = courseService.InsertStudentInCourse(studentNo, courseNo);
                    if (insertResult)
                        MessageBox.Show("학생이 등록되었습니다.");
                    else
                        MessageBox.Show("수강 신청에 실패했습니다.");

                    txtStudentNo.Text = String.Empty;
                    dgvList.DataSource = stuService.GetStudentListByCourse(courseNo);
                }
            }
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvList.CurrentCell = dgvList[e.ColumnIndex, e.RowIndex];
                cmsSetting.Show(Cursor.Position);
                tsmCancelCourse.Visible = true;
            }
        }

        private void tsmCancelCourse_Click(object sender, EventArgs e)
        {
            int stuNo = int.Parse(dgvList.CurrentRow.Cells["STUDENT_NO"].Value.ToString());
            int courseNo = int.Parse(lblCourseNo.Text);

            DialogResult deleteChk = MessageBox.Show("수강 취소하시겠습니까?", "수강 취소", MessageBoxButtons.YesNo);
            if (deleteChk == DialogResult.Yes)
            {
                CourseService courseService = new CourseService();
                bool deleteResult = courseService.DeleteStudent(stuNo, courseNo);
                
                if (deleteResult)
                {
                    MessageBox.Show("취소되었습니다.");
                    StudentService stuService = new StudentService();
                    dgvList.DataSource = stuService.GetStudentListByCourse(int.Parse(lblCourseNo.Text));
                }
                else
                {
                    MessageBox.Show("삭제에 실패했습니다.");
                }
            }
        }
    }
}
