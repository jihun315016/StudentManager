using StudentManager.Service.Service;
using StudentManager_Winforms.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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

                school.DisplaySchool += (object senderControl, EventArgs eData) =>
                {
                    foreach (ucSchoolLabel schoolName in pnlSchool.Controls)
                        schoolName.UnDisplaySchoolButton();

                    ucSchoolLabel selected = senderControl as ucSchoolLabel;
                    selected.DisplaySchoolButton();
                };

                school.SelectSchoolName += (object senderControl, EventArgs eData) =>
                {
                    ucSchoolLabel selected = senderControl as ucSchoolLabel;
                    this.DialogResult = DialogResult.OK;
                    this.SchoolName = selected.SchoolName;
                    this.Close();
                };

                cnt++;
                pnlSchool.Controls.Add(school);
            }
        }

        private void ccTxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                btnSearch_Click(this, null);
            }
        }
    }
}
