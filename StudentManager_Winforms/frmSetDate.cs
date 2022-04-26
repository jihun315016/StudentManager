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
    public partial class frmSetDate : Form
    {
        public DateTime CommitDate { get; set; }

        public frmSetDate(string dateLabel)
        {
            InitializeComponent();
            lblDate.Text = dateLabel;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            CommitDate = dtpDate.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
