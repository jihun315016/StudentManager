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
            dgvList.DataSource = attService.GetAllAttendanceList(start, end);
        }
    }
}
