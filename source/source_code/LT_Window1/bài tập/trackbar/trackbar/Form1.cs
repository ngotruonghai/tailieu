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

namespace trackbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        ArrayList arr = new ArrayList();
        private void trb1_Scroll(object sender, EventArgs e)
        {
            foreach (Control c in gr1.Controls)
            {
                if (c is TextBox)
                {
                    c.Visible = false;
                }
            }
            trb1.Minimum = 0;
            trb1.Maximum = 15;
            lb1.Text = trb1.Value.ToString();
            trb1.BackColor = Color.Aqua;
            int i = 0;
            int n = trb1.Value;
            arr.Clear();
            foreach(Control c in gr1.Controls)
            {
                c.Visible = true;
                c.Text = rd.Next(1, 5).ToString();
                arr.Add(int.Parse(c.Text));
                i++;
                txt_ketqua.Clear();
                if(n==0)
                {
                    c.Visible = false;
                    arr = new ArrayList();
                }
                else if(n==i)
                {
                    break;
                }
            }
        }

        private void gr1_Enter(object sender, EventArgs e)
        {
           foreach(Control c in gr1.Controls)
            {
                if(c is TextBox)
                {
                    c.Visible = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int l = 20;
            for(int i=0;i<15;i++)
            {
                TextBox txt = new TextBox();
                txt.Multiline = true;
                txt.Width = 30;
                txt.Height = 30;
                txt.Left = l;
                txt.Top = 20;
                l = l + 50;
                gr1.Controls.Add(txt);
            }
           for(int i=3;i<=10;i++)
            {
                cb1.Items.Add(i);
            }
            txt_ketqua.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = 0;
            for(int i=0;i<arr.Count;i++)
            {
                t = t + int.Parse(arr[i].ToString());
            }
            txt_ketqua.Text = t.ToString();
        }
        public bool SNT(int n)
        {
            int d = 0;
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    d++;
                }
            }
            if (d == 2)
                return true;
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int i in arr)
            {
                if(SNT(i)==true)
                {
                    txt_ketqua.Text += i.ToString()+"  " ;
                }
            }
        }

        private void grb2_Enter(object sender, EventArgs e)
        {
           
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grb2.Controls.Clear();
            int n = int.Parse(cb1.SelectedItem.ToString());
            int l = 0;
            int t = 10;
            for (int i = 1; i <= n; i++)
            {
                for(int j=1;j<=n;j++)
                {
                  if(i%2!=0)
                    {
                       if(j%2!=0)
                        {
                            TextBox txt = new TextBox();
                            txt.Multiline = true;
                            txt.Left = l;
                            txt.Width = 25;
                            txt.Height = 25;
                            txt.Top = t;
                            grb2.Controls.Add(txt);
                            l += 25;
                            txt.BackColor = Color.Black;
                        }
                       else
                        {
                            TextBox txt = new TextBox();
                            txt.Multiline = true;
                            txt.Left = l;
                            txt.Width = 25;
                            txt.Height = 25;
                            txt.Top = t;
                            grb2.Controls.Add(txt);
                            l += 25;
                            txt.BackColor = Color.Yellow;
                        }
                    }
                  else
                    {
                        if (j % 2 != 0)
                        {
                            TextBox txt = new TextBox();
                            txt.Multiline = true;
                            txt.Left = l;
                            txt.Width = 25;
                            txt.Height = 25;
                            txt.Top = t;
                            grb2.Controls.Add(txt);
                            l += 25;
                            txt.BackColor = Color.Yellow;
                        }
                        else
                        {
                            TextBox txt = new TextBox();
                            txt.Multiline = true;
                            txt.Left = l;
                            txt.Width = 25;
                            txt.Height = 25;
                            txt.Top = t;
                            grb2.Controls.Add(txt);
                            l += 25;
                            txt.BackColor = Color.Black;
                        }
                    }
                }
                t += 25;
                l = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_ketqua.Clear();
            int d = 0;
            for(int i=0;i<arr.Count;i++)
            {
               for(int j=0;j<arr.Count;j++)
                {
                    if(int.Parse(arr[i].ToString())==int.Parse(arr[j].ToString())&&i!=j)
                    {
                        d++;
                    }
                }
                if (d == 0)
                {
                    txt_ketqua.Text += arr[i].ToString()+"";
                }
                d = 0;
            }
        }
    }
}
