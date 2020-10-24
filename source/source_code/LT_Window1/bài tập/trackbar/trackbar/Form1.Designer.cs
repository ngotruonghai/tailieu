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
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.lb1 = new System.Windows.Forms.Label();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            this.SuspendLayout();
            // 
            // gr1
            // 
            this.gr1.Location = new System.Drawing.Point(7, 142);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(771, 105);
            this.gr1.TabIndex = 0;
            this.gr1.TabStop = false;
            this.gr1.Text = "Phát sinh số";
            this.gr1.Enter += new System.EventHandler(this.gr1_Enter);
            // 
            // trb1
            // 
            this.trb1.Location = new System.Drawing.Point(43, 71);
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(700, 45);
            this.trb1.TabIndex = 1;
            this.trb1.Scroll += new System.EventHandler(this.trb1_Scroll);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(332, 37);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 31);
            this.lb1.TabIndex = 2;
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Location = new System.Drawing.Point(12, 253);
            this.txt_ketqua.Multiline = true;
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(100, 44);
            this.txt_ketqua.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tổng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SNT(Liệt kê)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grb2
            // 
            this.grb2.Location = new System.Drawing.Point(271, 253);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(507, 239);
            this.grb2.TabIndex = 6;
            this.grb2.TabStop = false;
            this.grb2.Text = "Bàn cờ";
            this.grb2.Enter += new System.EventHandler(this.grb2_Enter);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(106, 336);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 7;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Xuất hiện đúng 1 lần";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 509);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.trb1);
            this.Controls.Add(this.gr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button button3;
    }
}

