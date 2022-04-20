namespace StudentManager_Winforms
{
    partial class frmFindPw
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
            this.pnlFindPw = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucInputEmail = new StudentManager_Winforms.Controls.ucInputEmail();
            this.ccTxtEmp_no = new StudentManager_Winforms.Controls.ccTextBoxNumber();
            this.pnlFindPw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFindPw
            // 
            this.pnlFindPw.Controls.Add(this.ucInputEmail);
            this.pnlFindPw.Controls.Add(this.ccTxtEmp_no);
            this.pnlFindPw.Controls.Add(this.lblMessage);
            this.pnlFindPw.Controls.Add(this.btnEmail);
            this.pnlFindPw.Controls.Add(this.btnCheck);
            this.pnlFindPw.Controls.Add(this.label3);
            this.pnlFindPw.Controls.Add(this.label2);
            this.pnlFindPw.Controls.Add(this.txtName);
            this.pnlFindPw.Controls.Add(this.label1);
            this.pnlFindPw.Location = new System.Drawing.Point(12, 12);
            this.pnlFindPw.Name = "pnlFindPw";
            this.pnlFindPw.Size = new System.Drawing.Size(304, 308);
            this.pnlFindPw.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(22, 251);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(255, 23);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEmail.Location = new System.Drawing.Point(121, 225);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "메일 인증";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheck.Location = new System.Drawing.Point(202, 225);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "이메일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "사번";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(24, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 21);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름";
            // 
            // ucInputEmail
            // 
            this.ucInputEmail.Location = new System.Drawing.Point(23, 179);
            this.ucInputEmail.Name = "ucInputEmail";
            this.ucInputEmail.Size = new System.Drawing.Size(254, 22);
            this.ucInputEmail.TabIndex = 2;
            // 
            // ccTxtEmp_no
            // 
            this.ccTxtEmp_no.Location = new System.Drawing.Point(23, 110);
            this.ccTxtEmp_no.Name = "ccTxtEmp_no";
            this.ccTxtEmp_no.Size = new System.Drawing.Size(254, 21);
            this.ccTxtEmp_no.TabIndex = 1;
            // 
            // frmFindPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 332);
            this.Controls.Add(this.pnlFindPw);
            this.Name = "frmFindPw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindPw";
            this.Load += new System.EventHandler(this.frmFindPw_Load);
            this.Resize += new System.EventHandler(this.frmFindPw_Resize);
            this.pnlFindPw.ResumeLayout(false);
            this.pnlFindPw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFindPw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblMessage;
        private Controls.ccTextBoxNumber ccTxtEmp_no;
        private Controls.ucInputEmail ucInputEmail;
    }
}