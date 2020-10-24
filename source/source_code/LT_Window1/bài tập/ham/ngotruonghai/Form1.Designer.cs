namespace ngotruonghai
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txt_daonguoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_tu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_den = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KQ = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thuc hien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(106, 26);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 20);
            this.txt_n.TabIndex = 1;
            // 
            // txt_daonguoc
            // 
            this.txt_daonguoc.Location = new System.Drawing.Point(106, 64);
            this.txt_daonguoc.Multiline = true;
            this.txt_daonguoc.Name = "txt_daonguoc";
            this.txt_daonguoc.Size = new System.Drawing.Size(100, 20);
            this.txt_daonguoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhap so n:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "so dao nguoc";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "thoat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_tu
            // 
            this.txt_tu.Location = new System.Drawing.Point(330, 26);
            this.txt_tu.Name = "txt_tu";
            this.txt_tu.Size = new System.Drawing.Size(100, 20);
            this.txt_tu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "tu:";
            // 
            // txt_den
            // 
            this.txt_den.Location = new System.Drawing.Point(467, 26);
            this.txt_den.Name = "txt_den";
            this.txt_den.Size = new System.Drawing.Size(100, 20);
            this.txt_den.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "den";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ket qua";
            // 
            // txt_KQ
            // 
            this.txt_KQ.Location = new System.Drawing.Point(330, 64);
            this.txt_KQ.Name = "txt_KQ";
            this.txt_KQ.Size = new System.Drawing.Size(237, 20);
            this.txt_KQ.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "Thuc hien";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 200);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_KQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_den);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_daonguoc);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.TextBox txt_daonguoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_tu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_den;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_KQ;
        private System.Windows.Forms.Button button3;
    }
}

