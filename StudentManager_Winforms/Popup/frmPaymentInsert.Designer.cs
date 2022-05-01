namespace StudentManager_Winforms
{
    partial class frmPaymentInsert
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtCourseNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(15, 214);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(102, 21);
            this.dtpDate.TabIndex = 103;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmpName.Location = new System.Drawing.Point(123, 92);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(53, 11);
            this.lblEmpName.TabIndex = 100;
            this.lblEmpName.Text = "담당 강사";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCourseName.Location = new System.Drawing.Point(13, 106);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(53, 11);
            this.lblCourseName.TabIndex = 99;
            this.lblCourseName.Text = "수업 이름";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentName.Location = new System.Drawing.Point(123, 35);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(126, 11);
            this.lblStudentName.TabIndex = 98;
            this.lblStudentName.Text = "잘못된 학생 번호입니다.";
            // 
            // txtCourseNo
            // 
            this.txtCourseNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCourseNo.Location = new System.Drawing.Point(15, 82);
            this.txtCourseNo.Name = "txtCourseNo";
            this.txtCourseNo.Size = new System.Drawing.Size(102, 21);
            this.txtCourseNo.TabIndex = 1;
            this.txtCourseNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumber_KeyPress);
            this.txtCourseNo.Leave += new System.EventHandler(this.txtCourseNo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 96;
            this.label4.Text = "수업 번호";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentNo.Location = new System.Drawing.Point(15, 25);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(102, 21);
            this.txtStudentNo.TabIndex = 0;
            this.txtStudentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumber_KeyPress);
            this.txtStudentNo.Leave += new System.EventHandler(this.txtStudentNo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 94;
            this.label5.Text = "학생 번호";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(194, 212);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(55, 23);
            this.btnInsert.TabIndex = 82;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 104;
            this.label1.Text = "결제 날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 105;
            this.label2.Text = "결제 금액";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoney.Location = new System.Drawing.Point(16, 156);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(102, 21);
            this.txtMoney.TabIndex = 2;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumber_KeyPress);
            // 
            // frmPaymentInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCourseNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentInsert";
            this.Text = "frmPaymentInsert";
            this.Load += new System.EventHandler(this.frmPaymentInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtCourseNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoney;
    }
}