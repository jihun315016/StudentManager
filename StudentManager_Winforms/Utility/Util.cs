using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager_Winforms.Utility
{
    public class Util
    {
        public static void PanelLocateCenter(Form parent, Panel child)
        {
            child.Left = parent.Width / 2 - child.Width / 2;
            child.Top = parent.Height / 2 - child.Height / 2 - parent.Height / 20;
            // 높이는 중앙보다 살짝 높게
        }
        public static void PanelLocateCenter(Panel parent, Panel child)
        {
            child.Left = parent.Width / 2 - child.Width / 2;
            child.Top = parent.Height / 2 - child.Height / 2;
        }

        public static void TextBoxHint(TextBox textBox, string msg)
        {
            if (textBox.Text.Equals(string.Empty))
            {
                textBox.Text = msg;
                textBox.ForeColor = Color.Gray;
            }
        }

        public static void TextBoxInput(TextBox textBox)
        {
            textBox.Text = string.Empty;
            textBox.ForeColor = Color.Black;
        }
    }
}
