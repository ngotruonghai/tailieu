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

namespace lisview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lsv1.Columns.Add("STT");
            lsv1.Columns.Add("Số");
            lsv1.View = View.Details;
            lsv1.FullRowSelect = true;
            lsv1.GridLines = true;
            lsv2.Columns.Add("STT");
            lsv2.Columns.Add("Số");
            lsv2.View = View.Details;
            lsv2.FullRowSelect = true;
            lsv2.GridLines = true;
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ListViewItem lsvit = new ListViewItem();
            lsvit = new ListViewItem((lsv1.Items.Count + 1).ToString());
            int j = random.Next(0, 21);
            lsvit.SubItems.Add(j.ToString());
            lsv1.Items.Add(lsvit);
            string s;
            int h = 0;
            for(int i=0;i<lsv1.Items.Count;i++)
            {
                s = lsv1.Items[i].SubItems[1].Text;
                h = int.Parse(s);
            }
            ar.Add(h);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem lsv = new ListViewItem((lsv2.Items.Count+1).ToString());
            for(int i=0;i<lsv1.Items.Count;i++)
            {
                if(lsv1.Items[i].Selected)
                {
                    lsv.SubItems.Add(lsv1.Items[i].SubItems[1]);
                    lsv1.Items[i].Remove();
                    break;
                }
            }
            lsv2.Items.Add(lsv);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_kq.Clear();
            int max = 0;
            int d=0;
            foreach (int n in ar)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            txt_kq.Text = max.ToString();
            max = 0;
            for(int i=0;i<lsv1.Items.Count;i++)
            {
                int n = int.Parse(lsv1.Items[i].SubItems[1].Text);
                if(n>max)
                {
                    max = n;
                    d= int.Parse(lsv1.Items[i].Text);
                }
            }
            lb_vitri.Text = d.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lsv1.Clear();
            lsv2.Clear();
            txt_kq.Clear();
            lsv1.Columns.Add("STT");
            lsv1.Columns.Add("Số");
            lsv1.View = View.Details;
            lsv1.FullRowSelect = true;
            lsv1.GridLines = true;
            lsv2.Columns.Add("STT");
            lsv2.Columns.Add("Số");
            lsv2.View = View.Details;
            lsv2.FullRowSelect = true;
            lsv2.GridLines = true;
            ar = new ArrayList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int max = 0;
            for(int i=0;i<lsv1.Items.Count;i++)
            {
                int s = int.Parse(lsv1.Items[i].SubItems[1].Text);
                if(s>max)
                {
                    max = s;
                }
            }
            for(int i=0;i<lsv1.Items.Count;i++)
            {
                int s = int.Parse(lsv1.Items[i].SubItems[1].Text);
                if(s==max)
                {
                    lsv1.Items[i].Remove();
                }
            }
        }
    }
}
