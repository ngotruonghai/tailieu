namespace bài1
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
            this.grb_1 = new System.Windows.Forms.GroupBox();
            this.trb_top = new System.Windows.Forms.TrackBar();
            this.trb_left = new System.Windows.Forms.TrackBar();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.grb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_1
            // 
            this.grb_1.Controls.Add(this.lb2);
            this.grb_1.Controls.Add(this.lb1);
            this.grb_1.Controls.Add(this.pic_1);
            this.grb_1.Controls.Add(this.trb_left);
            this.grb_1.Controls.Add(this.trb_top);
            this.grb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_1.Location = new System.Drawing.Point(45, 36);
            this.grb_1.Name = "grb_1";
            this.grb_1.Size = new System.Drawing.Size(613, 413);
            this.grb_1.TabIndex = 0;
            this.grb_1.TabStop = false;
            this.grb_1.Text = "Hình";
            this.grb_1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // trb_top
            // 
            this.trb_top.Location = new System.Drawing.Point(121, 29);
            this.trb_top.Name = "trb_top";
            this.trb_top.Size = new System.Drawing.Size(486, 45);
            this.trb_top.TabIndex = 0;
            this.trb_top.Scroll += new System.EventHandler(this.trb_top_Scroll);
            // 
            // trb_left
            // 
            this.trb_left.Location = new System.Drawing.Point(6, 29);
            this.trb_left.Name = "trb_left";
            this.trb_left.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_left.Size = new System.Drawing.Size(45, 378);
            this.trb_left.TabIndex = 1;
            this.trb_left.Scroll += new System.EventHandler(this.trb_left_Scroll);
            // 
            // pic_1
            // 
            this.pic_1.Image = global::bài1.Properties.Resources.index1;
            this.pic_1.Location = new System.Drawing.Point(46, 181);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(68, 69);
            this.pic_1.TabIndex = 2;
            this.pic_1.TabStop = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(91, 26);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(23, 25);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "0";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(41, 26);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(23, 25);
            this.lb2.TabIndex = 4;
            this.lb2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 499);
            this.Controls.Add(this.grb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb_1.ResumeLayout(false);
            this.grb_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_1;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.TrackBar trb_left;
        private System.Windows.Forms.TrackBar trb_top;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
    }
}

