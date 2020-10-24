namespace _2
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
            this.lb_solanquay = new System.Windows.Forms.Label();
            this.lb_giainhat = new System.Windows.Forms.Label();
            this.lb_giainhi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bang2 = new System.Windows.Forms.TextBox();
            this.txt_bang1 = new System.Windows.Forms.TextBox();
            this.txt_bang3 = new System.Windows.Forms.TextBox();
            this.bt_vongquay = new System.Windows.Forms.Button();
            this.bt_auto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.time_vongquay = new System.Windows.Forms.Timer(this.components);
            this.lb_chu = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.time_2 = new System.Windows.Forms.Timer(this.components);
            this.lb_so = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.lb_so);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.lb_chu);
            this.groupBox1.Controls.Add(this.lb_solanquay);
            this.groupBox1.Controls.Add(this.lb_giainhat);
            this.groupBox1.Controls.Add(this.lb_giainhi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_bang2);
            this.groupBox1.Controls.Add(this.txt_bang1);
            this.groupBox1.Controls.Add(this.txt_bang3);
            this.groupBox1.Controls.Add(this.bt_vongquay);
            this.groupBox1.Controls.Add(this.bt_auto);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(76, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giải nhất";
            // 
            // lb_solanquay
            // 
            this.lb_solanquay.AutoSize = true;
            this.lb_solanquay.Location = new System.Drawing.Point(109, 132);
            this.lb_solanquay.Name = "lb_solanquay";
            this.lb_solanquay.Size = new System.Drawing.Size(0, 17);
            this.lb_solanquay.TabIndex = 11;
            // 
            // lb_giainhat
            // 
            this.lb_giainhat.AutoSize = true;
            this.lb_giainhat.Location = new System.Drawing.Point(109, 170);
            this.lb_giainhat.Name = "lb_giainhat";
            this.lb_giainhat.Size = new System.Drawing.Size(0, 17);
            this.lb_giainhat.TabIndex = 10;
            this.lb_giainhat.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_giainhi
            // 
            this.lb_giainhi.AutoSize = true;
            this.lb_giainhi.Location = new System.Drawing.Point(109, 210);
            this.lb_giainhi.Name = "lb_giainhi";
            this.lb_giainhi.Size = new System.Drawing.Size(0, 17);
            this.lb_giainhi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lần quay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giải nhì";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giải nhất";
            // 
            // txt_bang2
            // 
            this.txt_bang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bang2.Location = new System.Drawing.Point(112, 28);
            this.txt_bang2.Multiline = true;
            this.txt_bang2.Name = "txt_bang2";
            this.txt_bang2.Size = new System.Drawing.Size(100, 89);
            this.txt_bang2.TabIndex = 5;
            this.txt_bang2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bang1
            // 
            this.txt_bang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bang1.Location = new System.Drawing.Point(6, 29);
            this.txt_bang1.Multiline = true;
            this.txt_bang1.Name = "txt_bang1";
            this.txt_bang1.Size = new System.Drawing.Size(100, 88);
            this.txt_bang1.TabIndex = 4;
            this.txt_bang1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bang3
            // 
            this.txt_bang3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bang3.Location = new System.Drawing.Point(218, 28);
            this.txt_bang3.Multiline = true;
            this.txt_bang3.Name = "txt_bang3";
            this.txt_bang3.Size = new System.Drawing.Size(100, 89);
            this.txt_bang3.TabIndex = 3;
            this.txt_bang3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_vongquay
            // 
            this.bt_vongquay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vongquay.Location = new System.Drawing.Point(470, 61);
            this.bt_vongquay.Name = "bt_vongquay";
            this.bt_vongquay.Size = new System.Drawing.Size(75, 56);
            this.bt_vongquay.TabIndex = 2;
            this.bt_vongquay.Text = "vong quay";
            this.bt_vongquay.UseVisualStyleBackColor = true;
            this.bt_vongquay.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_auto
            // 
            this.bt_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_auto.Location = new System.Drawing.Point(470, 123);
            this.bt_auto.Name = "bt_auto";
            this.bt_auto.Size = new System.Drawing.Size(75, 34);
            this.bt_auto.TabIndex = 1;
            this.bt_auto.Text = "Auto";
            this.bt_auto.UseVisualStyleBackColor = true;
            this.bt_auto.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(470, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Star";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // time_vongquay
            // 
            this.time_vongquay.Interval = 1000;
            this.time_vongquay.Tick += new System.EventHandler(this.time_vongquay_Tick);
            // 
            // lb_chu
            // 
            this.lb_chu.AutoSize = true;
            this.lb_chu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_chu.Location = new System.Drawing.Point(28, 240);
            this.lb_chu.Name = "lb_chu";
            this.lb_chu.Size = new System.Drawing.Size(277, 31);
            this.lb_chu.TabIndex = 12;
            this.lb_chu.Text = "Vòng quay may mắn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(357, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 138);
            this.button3.TabIndex = 13;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // time_2
            // 
            this.time_2.Tick += new System.EventHandler(this.time_2_Tick);
            // 
            // lb_so
            // 
            this.lb_so.AutoSize = true;
            this.lb_so.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_so.Location = new System.Drawing.Point(215, 304);
            this.lb_so.Name = "lb_so";
            this.lb_so.Size = new System.Drawing.Size(0, 17);
            this.lb_so.TabIndex = 14;
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_solanquay;
        private System.Windows.Forms.Label lb_giainhat;
        private System.Windows.Forms.Label lb_giainhi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bang2;
        private System.Windows.Forms.TextBox txt_bang1;
        private System.Windows.Forms.TextBox txt_bang3;
        private System.Windows.Forms.Button bt_vongquay;
        private System.Windows.Forms.Button bt_auto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer time_vongquay;
        private System.Windows.Forms.Label lb_chu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer time_2;
        private System.Windows.Forms.Label lb_so;
    }
}

