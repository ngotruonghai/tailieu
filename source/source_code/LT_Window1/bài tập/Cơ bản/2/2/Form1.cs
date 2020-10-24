using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList A= new ArrayList();
            int n = int.Parse(txtsoa.Text.Trim());
            Random rd = new Random();
            int k;
            string s = "";
            for(int i=0;i<n;i++)
            {
                k = rd.Next(-5, 10);
                s = k.ToString()+"  "+s;
                A.Add(k);
            }
            txtketqua.Text = s.Trim();
            //cách 2:arraylist
            int tong = 0;
            for(int i=0;i<A.Count;i++)
            {
                tong = tong + int.Parse(A[i].ToString());
            }
            txttong.Text = tong.ToString();
            //cách 1:
            int s5 = 0;
            foreach(string t in txtketqua.Text.Split(' '))
            {
               if(int.Parse(t)%2==0)
                {
                    s5++;
                }
            }
            txttongc2.Text = s5.ToString();
            
        }
    }
}
