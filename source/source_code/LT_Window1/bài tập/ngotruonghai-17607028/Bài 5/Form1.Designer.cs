namespace Bài_5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_chieucao = new System.Windows.Forms.TextBox();
            this.txt_cannag = new System.Windows.Forms.TextBox();
            this.lb_kq = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.rd_nu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(155, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công thức tính cân nặng chuẩn\r\n\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rd_nu);
            this.groupBox1.Controls.Add(this.rd_nam);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lb_kq);
            this.groupBox1.Controls.Add(this.txt_cannag);
            this.groupBox1.Controls.Add(this.txt_chieucao);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bài 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chiều cao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cân nặng";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(161, 71);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(411, 38);
            this.txt_name.TabIndex = 4;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapchu);
            // 
            // txt_chieucao
            // 
            this.txt_chieucao.Location = new System.Drawing.Point(161, 125);
            this.txt_chieucao.Name = "txt_chieucao";
            this.txt_chieucao.Size = new System.Drawing.Size(192, 38);
            this.txt_chieucao.TabIndex = 5;
            this.txt_chieucao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapso);
            // 
            // txt_cannag
            // 
            this.txt_cannag.Location = new System.Drawing.Point(161, 181);
            this.txt_cannag.Name = "txt_cannag";
            this.txt_cannag.Size = new System.Drawing.Size(192, 38);
            this.txt_cannag.TabIndex = 6;
            this.txt_cannag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapso);
            // 
            // lb_kq
            // 
            this.lb_kq.AutoSize = true;
            this.lb_kq.Location = new System.Drawing.Point(6, 287);
            this.lb_kq.Name = "lb_kq";
            this.lb_kq.Size = new System.Drawing.Size(22, 31);
            this.lb_kq.TabIndex = 7;
            this.lb_kq.Text = ".";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nam.Location = new System.Drawing.Point(161, 239);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(55, 21);
            this.rd_nam.TabIndex = 9;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Nam\r\n";
            this.rd_nam.UseVisualStyleBackColor = true;
            this.rd_nam.CheckedChanged += new System.EventHandler(this.rd_nam_CheckedChanged);
            // 
            // rd_nu
            // 
            this.rd_nu.AutoSize = true;
            this.rd_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nu.Location = new System.Drawing.Point(274, 239);
            this.rd_nu.Name = "rd_nu";
            this.rd_nu.Size = new System.Drawing.Size(44, 21);
            this.rd_nu.TabIndex = 10;
            this.rd_nu.TabStop = true;
            this.rd_nu.Text = "Nu";
            this.rd_nu.UseVisualStyleBackColor = true;
            this.rd_nu.CheckedChanged += new System.EventHandler(this.rd_nu_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "cm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cannag;
        private System.Windows.Forms.TextBox txt_chieucao;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_kq;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.RadioButton rd_nu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

