
namespace StudentManager_Winforms
{
    partial class frmPayment
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bdsPaymentSoarse = new System.Windows.Forms.BindingSource(this.components);
            this.ccTxtCourseNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.ucDateFilter = new StudentManager_Winforms.Controls.ucDateFilter();
            this.ccTxtStudentNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPaymentSoarse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ccTxtCourseNo);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.ucDateFilter);
            this.panel2.Controls.Add(this.ccTxtStudentNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 325);
            this.panel2.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(672, 295);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 96;
            this.label1.Text = "결제";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(677, 7);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 95;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 36);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(749, 255);
            this.dgvList.TabIndex = 94;
            // 
            // ccTxtCourseNo
            // 
            this.ccTxtCourseNo.Location = new System.Drawing.Point(109, 297);
            this.ccTxtCourseNo.Name = "ccTxtCourseNo";
            this.ccTxtCourseNo.PlaceHolder = "수업 번호 검색";
            this.ccTxtCourseNo.Size = new System.Drawing.Size(100, 21);
            this.ccTxtCourseNo.TabIndex = 1;
            // 
            // ucDateFilter
            // 
            this.ucDateFilter.EndDate = new System.DateTime(2022, 4, 30, 14, 56, 9, 883);
            this.ucDateFilter.Location = new System.Drawing.Point(215, 296);
            this.ucDateFilter.Name = "ucDateFilter";
            this.ucDateFilter.Size = new System.Drawing.Size(238, 22);
            this.ucDateFilter.StartDate = new System.DateTime(2022, 3, 30, 14, 56, 9, 883);
            this.ucDateFilter.TabIndex = 106;
            // 
            // ccTxtStudentNo
            // 
            this.ccTxtStudentNo.Location = new System.Drawing.Point(3, 297);
            this.ccTxtStudentNo.Name = "ccTxtStudentNo";
            this.ccTxtStudentNo.PlaceHolder = "학생 번호 검색";
            this.ccTxtStudentNo.Size = new System.Drawing.Size(100, 21);
            this.ccTxtStudentNo.TabIndex = 0;
            this.ccTxtStudentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumber_KeyPress);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 343);
            this.Controls.Add(this.panel2);
            this.Name = "frmPayment";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPaymentSoarse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private Controls.ucDateFilter ucDateFilter;
        private ccTextBoxPlaceHolder ccTxtStudentNo;
        private ccTextBoxPlaceHolder ccTxtCourseNo;
        private System.Windows.Forms.BindingSource bdsPaymentSoarse;
    }
}