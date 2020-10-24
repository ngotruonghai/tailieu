namespace bai_1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_bang1 = new System.Windows.Forms.TextBox();
            this.txt_bang2 = new System.Windows.Forms.TextBox();
            this.txt_bang3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_solanquay = new System.Windows.Forms.Label();
            this.txt_giainhat = new System.Windows.Forms.Label();
            this.txt_gainhi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.time_1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.time_2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txt_time);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_gainhi);
            this.groupBox1.Controls.Add(this.txt_giainhat);
            this.groupBox1.Controls.Add(this.txt_solanquay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_bang3);
            this.groupBox1.Controls.Add(this.txt_bang2);
            this.groupBox1.Controls.Add(this.txt_bang1);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bài 10";
            // 
            // txt_bang1
            // 
            this.txt_bang1.Enabled = false;
            this.txt_bang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bang1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_bang1.Location = new System.Drawing.Point(6, 19);
            this.txt_bang1.Multiline = true;
            this.txt_bang1.Name = "txt_bang1";
            this.txt_bang1.Size = new System.Drawing.Size(100, 100);
            this.txt_bang1.TabIndex = 0;
            this.txt_bang1.Tag = "";
            this.txt_bang1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bang2
            // 
            this.txt_bang2.Enabled = false;
            this.txt_bang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bang2.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_bang2.Location = new System.Drawing.Point(112, 19);
            this.txt_bang2.Multiline = true;
            this.txt_bang2.Name = "txt_bang2";
            this.txt_bang2.Size = new System.Drawing.Size(100, 100);
            this.txt_bang2.TabIndex = 1;
            this.txt_bang2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bang3
            // 
            this.txt_bang3.Enabled = false;
            this.txt_bang3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bang3.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_bang3.Location = new System.Drawing.Point(218, 19);
            this.txt_bang3.Multiline = true;
            this.txt_bang3.Name = "txt_bang3";
            this.txt_bang3.Size = new System.Drawing.Size(100, 100);
            this.txt_bang3.TabIndex = 2;
            this.txt_bang3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số lần quay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "giải nhât: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giải nhì";
            // 
            // txt_solanquay
            // 
            this.txt_solanquay.AutoSize = true;
            this.txt_solanquay.Location = new System.Drawing.Point(122, 196);
            this.txt_solanquay.Name = "txt_solanquay";
            this.txt_solanquay.Size = new System.Drawing.Size(0, 13);
            this.txt_solanquay.TabIndex = 10;
            // 
            // txt_giainhat
            // 
            this.txt_giainhat.AutoSize = true;
            this.txt_giainhat.Location = new System.Drawing.Point(122, 223);
            this.txt_giainhat.Name = "txt_giainhat";
            this.txt_giainhat.Size = new System.Drawing.Size(0, 13);
            this.txt_giainhat.TabIndex = 11;
            // 
            // txt_gainhi
            // 
            this.txt_gainhi.AutoSize = true;
            this.txt_gainhi.Location = new System.Drawing.Point(122, 249);
            this.txt_gainhi.Name = "txt_gainhi";
            this.txt_gainhi.Size = new System.Drawing.Size(0, 13);
            this.txt_gainhi.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "vòng quay star";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // time_1
            // 
            this.time_1.Interval = 1000;
            this.time_1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 72);
            this.button3.TabIndex = 14;
            this.button3.Text = "Làm mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 15;
            this.button4.Text = "Quay nhanh->chậm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // time_2
            // 
            this.time_2.Tick += new System.EventHandler(this.time_2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "quay";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_time
            // 
            this.txt_time.AutoSize = true;
            this.txt_time.Location = new System.Drawing.Point(250, 249);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(0, 13);
            this.txt_time.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(218, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 38);
            this.button5.TabIndex = 18;
            this.button5.Text = "Chuyển chữ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 408);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_gainhi;
        private System.Windows.Forms.Label txt_giainhat;
        private System.Windows.Forms.Label txt_solanquay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_bang3;
        private System.Windows.Forms.TextBox txt_bang2;
        private System.Windows.Forms.TextBox txt_bang1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer time_1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer time_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_time;
        private System.Windows.Forms.Button button5;
    }
}

