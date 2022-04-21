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
    public partial class ccTextBoxPlaceHolder : TextBox
    {
        public string PlaceHolder { get; set; }

        public ccTextBoxPlaceHolder()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void SetTextBoxPlaceHolder()
        {
            ccTextBoxHint_Leave(this, null);
        }

        private void ccTextBoxHint_Enter(object sender, EventArgs e)
        {
            if (this.Text.Equals(this.PlaceHolder))
            {
                this.Text = string.Empty;
                this.ForeColor = Color.Black;
            }
        }

        private void ccTextBoxHint_Leave(object sender, EventArgs e)
        {
            if (this.Text.Equals(string.Empty))
            {
                this.Text = this.PlaceHolder;
                this.ForeColor = Color.Gray;
            }            
        }
    }
}
