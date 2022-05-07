
namespace StudentManager_Winforms
{
    partial class frmAttendanceBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlChk = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkNoneCourse = new System.Windows.Forms.CheckBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 12);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(639, 346);
            this.dgvList.TabIndex = 0;
            // 
            // pnlChk
            // 
            this.pnlChk.Location = new System.Drawing.Point(657, 114);
            this.pnlChk.Name = "pnlChk";
            this.pnlChk.Size = new System.Drawing.Size(133, 215);
            this.pnlChk.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExport.Location = new System.Drawing.Point(718, 335);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(72, 23);
            this.btnExport.TabIndex = 84;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkNoneCourse
            // 
            this.chkNoneCourse.AutoSize = true;
            this.chkNoneCourse.Location = new System.Drawing.Point(657, 12);
            this.chkNoneCourse.Name = "chkNoneCourse";
            this.chkNoneCourse.Size = new System.Drawing.Size(114, 16);
            this.chkNoneCourse.TabIndex = 85;
            this.chkNoneCourse.Text = "종강 / 개강 예정";
            this.chkNoneCourse.UseVisualStyleBackColor = true;
            this.chkNoneCourse.CheckedChanged += new System.EventHandler(this.chkNoneCourse_CheckedChanged);
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(657, 34);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(133, 20);
            this.cboCourse.TabIndex = 86;
            this.cboCourse.SelectionChangeCommitted += new System.EventHandler(this.cboCourse_SelectionChangeCommitted);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(657, 60);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(135, 21);
            this.dtpDate.TabIndex = 87;
            this.dtpDate.Value = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(737, 87);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(55, 21);
            this.txtPeriod.TabIndex = 88;
            this.txtPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(655, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 11);
            this.label1.TabIndex = 89;
            this.label1.Text = "출석 범위 (일)";
            // 
            // frmAttendanceBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.chkNoneCourse);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pnlChk);
            this.Controls.Add(this.dgvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttendanceBook";
            this.Text = "출석부";
            this.Load += new System.EventHandler(this.frmAttendanceBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel pnlChk;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkNoneCourse;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label label1;
    }
}