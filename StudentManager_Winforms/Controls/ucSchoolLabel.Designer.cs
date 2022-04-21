
namespace StudentManager_Winforms.Controls
{
    partial class ucSchoolLabel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.btnSchool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSchoolName.Location = new System.Drawing.Point(3, 3);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(226, 23);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "학교명";
            this.lblSchoolName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSchoolName.Click += new System.EventHandler(this.lblSchoolName_Click);
            // 
            // btnSchool
            // 
            this.btnSchool.Location = new System.Drawing.Point(235, 3);
            this.btnSchool.Name = "btnSchool";
            this.btnSchool.Size = new System.Drawing.Size(58, 23);
            this.btnSchool.TabIndex = 1;
            this.btnSchool.Text = "검색";
            this.btnSchool.UseVisualStyleBackColor = true;
            this.btnSchool.Click += new System.EventHandler(this.btnSchool_Click);
            // 
            // ucSchoolLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSchool);
            this.Controls.Add(this.lblSchoolName);
            this.Name = "ucSchoolLabel";
            this.Size = new System.Drawing.Size(294, 28);
            this.Load += new System.EventHandler(this.ucSchoolLabel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Button btnSchool;
    }
}
