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
            this.btnInit = new System.Windows.Forms.Button();
            this.ccTxtCourseName = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.ucDateFilter = new StudentManager_Winforms.Controls.ucDateFilter();
            this.ccTxtStudentName = new StudentManager_Winforms.ccTextBoxPlaceHolder();
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
            this.dgvList.Size = new System.Drawing.Size(649, 292);
            this.dgvList.TabIndex = 93;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(535, 331);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSearch.TabIndex = 112;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInit
            // 
            this.btnInit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInit.Location = new System.Drawing.Point(601, 331);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(60, 23);
            this.btnInit.TabIndex = 113;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // ccTxtCourseName
            // 
            this.ccTxtCourseName.Location = new System.Drawing.Point(118, 333);
            this.ccTxtCourseName.Name = "ccTxtCourseName";
            this.ccTxtCourseName.PlaceHolder = "수업 검색";
            this.ccTxtCourseName.Size = new System.Drawing.Size(100, 21);
            this.ccTxtCourseName.TabIndex = 114;
            // 
            // ucDateFilter
            // 
            this.ucDateFilter.EndDate = new System.DateTime(2022, 5, 7, 15, 59, 45, 20);
            this.ucDateFilter.Location = new System.Drawing.Point(224, 333);
            this.ucDateFilter.Name = "ucDateFilter";
            this.ucDateFilter.Size = new System.Drawing.Size(238, 22);
            this.ucDateFilter.StartDate = new System.DateTime(2022, 4, 7, 15, 59, 45, 20);
            this.ucDateFilter.TabIndex = 111;
            // 
            // ccTxtStudentName
            // 
            this.ccTxtStudentName.Location = new System.Drawing.Point(12, 333);
            this.ccTxtStudentName.Name = "ccTxtStudentName";
            this.ccTxtStudentName.PlaceHolder = "학생 검색";
            this.ccTxtStudentName.Size = new System.Drawing.Size(100, 21);
            this.ccTxtStudentName.TabIndex = 109;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 362);
            this.Controls.Add(this.ccTxtCourseName);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ucDateFilter);
            this.Controls.Add(this.ccTxtStudentName);
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
        private System.Windows.Forms.Button btnSearch;
        private Controls.ucDateFilter ucDateFilter;
        private ccTextBoxPlaceHolder ccTxtStudentName;
        private System.Windows.Forms.Button btnInit;
        private ccTextBoxPlaceHolder ccTxtCourseName;
    }
}