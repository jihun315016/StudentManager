﻿
namespace StudentManager_Winforms
{
    partial class frmPayment
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pnlEntire = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.pnlEntire.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 43;
            this.label3.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(663, 515);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(107, 21);
            this.dateTimePicker2.TabIndex = 42;
            // 
            // pnlEntire
            // 
            this.pnlEntire.Controls.Add(this.panel2);
            this.pnlEntire.Controls.Add(this.panel4);
            this.pnlEntire.Location = new System.Drawing.Point(16, 12);
            this.pnlEntire.Name = "pnlEntire";
            this.pnlEntire.Size = new System.Drawing.Size(1153, 587);
            this.pnlEntire.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtStudentNo);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtClassNo);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(370, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 581);
            this.panel2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(663, 476);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 21);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(663, 369);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(107, 21);
            this.txtStudentNo.TabIndex = 40;
            this.txtStudentNo.Enter += new System.EventHandler(this.txtStudentNo_Enter);
            this.txtStudentNo.Leave += new System.EventHandler(this.txtStudentNo_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(695, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtClassNo
            // 
            this.txtClassNo.Location = new System.Drawing.Point(663, 421);
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.Size = new System.Drawing.Size(107, 21);
            this.txtClassNo.TabIndex = 38;
            this.txtClassNo.Enter += new System.EventHandler(this.txtClassNo_Enter);
            this.txtClassNo.Leave += new System.EventHandler(this.txtClassNo_Leave);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 542);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "결제";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(226, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 82;
            this.button3.Text = "등록";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(31, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "학생 번호";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(34, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(31, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "수업 번호";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(34, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(233, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "학생 이름";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(233, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "수업 이름";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(233, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "담당 강사";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker3);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 581);
            this.panel4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(34, 320);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 22);
            this.textBox3.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(31, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "결제 금액";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(199, 321);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(102, 21);
            this.dateTimePicker3.TabIndex = 103;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.pnlEntire);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.Resize += new System.EventHandler(this.frmPayment_Resize);
            this.pnlEntire.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel pnlEntire;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}