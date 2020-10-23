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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        ArrayList ar = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            lsv_1.Columns.Add("stt");
            lsv_1.Columns.Add("số");
            lsv_1.FullRowSelect = true;
            lsv_1.GridLines = true;
            lsv_1.View = View.Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lsv = new ListViewItem((lsv_1.Items.Count + 1).ToString());
            int n = rd.Next(-5, 11);
            lsv.SubItems.Add(n.ToString());
            lsv_1.Items.Add(lsv);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 0;
            string j = "";
            int max = 0;
           for(int i=0;i<lsv_1.Items.Count;i++)
            {
                //txt_test.Text += lsv_1.Items[i].SubItems[1].Text;
                j = lsv_1.Items[i].SubItems[1].Text;
                n = int.Parse(j);
                {
                    if(n>max)
                    {
                        max = n;
                    }
                }
            }
            txt_ketqua.Text = max.ToString() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lsv_1.Items.Count;i++)
            {
                if(lsv_1.Items[i].Selected)
                {
                    lsv_1.Items[i].Remove();
                }
            }
        }
    }
}
