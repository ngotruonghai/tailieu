namespace haingo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.raddem = new System.Windows.Forms.CheckBox();
            this.radtong = new System.Windows.Forms.CheckBox();
            this.radrd = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtketquac = new System.Windows.Forms.TextBox();
            this.txtketquab = new System.Windows.Forms.TextBox();
            this.txtketquaa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập số";
            // 
            // txtsoa
            // 
            this.txtsoa.Location = new System.Drawing.Point(55, 12);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(69, 20);
            this.txtsoa.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtsoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bài tập";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 6;
            this.button3.Text = "thoat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // raddem
            // 
            this.raddem.AutoSize = true;
            this.raddem.Location = new System.Drawing.Point(258, 107);
            this.raddem.Name = "raddem";
            this.raddem.Size = new System.Drawing.Size(47, 17);
            this.raddem.TabIndex = 4;
            this.raddem.Text = "đếm";
            this.raddem.UseVisualStyleBackColor = true;
            // 
            // radtong
            // 
            this.radtong.AutoSize = true;
            this.radtong.Location = new System.Drawing.Point(258, 70);
            this.radtong.Name = "radtong";
            this.radtong.Size = new System.Drawing.Size(47, 17);
            this.radtong.TabIndex = 3;
            this.radtong.Text = "tổng";
            this.radtong.UseVisualStyleBackColor = true;
            // 
            // radrd
            // 
            this.radrd.AutoSize = true;
            this.radrd.Location = new System.Drawing.Point(258, 34);
            this.radrd.Name = "radrd";
            this.radrd.Size = new System.Drawing.Size(61, 17);
            this.radrd.TabIndex = 2;
            this.radrd.Text = "random";
            this.radrd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.txtketquac);
            this.groupBox2.Controls.Add(this.txtketquab);
            this.groupBox2.Controls.Add(this.raddem);
            this.groupBox2.Controls.Add(this.txtketquaa);
            this.groupBox2.Controls.Add(this.radtong);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.radrd);
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 288);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "kết quà";
            // 
            // txtketquac
            // 
            this.txtketquac.Location = new System.Drawing.Point(97, 107);
            this.txtketquac.Name = "txtketquac";
            this.txtketquac.Size = new System.Drawing.Size(126, 20);
            this.txtketquac.TabIndex = 3;
            // 
            // txtketquab
            // 
            this.txtketquab.Location = new System.Drawing.Point(97, 67);
            this.txtketquab.Name = "txtketquab";
            this.txtketquab.Size = new System.Drawing.Size(126, 20);
            this.txtketquab.TabIndex = 2;
            // 
            // txtketquaa
            // 
            this.txtketquaa.Location = new System.Drawing.Point(97, 25);
            this.txtketquaa.Name = "txtketquaa";
            this.txtketquaa.Size = new System.Drawing.Size(126, 20);
            this.txtketquaa.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "thực hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 319);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox radtong;
        private System.Windows.Forms.CheckBox radrd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtketquaa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtketquab;
        private System.Windows.Forms.CheckBox raddem;
        private System.Windows.Forms.TextBox txtketquac;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

