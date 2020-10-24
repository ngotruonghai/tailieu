using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         //if (e.KeyCode == Keys.Right)
         //       move+=2;
         //   if (e.KeyCode == Keys.Left)
         //       move-=2;
         //   this.Invalidate();
        private void nhapchu(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txt_name.Text==""||txt_chieucao.Text=="")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ", "Thing6 báo");
            }
           else
            {
                int can = 0;
                int n = int.Parse(txt_chieucao.Text);
                if (rd_nam.Checked)
                {
                    can = n - 100 - ((n - 150) / 4);
                    lb_kq.Text = "chiều cao lý tưởng là:  " + can.ToString();
                }
                if (rd_nu.Checked)
                {
                    can = n - 100 - ((n - 150) / 2);
                    lb_kq.Text = "chiều cao lý tưởng là:  " + can.ToString();
                }
            }
        }

        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rd_nam_CheckedChanged(object sender, EventArgs e)
        {
            rd_nu.Checked = false;
        }

        private void rd_nu_CheckedChanged(object sender, EventArgs e)
        {
            rd_nam.Checked = false;
        }
    }
}
