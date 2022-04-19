using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public class TextBoxUtil
    {
        public static StringBuilder IsEmptyOrWhiteSpaceArr(string[] txtText, string[] txtName)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                for (int i = 0; i < txtText.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(txtText[i].Trim()))
                    {
                        sb.Append(txtName[i]);
                        break;
                    }
                }

                return sb;
            }
            catch (Exception err)
            {
                sb.Append(err.Message);
                return sb;
            }
        }
    }
}
