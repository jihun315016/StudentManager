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
    public partial class frmCourseDetail : Form
    {
        public frmCourseDetail(int courseNo)
        {
            InitializeComponent();

            lblCourseNo.Text = courseNo.ToString();
        }

        private void frmCourseDetail_Load(object sender, EventArgs e)
        {
            CourseService courseService = new CourseService();
            CourseVO courseVO = courseService.GetCourseInfoByPk(int.Parse(lblCourseNo.Text));

            EmployeeService empService = new EmployeeService();
            EmployeeVO employeeVO = empService.GetEmpInfoByPk(courseVO.EmpNo);

            //lblCourseInfo.Text = $"[{courseVO.}]"
        }
    }
}
