namespace StudentManager_Winforms
{
    partial class frmManager
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
            this.btnStudent = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMyPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStudent.Location = new System.Drawing.Point(12, 12);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(85, 30);
            this.btnStudent.TabIndex = 7;
            this.btnStudent.Text = "학생";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Employee.Location = new System.Drawing.Point(103, 12);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(85, 30);
            this.btn_Employee.TabIndex = 9;
            this.btn_Employee.Text = "직원";
            this.btn_Employee.UseVisualStyleBackColor = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPayment.Location = new System.Drawing.Point(285, 12);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(85, 30);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "결제";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCourse.Location = new System.Drawing.Point(194, 12);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(85, 30);
            this.btnCourse.TabIndex = 15;
            this.btnCourse.Text = "수업";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserInfo.Location = new System.Drawing.Point(897, 4);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(200, 40);
            this.lblUserInfo.TabIndex = 18;
            this.lblUserInfo.Text = "[직무] 강지훈";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(1179, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 27);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMyPage
            // 
            this.btnMyPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMyPage.Location = new System.Drawing.Point(1103, 12);
            this.btnMyPage.Name = "btnMyPage";
            this.btnMyPage.Size = new System.Drawing.Size(70, 27);
            this.btnMyPage.TabIndex = 21;
            this.btnMyPage.Text = "내 정보";
            this.btnMyPage.UseVisualStyleBackColor = true;
            this.btnMyPage.Click += new System.EventHandler(this.btnMyPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.lblUserInfo);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnCourse);
            this.panel2.Controls.Add(this.btnMyPage);
            this.panel2.Controls.Add(this.btn_Employee);
            this.panel2.Controls.Add(this.btnStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 50);
            this.panel2.TabIndex = 22;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 703);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메뉴";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMyPage;
        private System.Windows.Forms.Panel panel2;
    }
}