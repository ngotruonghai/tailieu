namespace mohinh3L
{
    partial class chitietphiemuon
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
            this.lb_hoten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ma = new System.Windows.Forms.Label();
            this.lsv_sachdangco = new System.Windows.Forms.ListView();
            this.lsv_sachdachon = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_hoten
            // 
            this.lb_hoten.AutoSize = true;
            this.lb_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoten.Location = new System.Drawing.Point(101, 98);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(20, 17);
            this.lb_hoten.TabIndex = 0;
            this.lb_hoten.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tên dọc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "mã phieu mượn";
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(101, 52);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(20, 17);
            this.lb_ma.TabIndex = 3;
            this.lb_ma.Text = "...";
            // 
            // lsv_sachdangco
            // 
            this.lsv_sachdangco.Location = new System.Drawing.Point(12, 135);
            this.lsv_sachdangco.Name = "lsv_sachdangco";
            this.lsv_sachdangco.Size = new System.Drawing.Size(776, 147);
            this.lsv_sachdangco.TabIndex = 4;
            this.lsv_sachdangco.UseCompatibleStateImageBehavior = false;
            // 
            // lsv_sachdachon
            // 
            this.lsv_sachdachon.Location = new System.Drawing.Point(12, 360);
            this.lsv_sachdachon.Name = "lsv_sachdachon";
            this.lsv_sachdachon.Size = new System.Drawing.Size(763, 147);
            this.lsv_sachdachon.TabIndex = 5;
            this.lsv_sachdachon.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chitietphiemuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsv_sachdachon);
            this.Controls.Add(this.lsv_sachdangco);
            this.Controls.Add(this.lb_ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_hoten);
            this.Name = "chitietphiemuon";
            this.Text = "chitietphiemuon";
            this.Load += new System.EventHandler(this.chitietphiemuon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.ListView lsv_sachdangco;
        private System.Windows.Forms.ListView lsv_sachdachon;
        private System.Windows.Forms.Button button1;
    }
}