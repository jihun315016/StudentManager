namespace StudentManager_Winforms
{
    partial class frmCourse
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAttendanceNote = new System.Windows.Forms.Button();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.btnAttInsert = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.chkNotCouse = new System.Windows.Forms.CheckBox();
            this.ccTxtCourseName = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCourseInsert = new System.Windows.Forms.Button();
            this.cmsSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmsSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAttendanceNote);
            this.panel2.Controls.Add(this.cboEmp);
            this.panel2.Controls.Add(this.btnAttInsert);
            this.panel2.Controls.Add(this.btnAttendance);
            this.panel2.Controls.Add(this.chkNotCouse);
            this.panel2.Controls.Add(this.ccTxtCourseName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCourseInsert);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 333);
            this.panel2.TabIndex = 5;
            // 
            // btnAttendanceNote
            // 
            this.btnAttendanceNote.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAttendanceNote.Location = new System.Drawing.Point(157, 29);
            this.btnAttendanceNote.Name = "btnAttendanceNote";
            this.btnAttendanceNote.Size = new System.Drawing.Size(75, 23);
            this.btnAttendanceNote.TabIndex = 100;
            this.btnAttendanceNote.Text = "출석부";
            this.btnAttendanceNote.UseVisualStyleBackColor = true;
            this.btnAttendanceNote.Click += new System.EventHandler(this.btnAttendanceNote_Click);
            // 
            // cboEmp
            // 
            this.cboEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Location = new System.Drawing.Point(3, 310);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(112, 20);
            this.cboEmp.TabIndex = 99;
            // 
            // btnAttInsert
            // 
            this.btnAttInsert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAttInsert.Location = new System.Drawing.Point(319, 29);
            this.btnAttInsert.Name = "btnAttInsert";
            this.btnAttInsert.Size = new System.Drawing.Size(75, 23);
            this.btnAttInsert.TabIndex = 98;
            this.btnAttInsert.Text = "출석 등록";
            this.btnAttInsert.UseVisualStyleBackColor = true;
            this.btnAttInsert.Click += new System.EventHandler(this.btnAttInsert_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAttendance.Location = new System.Drawing.Point(238, 29);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(75, 23);
            this.btnAttendance.TabIndex = 97;
            this.btnAttendance.Text = "출석 조회";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // chkNotCouse
            // 
            this.chkNotCouse.AutoSize = true;
            this.chkNotCouse.Location = new System.Drawing.Point(387, 7);
            this.chkNotCouse.Name = "chkNotCouse";
            this.chkNotCouse.Size = new System.Drawing.Size(86, 16);
            this.chkNotCouse.TabIndex = 96;
            this.chkNotCouse.Text = "종강 / 예정";
            this.chkNotCouse.UseVisualStyleBackColor = true;
            this.chkNotCouse.CheckedChanged += new System.EventHandler(this.chkFinalCourse_CheckedChanged);
            // 
            // ccTxtCourseName
            // 
            this.ccTxtCourseName.Location = new System.Drawing.Point(292, 306);
            this.ccTxtCourseName.Name = "ccTxtCourseName";
            this.ccTxtCourseName.PlaceHolder = "수업 검색";
            this.ccTxtCourseName.Size = new System.Drawing.Size(100, 21);
            this.ccTxtCourseName.TabIndex = 95;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(398, 306);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 58);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(472, 243);
            this.dgvList.TabIndex = 94;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "수업";
            // 
            // btnCourseInsert
            // 
            this.btnCourseInsert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCourseInsert.Location = new System.Drawing.Point(400, 29);
            this.btnCourseInsert.Name = "btnCourseInsert";
            this.btnCourseInsert.Size = new System.Drawing.Size(75, 23);
            this.btnCourseInsert.TabIndex = 82;
            this.btnCourseInsert.Text = "수업 등록";
            this.btnCourseInsert.UseVisualStyleBackColor = true;
            this.btnCourseInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmsSetting
            // 
            this.cmsSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete});
            this.cmsSetting.Name = "cmsSetting";
            this.cmsSetting.Size = new System.Drawing.Size(99, 26);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(98, 22);
            this.tsmDelete.Text = "삭제";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 351);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourse";
            this.Text = "수업";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmsSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnCourseInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private ccTextBoxPlaceHolder ccTxtCourseName;
        private System.Windows.Forms.CheckBox chkNotCouse;
        private System.Windows.Forms.ContextMenuStrip cmsSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnAttInsert;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.Button btnAttendanceNote;
    }
}