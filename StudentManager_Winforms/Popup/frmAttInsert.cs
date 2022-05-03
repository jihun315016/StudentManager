using StudentManager.Data.VO;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public partial class frmAttInsert : Form
    {
        EmployeeVO user;
        int courseNo;

        // 그리드뷰에 조회된 항목이 처음 처리되는 출석인지, 이미 한 번 처리된 출석인지
        bool isExistDgvList;

        public frmAttInsert(EmployeeVO user, int courseNo)
        {
            InitializeComponent();
            this.user = user;
            this.courseNo = courseNo;
        }

        private void frmAttInsert_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvList);

            headerCheckBox.CheckedChanged += headerCheckBox_Click;

            DataGridViewUtil.SetDataGridViewColumn_HeaderCheckBox(dgvList, headerCheckBox, 210, -28);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 번호", "STUDENT_NO", 90, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이름", "STUDENT_NAME", 80);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "나이", "AGE", 40, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학교", "SCHOOL", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "출석 날짜", "ATTENDANCE_DATE", isVisible: false);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "출석 유무", "IS_ATTENDANCE", isVisible: false);            
            DataGridViewUtil.SetDataGridViewColumn_CheckBox(dgvList, "ATTENDANCE" , 40, isReadOnly: false);
   
            LoadStudentList();
        }
        
        void headerCheckBox_Click(object sender, EventArgs a)
        {
            dgvList.EndEdit();

            foreach (DataGridViewRow row in dgvList.Rows)
                row.Cells["ATTENDANCE"].Value = headerCheckBox.Checked;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("선택된 학생을 등록하시겠습니까?", "출석 등록", MessageBoxButtons.YesNo);
            if (msgResult == DialogResult.Yes)
            {
                List<int> stuNoList = new List<int>();
                List<int> isAttList = new List<int>();

                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    int stuNo = int.Parse(row.Cells["STUDENT_NO"].Value.ToString());
                    stuNoList.Add(stuNo);

                    // 출석했으면 1, 안 했으면 0
                    int isAttendance = Convert.ToBoolean(row.Cells["ATTENDANCE"].Value) ? 1 : 0;
                    isAttList.Add(isAttendance);
                }

                AttendanceService attService = new AttendanceService();
                bool result;

                if (isExistDgvList)
                {
                    result = attService.UpdateAttendance(stuNoList, courseNo, Convert.ToDateTime(dtpDate.Value.ToString("yyyy-MM-dd")), user.EmpNo, isAttList);
                }
                else                
                    result = attService.InsertAttendance(stuNoList, courseNo, dtpDate.Value, isAttList);
                
                if (result)
                {
                    MessageBox.Show("등록이 완료되었습니다.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("등록에 실패하였습니다.");
                    dgvList.ClearSelection();
                }
            }
        }  

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        void LoadStudentList()
        {
            CourseService courseService = new CourseService();
            AttendanceService attService = new AttendanceService();
            dgvList.DataSource = courseService.GetStudentListByCourse(courseNo);

            List<int> stuNoList = new List<int>();
            foreach (DataGridViewRow dr in dgvList.Rows)
                stuNoList.Add(int.Parse(dr.Cells["STUDENT_NO"].Value.ToString()));

            List<bool> isAttList = attService.IsAttendanceCheck(stuNoList, courseNo, Convert.ToDateTime(dtpDate.Value.ToString("yyyy-MM-dd")), out isExistDgvList);
            for (int i = 0; i < dgvList.Rows.Count; i++)
                dgvList.Rows[i].Cells["ATTENDANCE"].Value = isAttList[i];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
