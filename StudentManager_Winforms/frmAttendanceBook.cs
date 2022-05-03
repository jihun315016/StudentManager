﻿using StudentManager.Service.Service;
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
    public partial class frmAttendanceBook : Form
    {
        List<CheckBox> checkBoxList;

        public frmAttendanceBook()
        {
            InitializeComponent();
        }

        private void frmAttendanceBook_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvList);

            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 번호", "STUDENT_NO", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이름", "STUDENT_NAME", 60);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "나이", "AGE", 40, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학교", "SCHOOL");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 연락처", "STUDENT_CONTACT", 120, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "보호자 연락처", "GUARDIAN_CONTACT", 120,alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "보호자", "GUARDIAN_RERATIONSHIP", 70);

            StudentService stuService = new StudentService();
            dgvList.DataSource = stuService.GetAttendanceBook();

            checkBoxList = new List<CheckBox>();

            int cnt = 0;
            foreach (DataGridViewColumn col in dgvList.Columns)
            {                
                CheckBox chk = new CheckBox();
                chk.Text = col.HeaderText;
                chk.Tag = col.Name;
                chk.Checked = true;
                chk.Location = new Point(20, 20 + cnt * 30);
                chk.CheckedChanged += Chk_CheckedChanged;
                pnlChk.Controls.Add(chk);
                cnt++;
            }

            CourseService courseService = new CourseService();
            cboCourse.DataSource = courseService.GetCourseName("모든 학생 조회", false);
            cboCourse.DisplayMember = "COURSE_INFO";
            cboCourse.ValueMember = "COURSE_NO";
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            dgvList.Columns[chk.Tag.ToString()].Visible = chk.Checked;            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            StudentService stuService = new StudentService();
            DataTable dt = stuService.GetAttendanceBook();
            
            dt.Columns["STUDENT_NO"].Caption = "학생 번호";
            dt.Columns["STUDENT_NAME"].Caption = "이름";
            dt.Columns["AGE"].Caption = "나이";
            dt.Columns["SCHOOL"].Caption = "학교";
            dt.Columns["STUDENT_CONTACT"].Caption = "학생 연락처";
            dt.Columns["GUARDIAN_CONTACT"].Caption = "보호자 연락처";
            dt.Columns["GUARDIAN_RERATIONSHIP"].Caption = "보호자";


            foreach (Control con in pnlChk.Controls)
            {
                if (con is CheckBox chk && !chk.Checked)
                {
                    dt.Columns.Remove(chk.Tag.ToString());
                }
            }            

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "xls|*.xls|xlsx|*xlsx";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                AttendanceService attService = new AttendanceService();
                bool exportResult = attService.ExportAttendanceBook(dt, dlg.FileName);

                if (exportResult)
                    MessageBox.Show("파일이 저장되었습니다.");
                else
                    MessageBox.Show("파일 저장에 실패했습니다.");
            }
        }

        private void chkNoneCourse_CheckedChanged(object sender, EventArgs e)
        {
            CourseService courseService = new CourseService();
            cboCourse.DataSource = courseService.GetCourseName("모든 학생 조회", chkNoneCourse.Checked);
            cboCourse.DisplayMember = "COURSE_INFO";
            cboCourse.ValueMember = "COURSE_NO";
        }     

        private void cboCourse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StudentService stuService = new StudentService();
            dgvList.DataSource = stuService.GetAttendanceBook(int.Parse(cboCourse.SelectedValue.ToString()));
        }
    }
}
