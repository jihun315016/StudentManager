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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            frmStudent_Resize(this, null);

            txtSpecialNote_Leave(this, null);
            txtStudentNo_Leave(this, null);
            txtClassNo_Leave(this, null);
        }

        private void frmStudent_Resize(object sender, EventArgs e)
        {
            Utility.Util.PanelLocateCenter(this, pnlEntire);
        }
        private void txtSpecialNote_Enter(object sender, EventArgs e)
        {
            Utility.Util.TextBoxInput(txtSpecialNote);
        }
        private void txtStudentNo_Enter(object sender, EventArgs e)
        {
            Utility.Util.TextBoxInput(txtStudentNo);
        }

        private void txtClassNo_Enter(object sender, EventArgs e)
        {
            Utility.Util.TextBoxInput(txtClassNo);
        }

        private void txtSpecialNote_Leave(object sender, EventArgs e)
        {
            Utility.Util.TextBoxHint(txtSpecialNote, "특이사항");
        }


        private void txtStudentNo_Leave(object sender, EventArgs e)
        {
            Utility.Util.TextBoxHint(txtStudentNo, "학생 번호 검색");
        }

        private void txtClassNo_Leave(object sender, EventArgs e)
        {
            Utility.Util.TextBoxHint(txtClassNo, "수강 번호 검색");
        }
    }
}
