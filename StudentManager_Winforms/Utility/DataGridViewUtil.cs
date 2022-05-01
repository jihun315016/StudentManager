using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager_Winforms
{
    public class DataGridViewUtil
    {
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersWidth = 10;
        }

        public static void SetDataGridViewColumn_TextBox
            (
                DataGridView dgv,
                string headerText,
                string propertyName,
                int colWidth = 100,
                bool isVisible = true,
                bool isReadlonly = true,
                DataGridViewContentAlignment alignHeader = DataGridViewContentAlignment.MiddleCenter,
                DataGridViewContentAlignment alignContent = DataGridViewContentAlignment.MiddleLeft

            )
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = propertyName;
            col.Name = propertyName;
            col.ReadOnly = isReadlonly;
            col.Width = colWidth;
            col.HeaderCell.Style.Alignment = alignHeader;
            col.DefaultCellStyle.Alignment = alignContent;
            
            col.Visible = isVisible;

            dgv.Columns.Add(col);
        }

        public static void SetDataGridViewColumn_CheckBox(DataGridView dgv, string propertyName, int colWidth = 30, bool isReadOnly = true)
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.DataPropertyName = propertyName;
            chk.Name = propertyName;
            chk.HeaderText = String.Empty;
            chk.Width = colWidth; 
            chk.ReadOnly = isReadOnly;
            dgv.Columns.Add(chk);
        }

        public static void SetDataGridViewColumn_HeaderCheckBox
            (
                DataGridView dgv, 
                CheckBox headerCheckBox, 
                int x, 
                int y, 
                int width = 14, 
                int height = 14
            )
        {
            int dgvX = dgv.Location.X;
            int dgvY = dgv.Location.Y;

            headerCheckBox.Location = new Point(dgvX + x, dgvY + y);
            headerCheckBox.Size = new Size(14, 14);
            dgv.Controls.Add(headerCheckBox);
        }
    }
}
