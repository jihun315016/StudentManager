
namespace StudentManager_Winforms
{
    partial class frmCourseDetail
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblCourseInfo = new System.Windows.Forms.Label();
            this.pnlEntire = new System.Windows.Forms.Panel();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblCourseNo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnApplyCourse = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlEntire.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(152, 53);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(330, 170);
            this.dgvList.TabIndex = 116;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(407, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 82;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentNo.Location = new System.Drawing.Point(14, 201);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(109, 22);
            this.txtStudentNo.TabIndex = 99;
            this.txtStudentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNo_KeyPress);
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCourseInfo.Location = new System.Drawing.Point(3, 0);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(449, 23);
            this.lblCourseInfo.TabIndex = 63;
            this.lblCourseInfo.Text = "[강사명] 수업명";
            // 
            // pnlEntire
            // 
            this.pnlEntire.Controls.Add(this.lblStudentName);
            this.pnlEntire.Controls.Add(this.lblCourseNo);
            this.pnlEntire.Controls.Add(this.label10);
            this.pnlEntire.Controls.Add(this.lblPayment);
            this.pnlEntire.Controls.Add(this.label9);
            this.pnlEntire.Controls.Add(this.btnApplyCourse);
            this.pnlEntire.Controls.Add(this.lblDate);
            this.pnlEntire.Controls.Add(this.dgvList);
            this.pnlEntire.Controls.Add(this.button3);
            this.pnlEntire.Controls.Add(this.txtStudentNo);
            this.pnlEntire.Controls.Add(this.label6);
            this.pnlEntire.Controls.Add(this.lblCourseInfo);
            this.pnlEntire.Location = new System.Drawing.Point(12, 12);
            this.pnlEntire.Name = "pnlEntire";
            this.pnlEntire.Size = new System.Drawing.Size(487, 257);
            this.pnlEntire.TabIndex = 4;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentName.Location = new System.Drawing.Point(14, 226);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(0, 12);
            this.lblStudentName.TabIndex = 131;
            // 
            // lblCourseNo
            // 
            this.lblCourseNo.AutoSize = true;
            this.lblCourseNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCourseNo.Location = new System.Drawing.Point(14, 74);
            this.lblCourseNo.Name = "lblCourseNo";
            this.lblCourseNo.Size = new System.Drawing.Size(80, 12);
            this.lblCourseNo.TabIndex = 130;
            this.lblCourseNo.Text = "수업 번호 값";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(14, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 129;
            this.label10.Text = "수업 번호";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPayment.Location = new System.Drawing.Point(14, 131);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(49, 12);
            this.lblPayment.TabIndex = 128;
            this.lblPayment.Text = "회비 값";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(14, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 127;
            this.label9.Text = "회비";
            // 
            // btnApplyCourse
            // 
            this.btnApplyCourse.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnApplyCourse.Location = new System.Drawing.Point(48, 229);
            this.btnApplyCourse.Name = "btnApplyCourse";
            this.btnApplyCourse.Size = new System.Drawing.Size(75, 23);
            this.btnApplyCourse.TabIndex = 126;
            this.btnApplyCourse.Text = "수강 신청";
            this.btnApplyCourse.UseVisualStyleBackColor = true;
            this.btnApplyCourse.Click += new System.EventHandler(this.btnApplyCourse_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(150, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(126, 12);
            this.lblDate.TabIndex = 123;
            this.lblDate.Text = "개강 날짜 ~ 종강 날짜";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(14, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 98;
            this.label6.Text = "학생 번호";
            // 
            // frmCourseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 273);
            this.Controls.Add(this.pnlEntire);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourseDetail";
            this.Text = "frmCourseDetail";
            this.Load += new System.EventHandler(this.frmCourseDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlEntire.ResumeLayout(false);
            this.pnlEntire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblCourseInfo;
        private System.Windows.Forms.Panel pnlEntire;
        private System.Windows.Forms.Button btnApplyCourse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCourseNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStudentName;
    }
}