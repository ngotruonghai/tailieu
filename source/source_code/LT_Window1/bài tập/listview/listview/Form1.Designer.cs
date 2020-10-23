namespace listview
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ls1_b1 = new System.Windows.Forms.ListView();
            this.ls2_b1 = new System.Windows.Forms.ListView();
            this.txt_tenach = new System.Windows.Forms.TextBox();
            this.txt_giasach = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_giasach);
            this.groupBox1.Controls.Add(this.txt_tenach);
            this.groupBox1.Controls.Add(this.ls2_b1);
            this.groupBox1.Controls.Add(this.ls1_b1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ls1_b1
            // 
            this.ls1_b1.Location = new System.Drawing.Point(6, 71);
            this.ls1_b1.Name = "ls1_b1";
            this.ls1_b1.Size = new System.Drawing.Size(270, 103);
            this.ls1_b1.TabIndex = 2;
            this.ls1_b1.UseCompatibleStateImageBehavior = false;
            // 
            // ls2_b1
            // 
            this.ls2_b1.Location = new System.Drawing.Point(6, 209);
            this.ls2_b1.Name = "ls2_b1";
            this.ls2_b1.Size = new System.Drawing.Size(270, 103);
            this.ls2_b1.TabIndex = 3;
            this.ls2_b1.UseCompatibleStateImageBehavior = false;
            // 
            // txt_tenach
            // 
            this.txt_tenach.Location = new System.Drawing.Point(78, 19);
            this.txt_tenach.Name = "txt_tenach";
            this.txt_tenach.Size = new System.Drawing.Size(117, 20);
            this.txt_tenach.TabIndex = 4;
            // 
            // txt_giasach
            // 
            this.txt_giasach.Location = new System.Drawing.Point(78, 45);
            this.txt_giasach.Name = "txt_giasach";
            this.txt_giasach.Size = new System.Drawing.Size(117, 20);
            this.txt_giasach.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "mua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(6, 180);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(100, 20);
            this.txt_soluong.TabIndex = 8;
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
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_giasach;
        private System.Windows.Forms.TextBox txt_tenach;
        private System.Windows.Forms.ListView ls2_b1;
        private System.Windows.Forms.ListView ls1_b1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

