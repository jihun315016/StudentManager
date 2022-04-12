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
    public partial class frmContest : Form
    {
        public frmContest()
        {
            InitializeComponent();
        }

        private void frmContest_Load(object sender, EventArgs e)
        {
            frmContest_Resize(this, null);

            txtStudentNo_Leave(this, null);
            txtContestName_Leave(this, null);
        }

        private void frmContest_Resize(object sender, EventArgs e)
        {
            Utility.Util.PanelLocateCenter(this, pnlEntire);
        }

        private void txtStudentNo_Enter(object sender, EventArgs e)
        {
            Utility.Util.TextBoxInput(txtStudentNo);
        }

        private void txtContestName_Enter(object sender, EventArgs e)
        {
            Utility.Util.TextBoxInput(txtContestName);
        }

        private void txtStudentNo_Leave(object sender, EventArgs e)
        {
            Utility.Util.TextBoxHint(txtStudentNo, "학생 번호 검색");
        }

        private void txtContestName_Leave(object sender, EventArgs e)
        {
            Utility.Util.TextBoxHint(txtContestName, "대회명 검색");
        }
    }
}
