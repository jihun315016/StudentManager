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
    public partial class frmFindPw : Form
    {
        public frmFindPw()
        {
            InitializeComponent();
        }

        private void frmFindPw_Load(object sender, EventArgs e)
        {
            frmFindPw_Resize(this, null);
        }

        private void frmFindPw_Resize(object sender, EventArgs e)
        {
            Utility.Util.PanelLocateCenter(this, pnlFindPw);
        }
    }
}
