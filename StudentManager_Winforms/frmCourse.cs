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
        public frmCourse()
        {
            InitializeComponent();
        }
        private void frmCourse_Load(object sender, EventArgs e)
        {
            txtEmployeeNo_Leave(this, null);
        }

        private void txtEmployeeNo_Enter(object sender, EventArgs e)
        {
            Utility.Util.TextBoxInput(txtEmployeeNo);
        }

        private void txtEmployeeNo_Leave(object sender, EventArgs e)
        {
            Utility.Util.TextBoxHint(txtEmployeeNo, "사번 검색");
        }

    }
}
