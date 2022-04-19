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

namespace StudentManager_Winforms
{
    public partial class frmSearchSchool : Form
    {
        public frmSearchSchool()
        {
            InitializeComponent();
        }

        private void frmSearchSchool_Load(object sender, EventArgs e)
        {
            string sql = "SELECT SCHOOL_NAME, ADDRESS FROM TB_SCHOOL LIMIT 10";
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            // conn.Open();
            da.Fill(dt);
            conn.Close();

            lstList.View = View.Tile;
            //lstList.Columns.Add("a", 50, HorizontalAlignment.Left);
            //lstList.Columns.Add("b", 50, HorizontalAlignment.Left);
            foreach (DataRow dr in dt.Rows)
            {
                //Label lbl = new Label();
                //lbl.AutoSize = false;
                //lbl.Width = 400;
                //lbl.Height = top;
                //lbl.Text = dr[0].ToString() + "\n" + dr[1].ToString();
                //lstList.Controls.Add(lbl);
                //lstList.Items.Add(dr["ADDRESS"].ToString());
                //lstList.Items.Add(dr["SCHOOL_NAME"].ToString() + "<br/>" + dr["ADDRESS"].ToString());

                string school = dr["SCHOOL_NAME"].ToString();
                string addr =  dr["ADDRESS"].ToString();
                lstList.Items.Add($"{school}{Environment.NewLine}{addr}");
                
            }
            lstList.EndUpdate();
        }

    }
}
