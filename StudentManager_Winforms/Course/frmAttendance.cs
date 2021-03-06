using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmCourse))
                {
                    this.Location = new Point(form.Location.X, form.Location.Y + form.Height);
                    break;
                }
            }

            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 번호", "STUDENT_NO", 90, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 이름", "STUDENT_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수업","COURSE_NAME", 140);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "담당 강사", "EMP_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "날짜", "ATTENDANCE_DATE", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "출석 유무", "IS_ATTENDANCE", 90, alignContent:DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수업 번호", "COURSE_NO", isVisible: false);

            btnInit_Click(this, null);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            ccTxtCourseName.Text = string.Empty;
            ccTxtStudentName.Text = string.Empty;

            ccTxtStudentName.SetTextBoxPlaceHolder();
            ccTxtCourseName.SetTextBoxPlaceHolder();

            AttendanceService attService = new AttendanceService();
            DateTime start = Convert.ToDateTime(ucDateFilter.StartDate.ToString("yyyy-MM-dd"));
            DateTime end = Convert.ToDateTime(ucDateFilter.EndDate.ToString("yyyy-MM-dd"));
            dgvList.DataSource = attService.GetAllAttendanceList(start, end);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AttendanceService attService = new AttendanceService();
            DateTime start = Convert.ToDateTime(ucDateFilter.StartDate.ToString("yyyy-MM-dd"));
            DateTime end = Convert.ToDateTime(ucDateFilter.EndDate.ToString("yyyy-MM-dd"));
            DataTable tempDt = attService.GetAllAttendanceList(start, end);

            if (!ccTxtCourseName.Text.Trim().Equals(ccTxtCourseName.PlaceHolder) && !ccTxtCourseName.Text.Trim().Equals(string.Empty))
            {
                CourseService courseService = new CourseService();
                tempDt = courseService.SearchByCourseName(tempDt, ccTxtCourseName.Text.Trim());
            }

            if (!ccTxtStudentName.Text.Trim().Equals(ccTxtStudentName.PlaceHolder) && !ccTxtStudentName.Text.Trim().Equals(string.Empty))
            {
                StudentService stuService = new StudentService();
                tempDt = stuService.SearchByStudentName(tempDt, ccTxtStudentName.Text.Trim());
            }

            dgvList.DataSource = tempDt;
        }

        public void LoadDgvList()
        {
            btnInit_Click(this, null);
        }
    }
}
