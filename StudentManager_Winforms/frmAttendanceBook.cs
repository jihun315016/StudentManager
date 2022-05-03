using StudentManager.Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace StudentManager_Winforms
{
    public partial class frmAttendanceBook : Form
    {
        List<CheckBox> checkBoxList;

        public frmAttendanceBook()
        {
            InitializeComponent();
        }

        private void frmAttendanceBook_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvList);

            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 번호", "STUDENT_NO", alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "이름", "STUDENT_NAME", 60);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "나이", "AGE", 40, alignContent: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학교", "SCHOOL");
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "학생 연락처", "STUDENT_CONTACT", 120, alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "보호자 연락처", "GUARDIAN_CONTACT", 120,alignContent: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.SetDataGridViewColumn_TextBox(dgvList, "보호자", "GUARDIAN_RERATIONSHIP", 70);

            StudentService stuService = new StudentService();
            dgvList.DataSource = stuService.GetAttendanceBook();

            checkBoxList = new List<CheckBox>();

            int cnt = 0;
            foreach (DataGridViewColumn col in dgvList.Columns)
            {                
                CheckBox chk = new CheckBox();
                chk.Text = col.HeaderText;
                chk.Tag = col.Name;
                chk.Checked = true;
                chk.Location = new Point(20, 20 + cnt * 30);
                chk.CheckedChanged += Chk_CheckedChanged;
                pnlChk.Controls.Add(chk);
                cnt++;
            }
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Control con in pnlChk.Controls)
            {
                if (con is CheckBox chk)
                {
                    if (chk.Checked)                    
                        dgvList.Columns[chk.Tag.ToString()].Visible = true;
                    
                    else                    
                        dgvList.Columns[chk.Tag.ToString()].Visible = false;                    
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            StudentService stuService = new StudentService();
            DataTable dt = stuService.GetAttendanceBook();
            
            dt.Columns["STUDENT_NO"].Caption = "학생 번호";
            dt.Columns["STUDENT_NAME"].Caption = "이름";
            dt.Columns["AGE"].Caption = "나이";
            dt.Columns["SCHOOL"].Caption = "학교";
            dt.Columns["STUDENT_CONTACT"].Caption = "학생 연락처";
            dt.Columns["GUARDIAN_CONTACT"].Caption = "보호자 연락처";
            dt.Columns["GUARDIAN_RERATIONSHIP"].Caption = "보호자";


            foreach (Control con in pnlChk.Controls)
            {
                if (con is CheckBox chk && !chk.Checked)
                {
                    dt.Columns.Remove(chk.Tag.ToString());
                }
            }            

            dataGridView1.DataSource = dt;

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "xls|*.xls|xlsx|*xlsx";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);

                // 여기부터
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    xlWorkSheet.Cells[1, c + 1] = dt.Columns[c].Caption;
                }

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        xlWorkSheet.Cells[r + 2, c + 1] = dt.Rows[r][c].ToString();
                    }
                }

                xlWorkBook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close();
                xlApp.Quit();
                // 여기까지 try catch해서 return true or false

                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                    xlApp = null;

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                    xlWorkBook = null;

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                    xlWorkSheet = null;
                }
                catch
                {
                    xlApp = null;
                    xlWorkBook = null;
                    xlWorkSheet = null;
                }
                finally
                {
                    GC.Collect();
                }

            }
        }
    }
}
