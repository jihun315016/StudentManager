using MySql.Data.MySqlClient;
using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StudentManager_Winforms.Controls;

namespace StudentManager_Winforms
{
    public partial class frmSearchSchool : Form
    {
        public string SchoolName { get; set; }

        public frmSearchSchool()
        {
            InitializeComponent();
        }

        private void frmSearchSchool_Load(object sender, EventArgs e)
        {
            ccTxtSearch.SetTextBoxPlaceHolder();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentService student = new StudentService();
            DataTable schoolList = student.GetSchoolList(ccTxtSearch.Text);

            pnlSchool.Controls.Clear();

            int cnt = 0;
            foreach (DataRow dr in schoolList.Rows)
            {
                ucSchoolLabel school = new ucSchoolLabel();
                school.Location = new Point(0, 3 + 35 * cnt);
                school.SchoolName = dr["SCHOOL_NAME"].ToString();
                school.DisplaySchool += DisplaySchoolButton;
                school.SelectSchoolName += SelectSchoolName;
                cnt++;
                pnlSchool.Controls.Add(school);
            }
        }

        void DisplaySchoolButton(object sender, EventArgs e)
        {         
            foreach (ucSchoolLabel school in pnlSchool.Controls)
                school.UnDisplaySchoolButton();

            ucSchoolLabel selected = sender as ucSchoolLabel;
            selected.DisplaySchoolButton();
        }

        void SelectSchoolName(object sender, EventArgs e)
        {
            ucSchoolLabel selected = sender as ucSchoolLabel;

            this.DialogResult = DialogResult.OK;
            this.SchoolName = selected.SchoolName;
            this.Close();
        }
    }
}
