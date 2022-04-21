namespace StudentManager_Winforms
{
    partial class frmSearchSchool
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSchool = new System.Windows.Forms.Panel();
            this.ccTxtSearch = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(273, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "학교";
            // 
            // pnlSchool
            // 
            this.pnlSchool.AutoScroll = true;
            this.pnlSchool.Location = new System.Drawing.Point(14, 51);
            this.pnlSchool.Name = "pnlSchool";
            this.pnlSchool.Size = new System.Drawing.Size(318, 216);
            this.pnlSchool.TabIndex = 11;
            // 
            // ccTxtSearch
            // 
            this.ccTxtSearch.Location = new System.Drawing.Point(14, 24);
            this.ccTxtSearch.Name = "ccTxtSearch";
            this.ccTxtSearch.PlaceHolder = "학교는 30개까지만 표시됩니다.";
            this.ccTxtSearch.Size = new System.Drawing.Size(253, 21);
            this.ccTxtSearch.TabIndex = 12;
            // 
            // frmSearchSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 279);
            this.Controls.Add(this.ccTxtSearch);
            this.Controls.Add(this.pnlSchool);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchSchool";
            this.Text = "frmSearchSchool";
            this.Load += new System.EventHandler(this.frmSearchSchool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSchool;
        private ccTextBoxPlaceHolder ccTxtSearch;
    }
}