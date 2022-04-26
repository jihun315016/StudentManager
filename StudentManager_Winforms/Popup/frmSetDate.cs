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

namespace StudentManager_Winforms
{
    public partial class frmSetDate : Form
    {
        public DateTime CommitDate { get; set; }
        public bool IsStudentStop { get; set; }
        public int EndReasonNo { get; set; }

        public frmSetDate(string dateLabel, bool isStudentStop = false)
        {
            InitializeComponent();

            this.IsStudentStop = isStudentStop;
            lblDate.Text = dateLabel;

            if (this.IsStudentStop)
            {
                this.Size = new Size(380, 260);

                StudentService stuService = new StudentService();
                List<string> endReasonList = stuService.GetAllEndReason();

                for (int i = 0; i < endReasonList.Count; i++)
                {
                    if (grbEndReason.Controls[i] is RadioButton rdo)
                    {
                        rdo.Text = endReasonList[i];
                        rdo.Tag = i + 1;
                    }
                }
            }
            else
            {
                this.Size = new Size(160, 120);
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (this.IsStudentStop)
            {
                EndReasonNo = -1;
                for (int i = 0; i < grbEndReason.Controls.Count; i++)
                {
                    if (grbEndReason.Controls[i] is RadioButton rdo && rdo.Checked)
                    {
                        EndReasonNo = int.Parse(rdo.Tag.ToString());
                        break;
                    }
                }

                if (EndReasonNo == -1)
                {
                    MessageBox.Show("퇴원 사유를 선택해주세요.");
                    return;
                }
            }

            CommitDate = dtpDate.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
