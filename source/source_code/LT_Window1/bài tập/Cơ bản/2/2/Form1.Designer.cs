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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.checkbox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttongc2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txttongc2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttong);
            this.groupBox1.Controls.Add(this.txtketqua);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtsoa);
            this.groupBox1.Controls.Add(this.checkbox);
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "random";
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(92, 137);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(143, 20);
            this.txttong.TabIndex = 4;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(93, 93);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(141, 20);
            this.txtketqua.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "kết quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsoa
            // 
            this.txtsoa.Location = new System.Drawing.Point(92, 37);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(143, 20);
            this.txtsoa.TabIndex = 1;
            // 
            // checkbox
            // 
            this.checkbox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkbox.Location = new System.Drawing.Point(16, 31);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(54, 26);
            this.checkbox.TabIndex = 0;
            this.checkbox.Text = "nhập n";
            this.checkbox.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "cách 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "cách 1";
            // 
            // txttongc2
            // 
            this.txttongc2.Location = new System.Drawing.Point(93, 186);
            this.txttongc2.Name = "txttongc2";
            this.txttongc2.Size = new System.Drawing.Size(142, 20);
            this.txttongc2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.Button checkbox;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongc2;
    }
}

