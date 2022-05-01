namespace StudentManager_Winforms
{
    partial class frmAttendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ccTxtCourseNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.ucDateFilter = new StudentManager_Winforms.Controls.ucDateFilter();
            this.ccTxtStudentNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "출석";
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 35);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(759, 292);
            this.dgvList.TabIndex = 93;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(468, 333);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 112;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ccTxtCourseNo
            // 
            this.ccTxtCourseNo.Location = new System.Drawing.Point(118, 333);
            this.ccTxtCourseNo.Name = "ccTxtCourseNo";
            this.ccTxtCourseNo.PlaceHolder = "수업 번호 검색";
            this.ccTxtCourseNo.Size = new System.Drawing.Size(100, 21);
            this.ccTxtCourseNo.TabIndex = 110;
            // 
            // ucDateFilter
            // 
            this.ucDateFilter.EndDate = new System.DateTime(2022, 5, 2, 0, 10, 35, 238);
            this.ucDateFilter.Location = new System.Drawing.Point(224, 332);
            this.ucDateFilter.Name = "ucDateFilter";
            this.ucDateFilter.Size = new System.Drawing.Size(238, 22);
            this.ucDateFilter.StartDate = new System.DateTime(2022, 4, 2, 0, 10, 35, 238);
            this.ucDateFilter.TabIndex = 111;
            // 
            // ccTxtStudentNo
            // 
            this.ccTxtStudentNo.Location = new System.Drawing.Point(12, 333);
            this.ccTxtStudentNo.Name = "ccTxtStudentNo";
            this.ccTxtStudentNo.PlaceHolder = "학생 번호 검색";
            this.ccTxtStudentNo.Size = new System.Drawing.Size(100, 21);
            this.ccTxtStudentNo.TabIndex = 109;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 371);
            this.Controls.Add(this.ccTxtCourseNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ucDateFilter);
            this.Controls.Add(this.ccTxtStudentNo);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label1);
            this.Name = "frmAttendance";
            this.Text = "frmAttendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private ccTextBoxPlaceHolder ccTxtCourseNo;
        private System.Windows.Forms.Button btnSearch;
        private Controls.ucDateFilter ucDateFilter;
        private ccTextBoxPlaceHolder ccTxtStudentNo;
    }
}