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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void 직원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Top += 50;
            frm.Show();
        }

        private void 학생ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent frm = new frmStudent();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Top += 50;
            frm.Show();
        }

        private void 출석ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendance frm = new frmAttendance();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Top += 50;
            frm.Show();
        }

        private void 결제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Top += 50;
            frm.Show();
        }

        private void 수상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContest frm = new frmContest();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Top += 50;
            frm.Show();
        }
    }
}
