using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager_Winforms.Controls
{
    public partial class ucSchoolLabel : UserControl
    {
        public event EventHandler DisplaySchool;

        public string SchoolName 
        { 
            get { return lblSchoolName.Text; }
            set { lblSchoolName.Text = value; }
        }

        public ucSchoolLabel()
        {
            InitializeComponent();
        }
        private void ucSchoolLabel_Load(object sender, EventArgs e)
        {
            btnSchool.Visible = false;
        }

        public void DisplaySchoolButton()
        {
            btnSchool.Visible = true;
        }

        public void UnDisplaySchoolButton()
        {
            btnSchool.Visible = false;
        }

        private void lblSchoolName_Click(object sender, EventArgs e)
        {
            if (DisplaySchool != null)
                DisplaySchool(this, null);
        }

    }
}
