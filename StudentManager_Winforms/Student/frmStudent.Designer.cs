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
            this.components = new System.ComponentModel.Container();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pnlGuardianRerationship = new System.Windows.Forms.Panel();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoMother = new System.Windows.Forms.RadioButton();
            this.txtOtherRalationship = new System.Windows.Forms.TextBox();
            this.rdoFather = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGuardianContact = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentContact = new System.Windows.Forms.MaskedTextBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkStop = new System.Windows.Forms.CheckBox();
            this.btnOpenInsert = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cmsSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReJoin = new System.Windows.Forms.ToolStripMenuItem();
            this.ccTxtSpecialNote = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.ucDateFilter = new StudentManager_Winforms.Controls.ucDateFilter();
            this.ccTxtStudentName = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.pnlGuardianRerationship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmsSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(744, 103);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(103, 21);
            this.txtAge.TabIndex = 6;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(744, 211);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(103, 21);
            this.dtpStartDate.TabIndex = 9;
            // 
            // pnlGuardianRerationship
            // 
            this.pnlGuardianRerationship.Controls.Add(this.rdoOther);
            this.pnlGuardianRerationship.Controls.Add(this.label8);
            this.pnlGuardianRerationship.Controls.Add(this.rdoMother);
            this.pnlGuardianRerationship.Controls.Add(this.txtOtherRalationship);
            this.pnlGuardianRerationship.Controls.Add(this.rdoFather);
            this.pnlGuardianRerationship.Location = new System.Drawing.Point(887, 138);
            this.pnlGuardianRerationship.Name = "pnlGuardianRerationship";
            this.pnlGuardianRerationship.Size = new System.Drawing.Size(120, 94);
            this.pnlGuardianRerationship.TabIndex = 95;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(3, 63);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(47, 16);
            this.rdoOther.TabIndex = 20;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "기타";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdoOther_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(-2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 94;
            this.label8.Text = "보호자 관계";
            // 
            // rdoMother
            // 
            this.rdoMother.AutoSize = true;
            this.rdoMother.Location = new System.Drawing.Point(3, 19);
            this.rdoMother.Name = "rdoMother";
            this.rdoMother.Size = new System.Drawing.Size(35, 16);
            this.rdoMother.TabIndex = 16;
            this.rdoMother.TabStop = true;
            this.rdoMother.Text = "부";
            this.rdoMother.UseVisualStyleBackColor = true;
            // 
            // txtOtherRalationship
            // 
            this.txtOtherRalationship.Location = new System.Drawing.Point(56, 62);
            this.txtOtherRalationship.Name = "txtOtherRalationship";
            this.txtOtherRalationship.Size = new System.Drawing.Size(60, 21);
            this.txtOtherRalationship.TabIndex = 19;
            this.txtOtherRalationship.Visible = false;
            // 
            // rdoFather
            // 
            this.rdoFather.AutoSize = true;
            this.rdoFather.Location = new System.Drawing.Point(3, 41);
            this.rdoFather.Name = "rdoFather";
            this.rdoFather.Size = new System.Drawing.Size(35, 16);
            this.rdoFather.TabIndex = 17;
            this.rdoFather.TabStop = true;
            this.rdoFather.Text = "모";
            this.rdoFather.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(744, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 77;
            this.label10.Text = "등록일";
            // 
            // txtGuardianContact
            // 
            this.txtGuardianContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuardianContact.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGuardianContact.Location = new System.Drawing.Point(887, 103);
            this.txtGuardianContact.Mask = "000-9000-0000";
            this.txtGuardianContact.Name = "txtGuardianContact";
            this.txtGuardianContact.Size = new System.Drawing.Size(86, 21);
            this.txtGuardianContact.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(885, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 12);
            this.label9.TabIndex = 92;
            this.label9.Text = "보호자 연락처";
            // 
            // txtStudentContact
            // 
            this.txtStudentContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtStudentContact.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentContact.Location = new System.Drawing.Point(887, 53);
            this.txtStudentContact.Mask = "000-9000-0000";
            this.txtStudentContact.Name = "txtStudentContact";
            this.txtStudentContact.Size = new System.Drawing.Size(86, 21);
            this.txtStudentContact.TabIndex = 7;
            // 
            // txtSchool
            // 
            this.txtSchool.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSchool.Location = new System.Drawing.Point(744, 152);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(103, 21);
            this.txtSchool.TabIndex = 90;
            this.txtSchool.TabStop = false;
            this.txtSchool.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSchool_MouseClick);
            this.txtSchool.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSchool_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(742, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 89;
            this.label6.Text = "학교";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(885, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 88;
            this.label7.Text = "학생 연락처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(742, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 86;
            this.label4.Text = "나이";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(744, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(103, 21);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(742, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 84;
            this.label5.Text = "이름";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(952, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 82;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "학생";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(667, 356);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSearch.TabIndex = 103;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchStu_Click);
            // 
            // chkStop
            // 
            this.chkStop.AutoSize = true;
            this.chkStop.Location = new System.Drawing.Point(588, 13);
            this.chkStop.Name = "chkStop";
            this.chkStop.Size = new System.Drawing.Size(88, 16);
            this.chkStop.TabIndex = 102;
            this.chkStop.Text = "그만둔 학생";
            this.chkStop.UseVisualStyleBackColor = true;
            this.chkStop.CheckedChanged += new System.EventHandler(this.chkStop_CheckedChanged);
            // 
            // btnOpenInsert
            // 
            this.btnOpenInsert.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpenInsert.Location = new System.Drawing.Point(682, 9);
            this.btnOpenInsert.Name = "btnOpenInsert";
            this.btnOpenInsert.Size = new System.Drawing.Size(45, 23);
            this.btnOpenInsert.TabIndex = 96;
            this.btnOpenInsert.Text = ">>";
            this.btnOpenInsert.UseVisualStyleBackColor = true;
            this.btnOpenInsert.Click += new System.EventHandler(this.btnOpenInsert_Click);
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(15, 38);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(710, 310);
            this.dgvList.TabIndex = 94;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            // 
            // cmsSetting
            // 
            this.cmsSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStop,
            this.tsmReJoin});
            this.cmsSetting.Name = "contextMenuStrip1";
            this.cmsSetting.Size = new System.Drawing.Size(111, 48);
            // 
            // tsmStop
            // 
            this.tsmStop.Name = "tsmStop";
            this.tsmStop.Size = new System.Drawing.Size(110, 22);
            this.tsmStop.Text = "퇴원";
            this.tsmStop.Click += new System.EventHandler(this.tsmStop_Click);
            // 
            // tsmReJoin
            // 
            this.tsmReJoin.Name = "tsmReJoin";
            this.tsmReJoin.Size = new System.Drawing.Size(110, 22);
            this.tsmReJoin.Text = "재등록";
            this.tsmReJoin.Click += new System.EventHandler(this.tsmReJoin_Click);
            // 
            // ccTxtSpecialNote
            // 
            this.ccTxtSpecialNote.Location = new System.Drawing.Point(744, 253);
            this.ccTxtSpecialNote.Multiline = true;
            this.ccTxtSpecialNote.Name = "ccTxtSpecialNote";
            this.ccTxtSpecialNote.PlaceHolder = "특이사항";
            this.ccTxtSpecialNote.Size = new System.Drawing.Size(263, 84);
            this.ccTxtSpecialNote.TabIndex = 10;
            // 
            // ucDateFilter
            // 
            this.ucDateFilter.EndDate = new System.DateTime(2022, 5, 11, 14, 23, 0, 662);
            this.ucDateFilter.Location = new System.Drawing.Point(121, 356);
            this.ucDateFilter.Name = "ucDateFilter";
            this.ucDateFilter.Size = new System.Drawing.Size(238, 22);
            this.ucDateFilter.StartDate = new System.DateTime(2022, 4, 11, 14, 23, 0, 662);
            this.ucDateFilter.TabIndex = 99;
            // 
            // ccTxtStudentName
            // 
            this.ccTxtStudentName.Location = new System.Drawing.Point(15, 356);
            this.ccTxtStudentName.Name = "ccTxtStudentName";
            this.ccTxtStudentName.PlaceHolder = "학생 검색";
            this.ccTxtStudentName.Size = new System.Drawing.Size(100, 21);
            this.ccTxtStudentName.TabIndex = 97;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ccTxtSpecialNote);
            this.Controls.Add(this.ucDateFilter);
            this.Controls.Add(this.chkStop);
            this.Controls.Add(this.ccTxtStudentName);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnOpenInsert);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.pnlGuardianRerationship);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGuardianContact);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentContact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudent";
            this.Text = "학생";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.pnlGuardianRerationship.ResumeLayout(false);
            this.pnlGuardianRerationship.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmsSetting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlGuardianRerationship;
        private System.Windows.Forms.TextBox txtOtherRalationship;
        private System.Windows.Forms.RadioButton rdoFather;
        private System.Windows.Forms.RadioButton rdoMother;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtGuardianContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtStudentContact;
        private System.Windows.Forms.TextBox txtSchool;
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
        private ccTextBoxPlaceHolder ccTxtStudentName;
        private System.Windows.Forms.Button btnOpenInsert;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.RadioButton rdoOther;
        private Controls.ucDateFilter ucDateFilter;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.CheckBox chkStop;
        private System.Windows.Forms.ContextMenuStrip cmsSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmStop;
        private System.Windows.Forms.ToolStripMenuItem tsmReJoin;
        private System.Windows.Forms.Button btnSearch;
    }
}