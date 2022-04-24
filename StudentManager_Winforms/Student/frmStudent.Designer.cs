namespace StudentManager_Winforms
{
    partial class frmStudent
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
            this.pnlInsert = new System.Windows.Forms.Panel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.ccTxtSpecialNote = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pnlGuardianRerationship = new System.Windows.Forms.Panel();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.txtOtherRalationship = new System.Windows.Forms.TextBox();
            this.rdoFather = new System.Windows.Forms.RadioButton();
            this.rdoMother = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGuardianContact = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentContact = new System.Windows.Forms.MaskedTextBox();
            this.TxtSchool = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.ucDateFilter = new StudentManager_Winforms.Controls.ucDateFilter();
            this.ccTxtClassNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.ccTxtStudentNo = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.btnOpenInsert = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlInsert.SuspendLayout();
            this.pnlGuardianRerationship.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInsert
            // 
            this.pnlInsert.Controls.Add(this.txtAge);
            this.pnlInsert.Controls.Add(this.ccTxtSpecialNote);
            this.pnlInsert.Controls.Add(this.dtpStartDate);
            this.pnlInsert.Controls.Add(this.pnlGuardianRerationship);
            this.pnlInsert.Controls.Add(this.label10);
            this.pnlInsert.Controls.Add(this.label8);
            this.pnlInsert.Controls.Add(this.txtGuardianContact);
            this.pnlInsert.Controls.Add(this.label9);
            this.pnlInsert.Controls.Add(this.txtStudentContact);
            this.pnlInsert.Controls.Add(this.TxtSchool);
            this.pnlInsert.Controls.Add(this.label6);
            this.pnlInsert.Controls.Add(this.label7);
            this.pnlInsert.Controls.Add(this.label4);
            this.pnlInsert.Controls.Add(this.txtName);
            this.pnlInsert.Controls.Add(this.label5);
            this.pnlInsert.Controls.Add(this.btnAdd);
            this.pnlInsert.Controls.Add(this.label1);
            this.pnlInsert.Location = new System.Drawing.Point(630, 2);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Size = new System.Drawing.Size(290, 419);
            this.pnlInsert.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(9, 112);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(103, 21);
            this.txtAge.TabIndex = 6;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // ccTxtSpecialNote
            // 
            this.ccTxtSpecialNote.Location = new System.Drawing.Point(9, 262);
            this.ccTxtSpecialNote.Multiline = true;
            this.ccTxtSpecialNote.Name = "ccTxtSpecialNote";
            this.ccTxtSpecialNote.PlaceHolder = "특이사항";
            this.ccTxtSpecialNote.Size = new System.Drawing.Size(275, 118);
            this.ccTxtSpecialNote.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(9, 220);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(103, 21);
            this.dtpStartDate.TabIndex = 9;
            // 
            // pnlGuardianRerationship
            // 
            this.pnlGuardianRerationship.Controls.Add(this.rdoOther);
            this.pnlGuardianRerationship.Controls.Add(this.txtOtherRalationship);
            this.pnlGuardianRerationship.Controls.Add(this.rdoFather);
            this.pnlGuardianRerationship.Controls.Add(this.rdoMother);
            this.pnlGuardianRerationship.Location = new System.Drawing.Point(152, 162);
            this.pnlGuardianRerationship.Name = "pnlGuardianRerationship";
            this.pnlGuardianRerationship.Size = new System.Drawing.Size(132, 79);
            this.pnlGuardianRerationship.TabIndex = 95;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(3, 48);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(47, 16);
            this.rdoOther.TabIndex = 20;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "기타";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // txtOtherRalationship
            // 
            this.txtOtherRalationship.Location = new System.Drawing.Point(56, 47);
            this.txtOtherRalationship.Name = "txtOtherRalationship";
            this.txtOtherRalationship.Size = new System.Drawing.Size(74, 21);
            this.txtOtherRalationship.TabIndex = 19;
            this.txtOtherRalationship.Visible = false;
            // 
            // rdoFather
            // 
            this.rdoFather.AutoSize = true;
            this.rdoFather.Location = new System.Drawing.Point(3, 26);
            this.rdoFather.Name = "rdoFather";
            this.rdoFather.Size = new System.Drawing.Size(35, 16);
            this.rdoFather.TabIndex = 17;
            this.rdoFather.TabStop = true;
            this.rdoFather.Text = "모";
            this.rdoFather.UseVisualStyleBackColor = true;
            this.rdoFather.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoMother
            // 
            this.rdoMother.AutoSize = true;
            this.rdoMother.Location = new System.Drawing.Point(3, 4);
            this.rdoMother.Name = "rdoMother";
            this.rdoMother.Size = new System.Drawing.Size(35, 16);
            this.rdoMother.TabIndex = 16;
            this.rdoMother.TabStop = true;
            this.rdoMother.Text = "부";
            this.rdoMother.UseVisualStyleBackColor = true;
            this.rdoMother.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(9, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 12);
            this.label10.TabIndex = 77;
            this.label10.Text = "등록일";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(150, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 12);
            this.label8.TabIndex = 94;
            this.label8.Text = "보호자 관계";
            // 
            // txtGuardianContact
            // 
            this.txtGuardianContact.BackColor = System.Drawing.SystemColors.Control;
            this.txtGuardianContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuardianContact.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGuardianContact.Location = new System.Drawing.Point(152, 62);
            this.txtGuardianContact.Mask = "000-9000-0000";
            this.txtGuardianContact.Name = "txtGuardianContact";
            this.txtGuardianContact.Size = new System.Drawing.Size(132, 14);
            this.txtGuardianContact.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(150, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 12);
            this.label9.TabIndex = 92;
            this.label9.Text = "보호자 연락처";
            // 
            // txtStudentContact
            // 
            this.txtStudentContact.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentContact.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentContact.Location = new System.Drawing.Point(152, 119);
            this.txtStudentContact.Mask = "000-9000-0000";
            this.txtStudentContact.Name = "txtStudentContact";
            this.txtStudentContact.Size = new System.Drawing.Size(132, 14);
            this.txtStudentContact.TabIndex = 7;
            // 
            // TxtSchool
            // 
            this.TxtSchool.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtSchool.Location = new System.Drawing.Point(9, 161);
            this.TxtSchool.Name = "TxtSchool";
            this.TxtSchool.Size = new System.Drawing.Size(103, 21);
            this.TxtSchool.TabIndex = 90;
            this.TxtSchool.TabStop = false;
            this.TxtSchool.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtSchool_MouseClick);
            this.TxtSchool.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSchool_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(7, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 89;
            this.label6.Text = "학교";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(150, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 88;
            this.label7.Text = "학생 연락처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 86;
            this.label4.Text = "나이";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(9, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(103, 21);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(7, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 84;
            this.label5.Text = "이름";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(209, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 82;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "학생";
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.ucDateFilter);
            this.pnlSelect.Controls.Add(this.ccTxtClassNo);
            this.pnlSelect.Controls.Add(this.ccTxtStudentNo);
            this.pnlSelect.Controls.Add(this.btnOpenInsert);
            this.pnlSelect.Controls.Add(this.dgvList);
            this.pnlSelect.Controls.Add(this.btnSearch);
            this.pnlSelect.Location = new System.Drawing.Point(2, 2);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(623, 419);
            this.pnlSelect.TabIndex = 5;
            // 
            // ucDateFilter
            // 
            this.ucDateFilter.EndDate = new System.DateTime(2022, 4, 24, 17, 20, 36, 666);
            this.ucDateFilter.Location = new System.Drawing.Point(279, 387);
            this.ucDateFilter.Name = "ucDateFilter";
            this.ucDateFilter.Size = new System.Drawing.Size(238, 22);
            this.ucDateFilter.StartDate = new System.DateTime(2022, 3, 24, 17, 20, 36, 666);
            this.ucDateFilter.TabIndex = 99;
            // 
            // ccTxtClassNo
            // 
            this.ccTxtClassNo.Location = new System.Drawing.Point(142, 388);
            this.ccTxtClassNo.Name = "ccTxtClassNo";
            this.ccTxtClassNo.PlaceHolder = "수업 번호 검색";
            this.ccTxtClassNo.Size = new System.Drawing.Size(100, 21);
            this.ccTxtClassNo.TabIndex = 98;
            // 
            // ccTxtStudentNo
            // 
            this.ccTxtStudentNo.Location = new System.Drawing.Point(3, 388);
            this.ccTxtStudentNo.Name = "ccTxtStudentNo";
            this.ccTxtStudentNo.PlaceHolder = "학생 번호 검색";
            this.ccTxtStudentNo.Size = new System.Drawing.Size(100, 21);
            this.ccTxtStudentNo.TabIndex = 97;
            // 
            // btnOpenInsert
            // 
            this.btnOpenInsert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpenInsert.Location = new System.Drawing.Point(570, 7);
            this.btnOpenInsert.Name = "btnOpenInsert";
            this.btnOpenInsert.Size = new System.Drawing.Size(45, 23);
            this.btnOpenInsert.TabIndex = 96;
            this.btnOpenInsert.Text = ">>";
            this.btnOpenInsert.UseVisualStyleBackColor = true;
            this.btnOpenInsert.Click += new System.EventHandler(this.btnOpenInsert_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 36);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(612, 344);
            this.dgvList.TabIndex = 94;
            this.dgvList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(540, 386);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 422);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.pnlInsert.ResumeLayout(false);
            this.pnlInsert.PerformLayout();
            this.pnlGuardianRerationship.ResumeLayout(false);
            this.pnlGuardianRerationship.PerformLayout();
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInsert;
        private System.Windows.Forms.Panel pnlGuardianRerationship;
        private System.Windows.Forms.TextBox txtOtherRalationship;
        private System.Windows.Forms.RadioButton rdoFather;
        private System.Windows.Forms.RadioButton rdoMother;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtGuardianContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtStudentContact;
        private System.Windows.Forms.TextBox TxtSchool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label10;
        private ccTextBoxPlaceHolder ccTxtSpecialNote;
        private System.Windows.Forms.Panel pnlSelect;
        private ccTextBoxPlaceHolder ccTxtClassNo;
        private ccTextBoxPlaceHolder ccTxtStudentNo;
        private System.Windows.Forms.Button btnOpenInsert;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoOther;
        private Controls.ucDateFilter ucDateFilter;
        private System.Windows.Forms.TextBox txtAge;
    }
}