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
            ccTxtCourseName.SetTextBoxPlaceHolder();

            EmployeeService empService = new EmployeeService();
            DataTable dt = empService.GetAllEmpNoName(true);
            DataRow dr = dt.NewRow();
            dr["EMP_NO"] = -1;
            dr["EMP_NAME"] = string.Empty;
            dr["EMP_INFO"] = "선택";
            dt.Rows.InsertAt(dr, 0);

            cboEmp.DataSource = dt;
            cboEmp.DisplayMember = "EMP_INFO";
            cboEmp.ValueMember = "EMP_NO";

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

            cboEmp.SelectedIndex = 0;
            ccTxtCourseName.Text = ccTxtCourseName.PlaceHolder;
            ccTxtCourseName.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool selectedEmpInfo = false;
            bool selectedCourseName = false;

            CourseService courseService = new CourseService();
            dgvList.DataSource = courseService.GetAllCourseInfo(chkNotCouse.Checked);

            if (!cboEmp.Text.Equals("선택"))
            {
                dgvList.DataSource = courseService.SearchByEmpInfo((DataTable)dgvList.DataSource, int.Parse(cboEmp.SelectedValue.ToString()));
                selectedEmpInfo = true;
            }

            if (!ccTxtCourseName.Text.Trim().Equals(ccTxtCourseName.PlaceHolder) && !ccTxtCourseName.Text.Trim().Equals(string.Empty))
            {
                dgvList.DataSource = courseService.SearchByCourseName((DataTable)dgvList.DataSource, ccTxtCourseName.Text.Trim());
                selectedCourseName = true;
            }

            if (!selectedEmpInfo && !selectedCourseName)
            {
                MessageBox.Show("선생님 정보 또는 수업을 입력해주세요.");
            }
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

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

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

        private void btnAttendanceNote_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmAttendanceBook))
                {
                    form.Close();
                    break;
                }
            }

            frmAttendanceBook pop = new frmAttendanceBook();
            pop.ShowDialog();
        }
    }
}
