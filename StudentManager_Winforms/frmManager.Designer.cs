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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.학생ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.학생ToolStripMenuItem,
            this.직원ToolStripMenuItem,
            this.출석ToolStripMenuItem,
            this.결제ToolStripMenuItem,
            this.수상ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 학생ToolStripMenuItem
            // 
            this.학생ToolStripMenuItem.Name = "학생ToolStripMenuItem";
            this.학생ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.학생ToolStripMenuItem.Text = "학생";
            this.학생ToolStripMenuItem.Click += new System.EventHandler(this.학생ToolStripMenuItem_Click);
            // 
            // 직원ToolStripMenuItem
            // 
            this.직원ToolStripMenuItem.Name = "직원ToolStripMenuItem";
            this.직원ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.직원ToolStripMenuItem.Text = "직원";
            this.직원ToolStripMenuItem.Click += new System.EventHandler(this.직원ToolStripMenuItem_Click);
            // 
            // 출석ToolStripMenuItem
            // 
            this.출석ToolStripMenuItem.Name = "출석ToolStripMenuItem";
            this.출석ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.출석ToolStripMenuItem.Text = "출석";
            this.출석ToolStripMenuItem.Click += new System.EventHandler(this.출석ToolStripMenuItem_Click);
            // 
            // 결제ToolStripMenuItem
            // 
            this.결제ToolStripMenuItem.Name = "결제ToolStripMenuItem";
            this.결제ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.결제ToolStripMenuItem.Text = "결제";
            this.결제ToolStripMenuItem.Click += new System.EventHandler(this.결제ToolStripMenuItem_Click);
            // 
            // 수상ToolStripMenuItem
            // 
            this.수상ToolStripMenuItem.Name = "수상ToolStripMenuItem";
            this.수상ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.수상ToolStripMenuItem.Text = "수상";
            this.수상ToolStripMenuItem.Click += new System.EventHandler(this.수상ToolStripMenuItem_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 학생ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수상ToolStripMenuItem;
    }
}