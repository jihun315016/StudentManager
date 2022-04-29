﻿using System;
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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            frmPayment_Resize(this, null);

            txtStudentNo_Leave(this, null);
            txtClassNo_Leave(this, null);
        }

        private void frmPayment_Resize(object sender, EventArgs e)
        {
            //Utility.Util.PanelLocateCenter(this, pnlEntire);
        }

        private void txtStudentNo_Enter(object sender, EventArgs e)
        {
            //Utility.Util.TextBoxInput(txtStudentNo);
        }

        private void txtClassNo_Enter(object sender, EventArgs e)
        {
            //Utility.Util.TextBoxInput(txtClassNo);
        }

        private void txtStudentNo_Leave(object sender, EventArgs e)
        {
            //Utility.Util.TextBoxHint(txtStudentNo, "학생 번호 검색");
        }

        private void txtClassNo_Leave(object sender, EventArgs e)
        {
            //Utility.Util.TextBoxHint(txtClassNo, "수업 번호 검색");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmPaymentInsert pop = new frmPaymentInsert();
            pop.ShowDialog();
        }
    }
}
