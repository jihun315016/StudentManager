
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
            this.ccTxtCourseNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ucDateFilter = new StudentManager_Winforms.Controls.ucDateFilter();
            this.ccTxtStudentNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bdsPaymentSoarse = new System.Windows.Forms.BindingSource(this.components);
            this.cmsSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCancelPayment = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPaymentSoarse)).BeginInit();
            this.cmsSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // ccTxtCourseNo
            // 
            this.ccTxtCourseNo.Location = new System.Drawing.Point(118, 296);
            this.ccTxtCourseNo.Name = "ccTxtCourseNo";
            this.ccTxtCourseNo.PlaceHolder = "수업 번호 검색";
            this.ccTxtCourseNo.Size = new System.Drawing.Size(100, 21);
            this.ccTxtCourseNo.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(681, 294);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucDateFilter
            // 
            this.ucDateFilter.EndDate = new System.DateTime(2022, 5, 9, 15, 10, 28, 341);
            this.ucDateFilter.Location = new System.Drawing.Point(224, 295);
            this.ucDateFilter.Name = "ucDateFilter";
            this.ucDateFilter.Size = new System.Drawing.Size(238, 22);
            this.ucDateFilter.StartDate = new System.DateTime(2022, 4, 9, 15, 10, 28, 341);
            this.ucDateFilter.TabIndex = 106;
            // 
            // ccTxtStudentNo
            // 
            this.ccTxtStudentNo.Location = new System.Drawing.Point(12, 296);
            this.ccTxtStudentNo.Name = "ccTxtStudentNo";
            this.ccTxtStudentNo.PlaceHolder = "학생 번호 검색";
            this.ccTxtStudentNo.Size = new System.Drawing.Size(100, 21);
            this.ccTxtStudentNo.TabIndex = 0;
            this.ccTxtStudentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 96;
            this.label1.Text = "결제";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(686, 6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 95;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 35);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(749, 255);
            this.dgvList.TabIndex = 94;
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            // 
            // cmsSetting
            // 
            this.cmsSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCancelPayment});
            this.cmsSetting.Name = "cmsSetting";
            this.cmsSetting.Size = new System.Drawing.Size(127, 26);
            // 
            // tsmCancelPayment
            // 
            this.tsmCancelPayment.Name = "tsmCancelPayment";
            this.tsmCancelPayment.Size = new System.Drawing.Size(126, 22);
            this.tsmCancelPayment.Text = "결제 취소";
            this.tsmCancelPayment.Click += new System.EventHandler(this.tsmCancelPayment_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 321);
            this.Controls.Add(this.ccTxtCourseNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ucDateFilter);
            this.Controls.Add(this.ccTxtStudentNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvList);
            this.Name = "frmPayment";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPaymentSoarse)).EndInit();
            this.cmsSetting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private Controls.ucDateFilter ucDateFilter;
        private ccTextBoxPlaceHolder ccTxtStudentNo;
        private ccTextBoxPlaceHolder ccTxtCourseNo;
        private System.Windows.Forms.BindingSource bdsPaymentSoarse;
        private System.Windows.Forms.ContextMenuStrip cmsSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelPayment;
    }
}