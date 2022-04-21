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
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string temp = txtSearch.Text;
            string sql = $@"SELECT SCHOOL_NAME FROM tb_school WHERE SCHOOL_NAME LIKE @SCHOOL_NAME ORDER BY SCHOOL_NAME LIMIT 30";

            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            // like는 sql에 ''쓰면 안되는듯
            da.SelectCommand.Parameters.AddWithValue("@SCHOOL_NAME", $"%{temp}%");

            da.Fill(dt);
            conn.Close();

            pnlSchool.Controls.Clear();

            int cnt = 0;
            foreach (DataRow dr in dt.Rows)
            {
                ucSchoolLabel school = new ucSchoolLabel();
                school.Location = new Point(0, 3 + 35 * cnt);
                school.SchoolName = dr["SCHOOL_NAME"].ToString();
                school.DisplaySchool += DisplaySchoolButton;
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
