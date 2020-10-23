using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(nbd1.Value>=0 || nbd2.Value>=0 || cbcaovoi.Checked || cbtayrang.Checked)
            {
                string d1 = nbd1.Value.ToString();//chuyển về chử
                string d2 = nbd2.Value.ToString();
                int tong = 0;
                if((nbd1.Value>=0 || nbd2.Value>=0 )&& cbcaovoi.Checked)
                {
                    tong = int.Parse(d1)*150+ int.Parse(d2)*200+ 100;
                    txtketqua1.Text = tong.ToString() + ".000đ";
                }
                if((nbd1.Value>=0 || nbd2.Value>=0) && cbtayrang.Checked)
                {
                    tong = int.Parse(d1) * 150 + int.Parse(d2) * 200 + 1500;
                    txtketqua1.Text = tong.ToString() + ".000đ";
                }
                if ((nbd1.Value >= 0 || nbd2.Value >= 0) && cbtayrang.Checked && cbcaovoi.Checked)
                {
                    tong = int.Parse(d1) * 150 + int.Parse(d2) * 200 + 1500+100;
                    txtketqua1.Text = tong.ToString() + ".000đ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtrandom.Text = "";
            txtnhapn.Text = "";
            txtketquatong.Text = "";
            txtketquale.Text = "";
            txtketquachan.Text = "";
            nbd1.Value = 0;
            nbd2.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList A = new ArrayList();
            Random rd = new Random();
            int k;
            string s = "";
            int n = int.Parse(txtnhapn.Text.Trim());
            for(int i=0;i<n;i++)
            {
                k = rd.Next(-5, 10);
                s = k.ToString() + " " + s;
                A.Add(k);
            }
            txtrandom.Text = s.Trim();   
            int tong = 0;
            int tongchan = 0;
            int tongle = 0;
            foreach(string t in txtrandom.Text.Split(' '))
            {
                
                if(int.Parse(t)%2==0)
                {
                    tongchan = tongchan + int.Parse(t);
                }
                else
                {
                    tongle = tongle + int.Parse(t);
                }
                tong = tong + int.Parse(t);
                txtketquatong.Text = tong.ToString();
                txtketquachan.Text = tongchan.ToString();
                txtketquale.Text = tongle.ToString();
            }
        }

        private void button4_Enter(object sender, EventArgs e)
        {

        }
    }
}
