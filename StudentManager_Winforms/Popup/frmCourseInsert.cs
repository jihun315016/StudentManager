using StudentManager.Data.VO;
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
    public partial class frmCourseInsert : Form
    {
        bool isValidTeacher;

        public frmCourseInsert()
        {
            InitializeComponent();
        }

        private void frmCourseInsert_Load(object sender, EventArgs e)
        {
            lblEmpName.Visible = false;
            isValidTeacher = false;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string[] textBoxValue = { txtEmpNo.Text, txtCourse.Text, txtPayment.Text };
            string[] textBoxName = { "직원 번호", "수업", "회비" };
            StringBuilder sb = TextBoxUtil.IsEmptyOrWhiteSpaceArr(textBoxValue, textBoxName);
            if (sb.Length > 0)
            {
                MessageBox.Show($"{sb.ToString()}을 입력해주세요.");
                return;
            }

            EmployeeService dac = new EmployeeService();
            EmployeeVO empVO = dac.GetEmpInfoByPk(int.Parse(txtEmpNo.Text));

            // 직원 번호 유효성 검사            
            if (isValidTeacher)
            {
                // 회비도 어짜피 숫자만 입력 가능
                CourseService courseService = new CourseService();
                CourseVO courseVO = new CourseVO()
                {
                    EmpNo = int.Parse(txtEmpNo.Text),
                    CourseName = txtCourse.Text,
                    Payment = int.Parse(txtPayment.Text),
                    StartDate = dtpStart.Value,
                    EndDate = dtpEnd.Value
                };

                bool result = courseService.InsertCourse(courseVO);

                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("수업이 등록되었습니다.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("등록에 실패하였습니다.");
                }
            }
            else
            {
                lblEmpName.Visible = true;
            }
            
        }

        private void txt_onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }        

        private void txtEmpNo_Leave(object sender, EventArgs e)
        {
            lblEmpName.Visible = true;
            CourseService courseService = new CourseService();

            // 어짜피 txtEmpNo는 숫자만 입력 가능
            lblEmpName.Text = courseService.CheckDirectorOrTeacherByEmpNo(txtEmpNo.Text, out isValidTeacher);

            if (isValidTeacher)
                lblEmpName.ForeColor = Color.Green;
            else
                lblEmpName.ForeColor = Color.Red;
        }

    }
}
