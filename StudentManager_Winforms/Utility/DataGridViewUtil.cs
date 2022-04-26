﻿using System;
using System.Collections.Generic;
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
            dgv.ReadOnly = true;
        }

        public static void SetDataGridViewColumn_TextBox
            (
                DataGridView dgv,
                string headerText,
                string propertyName,
                int colWidth = 100,
                bool isVisible = true,
                DataGridViewContentAlignment alignHeader = DataGridViewContentAlignment.MiddleCenter,
                DataGridViewContentAlignment alignContent = DataGridViewContentAlignment.MiddleLeft

            )
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = propertyName;
            col.Name = propertyName;

            col.Width = colWidth;
            col.HeaderCell.Style.Alignment = alignHeader;
            col.DefaultCellStyle.Alignment = alignContent;
            
            col.Visible = isVisible;

            dgv.Columns.Add(col);
        }

        public static void SetRowAlignment
            (
                DataGridView dgv, 
                string[] cols, 
                DataGridViewContentAlignment align
            )
        {
            foreach (string col in cols)
                dgv.Columns[col].DefaultCellStyle.Alignment = align;            
        }
    }
}
