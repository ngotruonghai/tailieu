using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int n = int.Parse(txt_kq.Text);
            for(int i=0;i<n;i++)
            {
                int random = rd.Next(0, 16);
                lb_1.Items.Add(random);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_kq.Clear();
            lb_1.ClearSelected();
            lb_2.ClearSelected();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lb_1.Items.Count;i++)
            {
                if(lb_1.SelectedIndex==i)
                {
                    lb_2.Items.Add(lb_1.Items[i]);
                    lb_1.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lb_2.Items.Count;i++)
            {
                if(lb_2.SelectedIndex==i)
                {
                    lb_1.Items.Add(lb_2.Items[i]);
                    lb_2.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int max = 0;
            for(int i=0;i<lb_1.Items.Count;i++)
            {
                if(int.Parse(lb_1.Items[i].ToString())>max)
                {
                    max = int.Parse(lb_1.Items[i].ToString());
                    lb_1.SelectedIndex = i;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lb_1.Items.Count;i++)
            {
                if(lb_1.SelectedIndex==i)
                {
                    lb_1.Items.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < lb_2.Items.Count; i++)
            {
                if (lb_2.SelectedIndex == i)
                {
                    lb_2.Items.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
