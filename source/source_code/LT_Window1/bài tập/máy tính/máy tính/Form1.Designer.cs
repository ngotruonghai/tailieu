namespace máy_tính
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_ketqua = new System.Windows.Forms.Button();
            this.txt_bang = new System.Windows.Forms.TextBox();
            this.bt_nhan = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.txt_nhapp = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nhapp);
            this.groupBox1.Controls.Add(this.txt_nhap);
            this.groupBox1.Controls.Add(this.bt_ketqua);
            this.groupBox1.Controls.Add(this.txt_bang);
            this.groupBox1.Controls.Add(this.bt_nhan);
            this.groupBox1.Controls.Add(this.bt_3);
            this.groupBox1.Controls.Add(this.bt_2);
            this.groupBox1.Controls.Add(this.bt_1);
            this.groupBox1.Location = new System.Drawing.Point(37, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_ketqua
            // 
            this.bt_ketqua.Location = new System.Drawing.Point(249, 19);
            this.bt_ketqua.Name = "bt_ketqua";
            this.bt_ketqua.Size = new System.Drawing.Size(75, 46);
            this.bt_ketqua.TabIndex = 5;
            this.bt_ketqua.Text = "kết quả";
            this.bt_ketqua.UseVisualStyleBackColor = true;
            this.bt_ketqua.Click += new System.EventHandler(this.bt_ketqua_Click);
            // 
            // txt_bang
            // 
            this.txt_bang.Location = new System.Drawing.Point(6, 19);
            this.txt_bang.Multiline = true;
            this.txt_bang.Name = "txt_bang";
            this.txt_bang.Size = new System.Drawing.Size(237, 46);
            this.txt_bang.TabIndex = 4;
            // 
            // bt_nhan
            // 
            this.bt_nhan.Location = new System.Drawing.Point(249, 71);
            this.bt_nhan.Name = "bt_nhan";
            this.bt_nhan.Size = new System.Drawing.Size(75, 23);
            this.bt_nhan.TabIndex = 3;
            this.bt_nhan.Text = "+";
            this.bt_nhan.UseVisualStyleBackColor = true;
            this.bt_nhan.Click += new System.EventHandler(this.dau);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(168, 71);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(75, 23);
            this.bt_3.TabIndex = 2;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.number);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(87, 71);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(75, 23);
            this.bt_2.TabIndex = 1;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.number);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(6, 71);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(75, 23);
            this.bt_1.TabIndex = 0;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.number);
            // 
            // txt_nhap
            // 
            this.txt_nhap.Location = new System.Drawing.Point(101, 181);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(100, 20);
            this.txt_nhap.TabIndex = 6;
            // 
            // txt_nhapp
            // 
            this.txt_nhapp.Location = new System.Drawing.Point(126, 250);
            this.txt_nhapp.Name = "txt_nhapp";
            this.txt_nhapp.Size = new System.Drawing.Size(100, 20);
            this.txt_nhapp.TabIndex = 7;
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
        private System.Windows.Forms.Button bt_ketqua;
        private System.Windows.Forms.TextBox txt_bang;
        private System.Windows.Forms.Button bt_nhan;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.TextBox txt_nhapp;
    }
}

