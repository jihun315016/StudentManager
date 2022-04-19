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

            ccTxtEmpNo.SetTextBoxHint();
            ccTxtSpecialNote.SetTextBoxHint();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //TextBox[] txtArr = { txtName, ccTxtEmp_no, txtEmail1, txtEmail2 };
            string[] txtNameArr = { "이름", "사번", "이메일", "이메일" };

            //StringBuilder sb = TextBoxUtil.IsEmptyOrWhiteSpaceArr(txtArr, txtNameArr);
            //TextBoxUtil.IsEmptyOrWhiteSpaceArr()
        }       
    }
}
