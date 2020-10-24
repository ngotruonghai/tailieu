using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            trb_top.Minimum = 50;
            trb_top.Maximum = grb_1.Width;
            trb_left.Minimum = 50;
            trb_left.Maximum = grb_1.Height;
            pic_1.Left = 50;
            pic_1.Top = 50;
        }

        private void trb_top_Scroll(object sender, EventArgs e)
        {
            foreach(Control t in grb_1.Controls)
            {
                if(t is PictureBox)
                {
                    t.Left -= 3;
                }
            }
            int n=trb_top.Value;
            lb1.Text = trb_top.Value.ToString();
            foreach(Control t in grb_1.Controls)
            {
                if(n+1>=pic_1.Left)
                {
                    pic_1.Left += 3;
                }
            }
        }

        private void trb_left_Scroll(object sender, EventArgs e)
        {
            foreach(Control t in grb_1.Controls)
            {
                if(t is PictureBox)
                {
                    t.Top += 2;
                }
            }
            int n=trb_left.Value;
            lb2.Text = trb_left.Value.ToString();
            foreach(Control t in grb_1.Controls)
            {
                if(n<=pic_1.Top)
                {
                    pic_1.Top -= 2;
                }
            }
        }
    }
}
