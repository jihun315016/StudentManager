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
    public partial class frmCourse : Form
    {
        public event EventHandler CreateCoursePopup;

        public frmCourse()
        {
            InitializeComponent();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            ccTxtBoxPlaceHolder.SetTextBoxPlaceHolder();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmCourseInsert frm = new frmCourseInsert();
            frm.MdiParent = this.MdiParent;
            frm.Tag = this;            
            frm.Show();
        }
    }
}
