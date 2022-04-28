using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmCourse : Form
    {
        EmployeeVO user;

        public frmCourse()
        {
            InitializeComponent();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            user = this.Tag as EmployeeVO;
            ccTxtCourseNo.SetTextBoxPlaceHolder();

            CourseService courseService = new CourseService();
            DataGridViewUtil.SetInitGridView(dgvList);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수업 번호", "COURSE_NO", 80, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "직원 번호", "EMP_NO", 80, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수업", "COURSE_NAME");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "개강 날짜", "START_DATE");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "종갈 날짜", "END_DATE");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "회비", "PAYMENT", isVisible: false);
            dgvList.DataSource = courseService.GetAllCourseInfo(false);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (user.Authority > 1)
            {
                MessageBox.Show("권한이 없습니다.");
                return;
            }

            frmCourseInsert pop = new frmCourseInsert();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                CourseService courseService = new CourseService();
                chkFinalCourse.Checked = false;
                dgvList.DataSource = courseService.GetAllCourseInfo(false);
            }
        }

        private void chkFinalCourse_CheckedChanged(object sender, EventArgs e)
        {
            CourseService courseService = new CourseService();
            if (chkFinalCourse.Checked)
                dgvList.DataSource = courseService.GetAllCourseInfo(true);
            else
                dgvList.DataSource = courseService.GetAllCourseInfo(false);

        }

        private void ccTxtBoxPlaceHolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ccTxtCourseNo.Text) || ccTxtCourseNo.Text == ccTxtCourseNo.PlaceHolder)
            {
                MessageBox.Show("수업 번호를 입력해주세요.");
                return;
            }

            CourseService courseService = new CourseService();
            int index = courseService.SearchCourseInList(int.Parse(ccTxtCourseNo.Text), (DataTable)dgvList.DataSource, "COURSE_NO");
            if (index > -1)
            {
                dgvList.Sort(dgvList.Columns["COURSE_NO"], ListSortDirection.Ascending);
                dgvList.CurrentCell = dgvList.Rows[index].Cells["COURSE_NO"];
            }
            else
            {
                MessageBox.Show($"{ccTxtCourseNo.Text} - 수업 번호가 없습니다.");
            }
        }

        private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int courseNo = int.Parse(dgvList["COURSE_NO", e.RowIndex].Value.ToString());

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmCourseDetail))
                {
                    form.Close();
                    break;
                }
            }

            frmCourseDetail frm = new frmCourseDetail(courseNo);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
