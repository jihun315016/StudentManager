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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            frmEmployee_Resize(this, null);

            txtSpecialNote_Leave(this, null);
            txtEmpNo_Leave(this, null);
        }

        private void txtSpecialNote_Enter(object sender, EventArgs e)
        {
            Utility.Util.TextBoxInput(txtSpecialNote);
        }
        private void txtEmpNo_Enter(object sender, EventArgs e)
        {
            Utility.Util.TextBoxInput(txtEmpNo);
        }

        private void txtSpecialNote_Leave(object sender, EventArgs e)
        {
            Utility.Util.TextBoxHint(txtSpecialNote, "특이사항");
        }

        private void txtEmpNo_Leave(object sender, EventArgs e)
        {
            Utility.Util.TextBoxHint(txtEmpNo, "직원 번호 검색");
        }

        private void frmEmployee_Resize(object sender, EventArgs e)
        {
            Utility.Util.PanelLocateCenter(this, pnlEntire);
        }

    }
}
