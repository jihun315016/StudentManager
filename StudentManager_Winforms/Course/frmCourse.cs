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
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "수업", "COURSE_NAME", 120);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "개강 날짜", "START_DATE", 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "종갈 날짜", "END_DATE", 90);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "회비", "PAYMENT", isVisible: false);
            dgvList.DataSource = courseService.GetAllCourseInfo(false);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!user.Position.Equals("원장"))
            {
                MessageBox.Show("권한이 없습니다.");
                return;
            }

            frmCourseInsert pop = new frmCourseInsert();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                CourseService courseService = new CourseService();
                chkNotCouse.Checked = false;
                dgvList.DataSource = courseService.GetAllCourseInfo(false);
            }
        }

        private void chkFinalCourse_CheckedChanged(object sender, EventArgs e)
        {
            CourseService courseService = new CourseService();
            if (chkNotCouse.Checked)
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

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (user.Position.Equals("원장") && e.Button == MouseButtons.Right && !chkNotCouse.Checked)
            {
                dgvList.CurrentCell = dgvList[e.ColumnIndex, e.RowIndex];
                cmsSetting.Show(Cursor.Position);

                tsmDelete.Visible = true;                
            }
        }
        
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int courseNo = int.Parse(dgvList.CurrentRow.Cells["COURSE_NO"].Value.ToString());

            DialogResult deleteChk = MessageBox.Show("삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
            if (deleteChk == DialogResult.Yes)
            {
                CourseService courseService = new CourseService();
                bool deleteResult = courseService.DeleteCourse(courseNo);
                if (deleteResult)
                {
                    MessageBox.Show("수업이 삭제되었습니다.");
                    dgvList.DataSource = courseService.GetAllCourseInfo(false);
                }
                else
                {
                    MessageBox.Show("삭제에 실패했습니다.");
                }
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmAttendance))
                {
                    form.Close();
                    break;
                }
            }

            frmAttendance frm = new frmAttendance();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnAttInsert_Click(object sender, EventArgs e)
        {
            if (user.Position.Equals("원장") || user.EmpNo == int.Parse(dgvList.CurrentRow.Cells["EMP_NO"].Value.ToString())) 
            {
                int courseNo = int.Parse(dgvList.CurrentRow.Cells["COURSE_NO"].Value.ToString());

                frmAttInsert pop = new frmAttInsert(user, courseNo);
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(frmAttendance))
                        {
                            ((frmAttendance)form).LoadDgvList();
                            break;
                        }
                    }
                }                
            }
            else
            {
                MessageBox.Show("권한이 없습니다.");
                return;
            }

        }
    }
}
