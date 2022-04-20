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
            string sql = "SELECT SCHOOL_NAME FROM TB_SCHOOL LIMIT 30";
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            
            da.Fill(dt);
            conn.Close();

            lstList.View = View.Tile;
            lstList.FullRowSelect = true;

            foreach (DataRow dr in dt.Rows)            
                lstList.Items.Add(dr["SCHOOL_NAME"].ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstList.Clear();

            string temp = "가락";
            string sql = $@"SELECT SCHOOL_NAME FROM tb_school WHERE SCHOOL_NAME LIKE @SCHOOL_NAME LIMIT 30";
            //  " SELECT ID,Description,Price FROM Catalog WHERE Description LIKE '%'+@SearchTerm+'%' AND 가격 <> '0.00'" ; }
            string connStr = ConfigurationManager.ConnectionStrings["studentManagerDB"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@SCHOOL_NAME", "%" +temp + "%");

            da.Fill(dt);
            conn.Close();

            lstList.View = View.Tile;
            lstList.FullRowSelect = true;
            
            foreach (DataRow dr in dt.Rows)
                lstList.Items.Add(dr["SCHOOL_NAME"].ToString());
        }
    }
}
