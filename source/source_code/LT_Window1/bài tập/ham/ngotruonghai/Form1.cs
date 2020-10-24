using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngotruonghai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_n.Text);
            int h;
            int dn = 0;
            while(n>0)
            {
                h = n % 10;
                dn = (dn * 10) + h;
                n = n / 10;
            }
            txt_daonguoc.Text = dn.ToString();
            txt_n.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_daonguoc.Enabled = false;
            txt_KQ.Enabled = false;
            int s = 0;
        }
        public int ham(int a, int b)
        {
            int s = 0;
            for (int i = a; i <= b; i++)
            {
                s += i;
            }
            return s;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_tu.Text);
            int b = int.Parse(txt_den.Text);
            int tong = ham(a, b);
            txt_KQ.Text = tong.ToString();
        }
    }
}
