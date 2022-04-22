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
    public partial class ucDateFilter : UserControl
    {
        public DateTime StartDate 
        {
            get { return dtp1.Value; }
            set { dtp1.Value = value; } 
        }

        public DateTime EndDate 
        { 
            get { return dtp2.Value; } 
            set { dtp2.Value = value; }
        }

        public ucDateFilter()
        {
            InitializeComponent();
        }

        private void ucDateFilter_Load(object sender, EventArgs e)
        {
            dtp1.Value = DateTime.Now.AddMonths(-1);
            dtp2.Value = DateTime.Now;
        }
    }
}
