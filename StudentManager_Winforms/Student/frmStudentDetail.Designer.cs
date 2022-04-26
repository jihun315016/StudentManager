namespace StudentManager_Winforms
{
    partial class frmStudentDetail
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
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.pnlEntire = new System.Windows.Forms.Panel();
            this.pnlEndReason = new System.Windows.Forms.Panel();
            this.txtEndReason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGuardianRerationship = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabContest = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlGuardianRerationship = new System.Windows.Forms.Panel();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.txtOtherRalationship = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.rdoFather = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoMother = new System.Windows.Forms.RadioButton();
            this.txtGuardianContact = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentContact = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ccTxtSpecialNote = new StudentManager_Winforms.ccTextBoxPlaceHolder();
            this.pnlEntire.SuspendLayout();
            this.pnlEndReason.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabContest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.pnlGuardianRerationship.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEditInfo.Location = new System.Drawing.Point(691, 473);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(75, 23);
            this.btnEditInfo.TabIndex = 82;
            this.btnEditInfo.Text = "수정";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentInfo.Location = new System.Drawing.Point(3, 0);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(161, 23);
            this.lblStudentInfo.TabIndex = 63;
            this.lblStudentInfo.Text = "[학생] 학생명";
            // 
            // pnlEntire
            // 
            this.pnlEntire.Controls.Add(this.pnlEndReason);
            this.pnlEntire.Controls.Add(this.ccTxtSpecialNote);
            this.pnlEntire.Controls.Add(this.lblGuardianRerationship);
            this.pnlEntire.Controls.Add(this.label9);
            this.pnlEntire.Controls.Add(this.txtStudentNo);
            this.pnlEntire.Controls.Add(this.dtpDate);
            this.pnlEntire.Controls.Add(this.btnCancel);
            this.pnlEntire.Controls.Add(this.btnEditInfo);
            this.pnlEntire.Controls.Add(this.tabControl1);
            this.pnlEntire.Controls.Add(this.lblDate);
            this.pnlEntire.Controls.Add(this.pnlGuardianRerationship);
            this.pnlEntire.Controls.Add(this.txtGuardianContact);
            this.pnlEntire.Controls.Add(this.label4);
            this.pnlEntire.Controls.Add(this.txtStudentContact);
            this.pnlEntire.Controls.Add(this.label7);
            this.pnlEntire.Controls.Add(this.label3);
            this.pnlEntire.Controls.Add(this.txtSchool);
            this.pnlEntire.Controls.Add(this.label2);
            this.pnlEntire.Controls.Add(this.txtAge);
            this.pnlEntire.Controls.Add(this.lblStudentInfo);
            this.pnlEntire.Controls.Add(this.label5);
            this.pnlEntire.Controls.Add(this.txtName);
            this.pnlEntire.Location = new System.Drawing.Point(16, 18);
            this.pnlEntire.Name = "pnlEntire";
            this.pnlEntire.Size = new System.Drawing.Size(774, 501);
            this.pnlEntire.TabIndex = 2;
            // 
            // pnlEndReason
            // 
            this.pnlEndReason.Controls.Add(this.txtEndReason);
            this.pnlEndReason.Controls.Add(this.label1);
            this.pnlEndReason.Location = new System.Drawing.Point(549, 116);
            this.pnlEndReason.Name = "pnlEndReason";
            this.pnlEndReason.Size = new System.Drawing.Size(196, 92);
            this.pnlEndReason.TabIndex = 108;
            // 
            // txtEndReason
            // 
            this.txtEndReason.Location = new System.Drawing.Point(6, 16);
            this.txtEndReason.Name = "txtEndReason";
            this.txtEndReason.Size = new System.Drawing.Size(187, 21);
            this.txtEndReason.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "그만둔 사유";
            // 
            // lblGuardianRerationship
            // 
            this.lblGuardianRerationship.AutoSize = true;
            this.lblGuardianRerationship.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGuardianRerationship.Location = new System.Drawing.Point(661, 72);
            this.lblGuardianRerationship.Name = "lblGuardianRerationship";
            this.lblGuardianRerationship.Size = new System.Drawing.Size(49, 13);
            this.lblGuardianRerationship.TabIndex = 106;
            this.lblGuardianRerationship.Text = "보호자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(29, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "학생 번호";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentNo.Location = new System.Drawing.Point(32, 69);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(89, 22);
            this.txtStudentNo.TabIndex = 105;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(379, 132);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(95, 21);
            this.dtpDate.TabIndex = 103;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(610, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 102;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAttendance);
            this.tabControl1.Controls.Add(this.tabPayment);
            this.tabControl1.Controls.Add(this.tabContest);
            this.tabControl1.Location = new System.Drawing.Point(32, 201);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 276);
            this.tabControl1.TabIndex = 100;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.button2);
            this.tabAttendance.Controls.Add(this.dataGridView1);
            this.tabAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendance.Size = new System.Drawing.Size(503, 250);
            this.tabAttendance.TabIndex = 0;
            this.tabAttendance.Text = "출석";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(422, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 103;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(491, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.button4);
            this.tabPayment.Controls.Add(this.dataGridView2);
            this.tabPayment.Location = new System.Drawing.Point(4, 22);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(503, 250);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.Text = "결제";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(422, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 105;
            this.button4.Text = "조회";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(491, 209);
            this.dataGridView2.TabIndex = 104;
            // 
            // tabContest
            // 
            this.tabContest.Controls.Add(this.button5);
            this.tabContest.Controls.Add(this.dataGridView3);
            this.tabContest.Location = new System.Drawing.Point(4, 22);
            this.tabContest.Name = "tabContest";
            this.tabContest.Size = new System.Drawing.Size(503, 250);
            this.tabContest.TabIndex = 2;
            this.tabContest.Text = "수상";
            this.tabContest.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(425, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 107;
            this.button5.Text = "조회";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(9, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(491, 209);
            this.dataGridView3.TabIndex = 106;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(376, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 13);
            this.lblDate.TabIndex = 98;
            this.lblDate.Text = "등록일";
            // 
            // pnlGuardianRerationship
            // 
            this.pnlGuardianRerationship.Controls.Add(this.rdoNone);
            this.pnlGuardianRerationship.Controls.Add(this.txtOtherRalationship);
            this.pnlGuardianRerationship.Controls.Add(this.lable1);
            this.pnlGuardianRerationship.Controls.Add(this.rdoFather);
            this.pnlGuardianRerationship.Controls.Add(this.rdoOther);
            this.pnlGuardianRerationship.Controls.Add(this.rdoMother);
            this.pnlGuardianRerationship.Location = new System.Drawing.Point(549, 116);
            this.pnlGuardianRerationship.Name = "pnlGuardianRerationship";
            this.pnlGuardianRerationship.Size = new System.Drawing.Size(161, 92);
            this.pnlGuardianRerationship.TabIndex = 97;
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Location = new System.Drawing.Point(6, 43);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(87, 16);
            this.rdoNone.TabIndex = 97;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "보호자 없음";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // txtOtherRalationship
            // 
            this.txtOtherRalationship.Location = new System.Drawing.Point(59, 64);
            this.txtOtherRalationship.Name = "txtOtherRalationship";
            this.txtOtherRalationship.Size = new System.Drawing.Size(74, 21);
            this.txtOtherRalationship.TabIndex = 19;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lable1.Location = new System.Drawing.Point(3, 5);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(82, 13);
            this.lable1.TabIndex = 96;
            this.lable1.Text = "보호자 관계";
            // 
            // rdoFather
            // 
            this.rdoFather.AutoSize = true;
            this.rdoFather.Location = new System.Drawing.Point(6, 21);
            this.rdoFather.Name = "rdoFather";
            this.rdoFather.Size = new System.Drawing.Size(35, 16);
            this.rdoFather.TabIndex = 16;
            this.rdoFather.TabStop = true;
            this.rdoFather.Text = "부";
            this.rdoFather.UseVisualStyleBackColor = true;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(6, 65);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(47, 16);
            this.rdoOther.TabIndex = 18;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "기타";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoMother
            // 
            this.rdoMother.AutoSize = true;
            this.rdoMother.Location = new System.Drawing.Point(84, 21);
            this.rdoMother.Name = "rdoMother";
            this.rdoMother.Size = new System.Drawing.Size(35, 16);
            this.rdoMother.TabIndex = 17;
            this.rdoMother.TabStop = true;
            this.rdoMother.Text = "모";
            this.rdoMother.UseVisualStyleBackColor = true;
            // 
            // txtGuardianContact
            // 
            this.txtGuardianContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuardianContact.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGuardianContact.Location = new System.Drawing.Point(549, 69);
            this.txtGuardianContact.Mask = "000-9000-0000";
            this.txtGuardianContact.Name = "txtGuardianContact";
            this.txtGuardianContact.Size = new System.Drawing.Size(106, 22);
            this.txtGuardianContact.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(546, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "보호자 연락처";
            // 
            // txtStudentContact
            // 
            this.txtStudentContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtStudentContact.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentContact.Location = new System.Drawing.Point(379, 69);
            this.txtStudentContact.Mask = "000-9000-0000";
            this.txtStudentContact.Name = "txtStudentContact";
            this.txtStudentContact.Size = new System.Drawing.Size(105, 22);
            this.txtStudentContact.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(376, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "학생 연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(185, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "학교";
            // 
            // txtSchool
            // 
            this.txtSchool.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSchool.Location = new System.Drawing.Point(188, 132);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(132, 22);
            this.txtSchool.TabIndex = 89;
            this.txtSchool.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSchool_MouseClick);
            this.txtSchool.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSchool_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "나이";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAge.Location = new System.Drawing.Point(32, 132);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(89, 22);
            this.txtAge.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(185, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "이름";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(188, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 85;
            // 
            // ccTxtSpecialNote
            // 
            this.ccTxtSpecialNote.Location = new System.Drawing.Point(549, 223);
            this.ccTxtSpecialNote.Multiline = true;
            this.ccTxtSpecialNote.Name = "ccTxtSpecialNote";
            this.ccTxtSpecialNote.PlaceHolder = "특이사항";
            this.ccTxtSpecialNote.Size = new System.Drawing.Size(217, 215);
            this.ccTxtSpecialNote.TabIndex = 107;
            // 
            // frmStudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 528);
            this.Controls.Add(this.pnlEntire);
            this.Name = "frmStudentDetail";
            this.Text = "frmStudentDetail";
            this.Load += new System.EventHandler(this.frmStudentDetail_Load);
            this.pnlEntire.ResumeLayout(false);
            this.pnlEntire.PerformLayout();
            this.pnlEndReason.ResumeLayout(false);
            this.pnlEndReason.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabContest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.pnlGuardianRerationship.ResumeLayout(false);
            this.pnlGuardianRerationship.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Panel pnlEntire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.MaskedTextBox txtGuardianContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtStudentContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlGuardianRerationship;
        private System.Windows.Forms.TextBox txtOtherRalationship;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoMother;
        private System.Windows.Forms.RadioButton rdoFather;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.TabPage tabContest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGuardianRerationship;
        private ccTextBoxPlaceHolder ccTxtSpecialNote;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.Panel pnlEndReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndReason;
    }
}