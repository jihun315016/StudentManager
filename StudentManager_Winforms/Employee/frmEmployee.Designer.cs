namespace StudentManager_Winforms
{
    partial class frmEmployee
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
            this.cmsSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmResignation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReJoin = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnOpenInsert = new System.Windows.Forms.Button();
            this.ccTxtEmpNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.ucDateFilter = new StudentManager_Winforms.Controls.ucDateFilter();
            this.chkResignation = new System.Windows.Forms.CheckBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.MaskedTextBox();
            this.ptbEmployee = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.txtOtherPosition = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.ccTxtSpecialNote = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.ucEmail = new StudentManager_Winforms.Controls.ucInputEmail();
            this.cmsSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsSetting
            // 
            this.cmsSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmResignation,
            this.tsmReJoin});
            this.cmsSetting.Name = "cmsSetting";
            this.cmsSetting.Size = new System.Drawing.Size(111, 48);
            // 
            // tsmResignation
            // 
            this.tsmResignation.Name = "tsmResignation";
            this.tsmResignation.Size = new System.Drawing.Size(110, 22);
            this.tsmResignation.Text = "퇴사";
            this.tsmResignation.Click += new System.EventHandler(this.tsmResignation_Click);
            // 
            // tsmReJoin
            // 
            this.tsmReJoin.Name = "tsmReJoin";
            this.tsmReJoin.Size = new System.Drawing.Size(110, 22);
            this.tsmReJoin.Text = "재입사";
            this.tsmReJoin.Click += new System.EventHandler(this.tsmReJoin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "직원";
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchDate.Location = new System.Drawing.Point(527, 364);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(80, 23);
            this.btnSearchDate.TabIndex = 36;
            this.btnSearchDate.Text = "날짜 검색";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(15, 35);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(592, 323);
            this.dgvList.TabIndex = 94;
            this.dgvList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentDoubleClick);
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            // 
            // btnOpenInsert
            // 
            this.btnOpenInsert.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpenInsert.Location = new System.Drawing.Point(562, 6);
            this.btnOpenInsert.Name = "btnOpenInsert";
            this.btnOpenInsert.Size = new System.Drawing.Size(45, 23);
            this.btnOpenInsert.TabIndex = 97;
            this.btnOpenInsert.Text = ">>";
            this.btnOpenInsert.UseVisualStyleBackColor = true;
            this.btnOpenInsert.Click += new System.EventHandler(this.btnOpenInsert_Click);
            // 
            // ccTxtEmpNo
            // 
            this.ccTxtEmpNo.Location = new System.Drawing.Point(15, 366);
            this.ccTxtEmpNo.Name = "ccTxtEmpNo";
            this.ccTxtEmpNo.PlaceHolder = "직원 번호 검색";
            this.ccTxtEmpNo.Size = new System.Drawing.Size(95, 21);
            this.ccTxtEmpNo.TabIndex = 99;
            this.ccTxtEmpNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ccTxtEmpNo_KeyPress);
            // 
            // ucDateFilter
            // 
            this.ucDateFilter.EndDate = new System.DateTime(2022, 5, 2, 16, 6, 2, 39);
            this.ucDateFilter.Location = new System.Drawing.Point(283, 365);
            this.ucDateFilter.Name = "ucDateFilter";
            this.ucDateFilter.Size = new System.Drawing.Size(238, 22);
            this.ucDateFilter.StartDate = new System.DateTime(2022, 4, 2, 16, 6, 2, 38);
            this.ucDateFilter.TabIndex = 100;
            // 
            // chkResignation
            // 
            this.chkResignation.AutoSize = true;
            this.chkResignation.Location = new System.Drawing.Point(508, 10);
            this.chkResignation.Name = "chkResignation";
            this.chkResignation.Size = new System.Drawing.Size(48, 16);
            this.chkResignation.TabIndex = 101;
            this.chkResignation.Text = "퇴사";
            this.chkResignation.UseVisualStyleBackColor = true;
            this.chkResignation.CheckedChanged += new System.EventHandler(this.chkResignation_CheckedChanged);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchEmp.Location = new System.Drawing.Point(116, 364);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(80, 23);
            this.btnSearchEmp.TabIndex = 102;
            this.btnSearchEmp.Text = "직원 검색";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(779, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 64;
            this.label7.Text = "이름";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(781, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(99, 21);
            this.txtName.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(628, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "이메일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(779, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 67;
            this.label4.Text = "연락처";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Control;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtContact.Location = new System.Drawing.Point(779, 98);
            this.txtContact.Mask = "000-9000-0000";
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(99, 15);
            this.txtContact.TabIndex = 68;
            // 
            // ptbEmployee
            // 
            this.ptbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbEmployee.Image = global::StudentManager_Winforms.Properties.Resources.image;
            this.ptbEmployee.Location = new System.Drawing.Point(624, 35);
            this.ptbEmployee.Name = "ptbEmployee";
            this.ptbEmployee.Size = new System.Drawing.Size(128, 128);
            this.ptbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEmployee.TabIndex = 73;
            this.ptbEmployee.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpload.Location = new System.Drawing.Point(677, 169);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 74;
            this.btnUpload.Text = "업로드";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(779, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 75;
            this.label10.Text = "고용 날짜";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(779, 142);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(100, 21);
            this.dtpStartDate.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(628, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 77;
            this.label9.Text = "직무";
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(628, 263);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(81, 20);
            this.cboPosition.TabIndex = 78;
            this.cboPosition.SelectedIndexChanged += new System.EventHandler(this.cboPosition_SelectedIndexChanged);
            // 
            // txtOtherPosition
            // 
            this.txtOtherPosition.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOtherPosition.Location = new System.Drawing.Point(715, 262);
            this.txtOtherPosition.Name = "txtOtherPosition";
            this.txtOtherPosition.Size = new System.Drawing.Size(74, 21);
            this.txtOtherPosition.TabIndex = 81;
            this.txtOtherPosition.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(833, 364);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 82;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ccTxtSpecialNote
            // 
            this.ccTxtSpecialNote.Location = new System.Drawing.Point(628, 291);
            this.ccTxtSpecialNote.Multiline = true;
            this.ccTxtSpecialNote.Name = "ccTxtSpecialNote";
            this.ccTxtSpecialNote.PlaceHolder = "특이사항";
            this.ccTxtSpecialNote.Size = new System.Drawing.Size(280, 67);
            this.ccTxtSpecialNote.TabIndex = 100;
            // 
            // ucEmail
            // 
            this.ucEmail.FrontEmail = "";
            this.ucEmail.Location = new System.Drawing.Point(628, 216);
            this.ucEmail.Name = "ucEmail";
            this.ucEmail.RearEmail = "";
            this.ucEmail.Size = new System.Drawing.Size(254, 22);
            this.ucEmail.TabIndex = 101;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 401);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.ucEmail);
            this.Controls.Add(this.ucDateFilter);
            this.Controls.Add(this.chkResignation);
            this.Controls.Add(this.ccTxtEmpNo);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.ccTxtSpecialNote);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnOpenInsert);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtOtherPosition);
            this.Controls.Add(this.ptbEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.cmsSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmResignation;
        private System.Windows.Forms.ToolStripMenuItem tsmReJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnOpenInsert;
        private ccTextBoxPlaceHolder ccTxtEmpNo;
        private Controls.ucDateFilter ucDateFilter;
        private System.Windows.Forms.CheckBox chkResignation;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtContact;
        private System.Windows.Forms.PictureBox ptbEmployee;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.TextBox txtOtherPosition;
        private System.Windows.Forms.Button btnInsert;
        private ccTextBoxPlaceHolder ccTxtSpecialNote;
        private Controls.ucInputEmail ucEmail;
    }
}