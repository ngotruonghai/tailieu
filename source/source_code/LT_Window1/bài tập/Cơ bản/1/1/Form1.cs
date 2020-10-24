using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtsoa.Text.Equals("")||txtsob.Text.Equals(""))
            {
                MessageBox.Show("không được để trống", "Thông Báo");
            }
            else
            {
                float a = float.Parse(txtsoa.Text);
                float b = float.Parse(txtsob.Text);
                float c = 0;
                if(radcong.Checked)
                {
                    c = a + b;
                }
                if(radtru.Checked)
                {
                    c = a - b;
                }
                if(radchia.Checked)
                {
                    if(txtsoa.Text=="0"||txtsob.Text=="0")
                    {
                        MessageBox.Show("không được có số 0", "Thông Báo");
                    }
                    else
                    {
                        c = a / b;
                    }
                }
                if(radnhan.Checked)
                {
                    c = a * b;
                }
                txtketqua.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtketqua.Text = "";
            txtsoa.Text = "";
            txtsob.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtchu.Text.Equals("")||txtsod.Text.Equals(""))
            {
                MessageBox.Show("Không dc trống", "Thông Báo");
            }
            else
            {
                int n = int.Parse(txtsod.Text.Trim());
                string s1 = "";
                int s2 = 0;
                for(int i=0;i<n;i++)
                {
                    s2 = s2 + i;
                    s1 = i.ToString() + "+";
                }
                txtketqua2.Text = s1.ToString();
                txthetqua3.Text = s1.Substring(0, s1.Length-1);
                
            }
        }
    }
}
