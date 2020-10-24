using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

namespace haingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList A = new ArrayList();
            Random rd = new Random();
            int k;
            string s = "";
            int n = int.Parse(txtsoa.Text.Trim());
            if(radrd.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    k = rd.Next(-5, 10);
                    s = k.ToString() +" "+s;
                    A.Add(k);
                }
                txtketquaa.Text = s.Trim();
            }
            if(radtong.Checked)
            {
                int tong = 0;
                foreach (string t in txtketquaa.Text.Split(' '))
                {
                    tong = int.Parse(t) + tong;
                }
                txtketquab.Text = tong.ToString();
            }
            if(raddem.Checked)
            {
                int demchan = 0;
                foreach(string t in txtketquaa.Text.Split(' '))
                {
                    if(int.Parse(t)%2==0)
                    {
                        demchan++;
                    }
                }
                txtketquac.Text = demchan.ToString();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtketquaa.Text = "";
            txtketquab.Text = "";
            txtketquac.Text = "";
            txtsoa.Text = ""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
