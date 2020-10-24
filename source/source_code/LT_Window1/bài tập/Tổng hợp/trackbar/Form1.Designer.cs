namespace trackbar
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
            this.trb_1 = new System.Windows.Forms.TrackBar();
            this.CB = new System.Windows.Forms.ComboBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.txt_test = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.Button();
            this.grb_1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_35 = new System.Windows.Forms.CheckBox();
            this.ck_vtm = new System.Windows.Forms.CheckBox();
            this.ck_nt = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trb_1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trb_1
            // 
            this.trb_1.Location = new System.Drawing.Point(408, 49);
            this.trb_1.Name = "trb_1";
            this.trb_1.Size = new System.Drawing.Size(329, 45);
            this.trb_1.TabIndex = 0;
            this.trb_1.Scroll += new System.EventHandler(this.trb_1_Scroll);
            // 
            // CB
            // 
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(253, 9);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(121, 21);
            this.CB.TabIndex = 1;
            this.CB.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(598, 9);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(24, 25);
            this.lb_1.TabIndex = 2;
            this.lb_1.Text = "0";
            // 
            // txt_test
            // 
            this.txt_test.Location = new System.Drawing.Point(21, 49);
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(353, 20);
            this.txt_test.TabIndex = 3;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(6, 19);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(80, 23);
            this.bt.TabIndex = 4;
            this.bt.Text = "Số nguyên tố";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.btb);
            // 
            // grb_1
            // 
            this.grb_1.Location = new System.Drawing.Point(12, 100);
            this.grb_1.Name = "grb_1";
            this.grb_1.Size = new System.Drawing.Size(716, 100);
            this.grb_1.TabIndex = 5;
            this.grb_1.TabStop = false;
            this.grb_1.Text = "Mảng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số phần tử từ 1 đến 15";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.ck_35);
            this.groupBox1.Controls.Add(this.ck_vtm);
            this.groupBox1.Controls.Add(this.ck_nt);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bt);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button";
            // 
            // ck_35
            // 
            this.ck_35.AutoSize = true;
            this.ck_35.Location = new System.Drawing.Point(492, 65);
            this.ck_35.Name = "ck_35";
            this.ck_35.Size = new System.Drawing.Size(132, 17);
            this.ck_35.TabIndex = 9;
            this.ck_35.Text = "Xóa Bội chung 3 va 5 ";
            this.ck_35.UseVisualStyleBackColor = true;
            this.ck_35.CheckedChanged += new System.EventHandler(this.xoa);
            // 
            // ck_vtm
            // 
            this.ck_vtm.AutoSize = true;
            this.ck_vtm.Location = new System.Drawing.Point(492, 42);
            this.ck_vtm.Name = "ck_vtm";
            this.ck_vtm.Size = new System.Drawing.Size(92, 17);
            this.ck_vtm.TabIndex = 8;
            this.ck_vtm.Text = "Xóa Vị trí max";
            this.ck_vtm.UseVisualStyleBackColor = true;
            this.ck_vtm.CheckedChanged += new System.EventHandler(this.xoa);
            // 
            // ck_nt
            // 
            this.ck_nt.AutoSize = true;
            this.ck_nt.Location = new System.Drawing.Point(492, 19);
            this.ck_nt.Name = "ck_nt";
            this.ck_nt.Size = new System.Drawing.Size(109, 17);
            this.ck_nt.TabIndex = 7;
            this.ck_nt.Text = "Xóa số nguyên tố";
            this.ck_nt.UseVisualStyleBackColor = true;
            this.ck_nt.CheckedChanged += new System.EventHandler(this.xoa);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Bội chung 3 va 5 ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btb);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "kết quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ketqua);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Vị trí max";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btb);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 75);
            this.button4.TabIndex = 10;
            this.button4.Text = "checked";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Số chính phương";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btb);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grb_1);
            this.Controls.Add(this.txt_test);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.trb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb_1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trb_1;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.TextBox txt_test;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.GroupBox grb_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ck_35;
        private System.Windows.Forms.CheckBox ck_vtm;
        private System.Windows.Forms.CheckBox ck_nt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

