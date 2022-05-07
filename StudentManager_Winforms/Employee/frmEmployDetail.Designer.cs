namespace StudentManager_Winforms
{
    partial class frmEmployDetail
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
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlEntire = new System.Windows.Forms.Panel();
            this.btnChangePw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnUpload = new System.Windows.Forms.Button();
            this.ptbEmployee = new System.Windows.Forms.PictureBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ccTxtEmail = new StudentManager_Winforms.Controls.ucInputEmail();
            this.ccTxtSpecialNote = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.pnlEntire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEditInfo.Location = new System.Drawing.Point(672, 448);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(75, 23);
            this.btnEditInfo.TabIndex = 82;
            this.btnEditInfo.Text = "수정";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(377, 186);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 12);
            this.lblDate.TabIndex = 98;
            this.lblDate.Text = "고용 날짜";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Control;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtContact.Location = new System.Drawing.Point(32, 139);
            this.txtContact.Mask = "000-9000-0000";
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(96, 15);
            this.txtContact.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(30, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 92;
            this.label7.Text = "연락처";
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmployeeInfo.Location = new System.Drawing.Point(3, 0);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(540, 23);
            this.lblEmployeeInfo.TabIndex = 63;
            this.lblEmployeeInfo.Text = "[직무] OOO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(236, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 84;
            this.label5.Text = "이름";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(238, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 22);
            this.txtName.TabIndex = 85;
            // 
            // pnlEntire
            // 
            this.pnlEntire.Controls.Add(this.btnChangePw);
            this.pnlEntire.Controls.Add(this.ccTxtEmail);
            this.pnlEntire.Controls.Add(this.label1);
            this.pnlEntire.Controls.Add(this.txtEmpNo);
            this.pnlEntire.Controls.Add(this.dtpDate);
            this.pnlEntire.Controls.Add(this.ccTxtSpecialNote);
            this.pnlEntire.Controls.Add(this.btnCancel);
            this.pnlEntire.Controls.Add(this.dgvList);
            this.pnlEntire.Controls.Add(this.btnUpload);
            this.pnlEntire.Controls.Add(this.ptbEmployee);
            this.pnlEntire.Controls.Add(this.txtPosition);
            this.pnlEntire.Controls.Add(this.cboPosition);
            this.pnlEntire.Controls.Add(this.label4);
            this.pnlEntire.Controls.Add(this.label9);
            this.pnlEntire.Controls.Add(this.btnEditInfo);
            this.pnlEntire.Controls.Add(this.lblDate);
            this.pnlEntire.Controls.Add(this.txtContact);
            this.pnlEntire.Controls.Add(this.label7);
            this.pnlEntire.Controls.Add(this.lblEmployeeInfo);
            this.pnlEntire.Controls.Add(this.label5);
            this.pnlEntire.Controls.Add(this.txtName);
            this.pnlEntire.Location = new System.Drawing.Point(12, 12);
            this.pnlEntire.Name = "pnlEntire";
            this.pnlEntire.Size = new System.Drawing.Size(770, 477);
            this.pnlEntire.TabIndex = 3;
            this.pnlEntire.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEntire_Paint);
            // 
            // btnChangePw
            // 
            this.btnChangePw.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChangePw.Location = new System.Drawing.Point(626, 199);
            this.btnChangePw.Name = "btnChangePw";
            this.btnChangePw.Size = new System.Drawing.Size(121, 23);
            this.btnChangePw.TabIndex = 124;
            this.btnChangePw.Text = "비밀번호 변경";
            this.btnChangePw.UseVisualStyleBackColor = true;
            this.btnChangePw.Click += new System.EventHandler(this.btnChangePw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "직원 번호";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmpNo.Location = new System.Drawing.Point(32, 69);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(96, 22);
            this.txtEmpNo.TabIndex = 122;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(377, 201);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(169, 21);
            this.dtpDate.TabIndex = 120;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(591, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 118;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(377, 252);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(370, 190);
            this.dgvList.TabIndex = 116;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpload.Location = new System.Drawing.Point(672, 160);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 115;
            this.btnUpload.Text = "업로드";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ptbEmployee
            // 
            this.ptbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbEmployee.Image = global::StudentManager_Winforms.Properties.Resources.image;
            this.ptbEmployee.Location = new System.Drawing.Point(597, 4);
            this.ptbEmployee.Name = "ptbEmployee";
            this.ptbEmployee.Size = new System.Drawing.Size(150, 150);
            this.ptbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEmployee.TabIndex = 114;
            this.ptbEmployee.TabStop = false;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPosition.Location = new System.Drawing.Point(503, 69);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(77, 22);
            this.txtPosition.TabIndex = 112;
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(398, 69);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(99, 21);
            this.cboPosition.TabIndex = 109;
            this.cboPosition.SelectedIndexChanged += new System.EventHandler(this.cboPosition_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(396, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 108;
            this.label4.Text = "직무";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(30, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 12);
            this.label9.TabIndex = 101;
            this.label9.Text = "이메일";
            // 
            // ccTxtEmail
            // 
            this.ccTxtEmail.FrontEmail = "";
            this.ccTxtEmail.Location = new System.Drawing.Point(32, 201);
            this.ccTxtEmail.Name = "ccTxtEmail";
            this.ccTxtEmail.RearEmail = "";
            this.ccTxtEmail.Size = new System.Drawing.Size(254, 22);
            this.ccTxtEmail.TabIndex = 123;
            // 
            // ccTxtSpecialNote
            // 
            this.ccTxtSpecialNote.Location = new System.Drawing.Point(32, 252);
            this.ccTxtSpecialNote.Multiline = true;
            this.ccTxtSpecialNote.Name = "ccTxtSpecialNote";
            this.ccTxtSpecialNote.PlaceHolder = "특이사항";
            this.ccTxtSpecialNote.Size = new System.Drawing.Size(316, 190);
            this.ccTxtSpecialNote.TabIndex = 119;
            // 
            // frmEmployDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 496);
            this.Controls.Add(this.pnlEntire);
            this.Name = "frmEmployDetail";
            this.Text = "frmEmployyDetail";
            this.Load += new System.EventHandler(this.frmEmployDetail_Load);
            this.pnlEntire.ResumeLayout(false);
            this.pnlEntire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox txtContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlEntire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox ptbEmployee;
        private ccTextBoxPlaceHolder ccTxtSpecialNote;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpNo;
        private Controls.ucInputEmail ccTxtEmail;
        private System.Windows.Forms.Button btnChangePw;
    }
}