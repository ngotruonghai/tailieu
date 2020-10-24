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
        ArrayList Arr = new ArrayList();
        string h = "";
        private void trb_1_Scroll(object sender, EventArgs e)
        {
            Random rd = new Random();
            lb_1.Text = trb_1.Value.ToString();
            CB.Text = trb_1.Value.ToString();
            foreach(Control clt in grb_1.Controls)
            {
                if(clt is TextBox)
                {
                    clt.Visible = false;
                }
            }
            int n = trb_1.Value;
            int i = 0;
            Arr.Clear();
            foreach(Control clt in grb_1.Controls)
            {
                clt.Visible = true;
                clt.Text = rd.Next(0, 16).ToString();
                Arr.Add(int.Parse(clt.Text));
                i++;
               if(n==0)
                {
                    clt.Visible = false;
                    break;
                }
                else if (i == n)
                    break;
            }
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rd = new Random();
            trb_1.Value = int.Parse(CB.SelectedItem.ToString());
            lb_1.Text = CB.SelectedItem.ToString();
            foreach(Control clt in grb_1.Controls)
            {
                if(clt is TextBox)
                {
                    clt.Visible = false;
                }
            }
            int n = int.Parse(CB.SelectedItem.ToString());
            int i = 0;
            Arr.Clear();
            foreach(Control clt in grb_1.Controls)
            {
                clt.Visible = true;
                clt.Text = rd.Next(0, 16).ToString();
                Arr.Add(int.Parse(clt.Text));
                i++;
                if (n == i)
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int t = 15;
            int l = 5;
            trb_1.Minimum = 0;
            trb_1.Maximum = 15;
            for (int i=1;i<=15;i++)
            {
                CB.Items.Add(i);
            }
           for(int i=1;i<=15;i++)
            {
                TextBox txt = new TextBox();
                txt.Multiline = false;
                txt.Enabled = false;
                txt.Width = 30;
                txt.Height = 30;
                txt.Left = l;
                l+=35;
                txt.Top = t;
                grb_1.Controls.Add(txt);
            }
           foreach(Control clt in grb_1.Controls)
            {
                if(clt is TextBox)
                {
                    clt.Visible = false;
                }
            }
        }

        private void btb(object sender, EventArgs e)
        {
            Button b = sender as Button;
            h = b.Text;
        }
        public bool snt(int n)
        {
            int d = 0;
            for(int i=1;i<=n;i++)
            {
                if (n % i == 0)
                    d++;
            }
            if (d == 2)
                return true;
            return false;
        }
        public int scp(int n)
        {
            for(int i=1;i<=(System.Math.Sqrt(n));i++)
            {
                if(i*i==n)
                {
                    return 1;
                }
            }
            return 0;
        }
        private void ketqua(object sender, EventArgs e)
        {
            if(h==""|| int.Parse(Arr.Count.ToString()) == 0)
            {
                MessageBox.Show("chưa chọn","Thông báo");
            }
            else 
            {
                txt_test.Clear();
                switch (h)
                {
                    case "Số nguyên tố":
                        {
                            foreach (int i in Arr)
                            {
                                if (snt(i) == true)
                                {
                                    txt_test.Text += i.ToString() + "  ";
                                }
                            }
                            h = "";
                            break;
                        }
                    case "Vị trí max":
                        {
                            int vt = 0;
                            int max = 0;
                            for(int i=0;i<Arr.Count;i++)
                            {
                                if(int.Parse(Arr[i].ToString())>max)
                                {
                                    max = int.Parse(Arr[i].ToString());
                                    vt = i + 1;;
                                }
                            }
                            txt_test.Text = "vị trí max= ";
                            txt_test.Text += vt.ToString() + "   ";
                            h = "";
                            break;
                        }
                    case "Bội chung 3 va 5 ":
                        {
                            foreach(int i in Arr)
                            {
                                if(i%3==0&&i%5==0)
                                {
                                    txt_test.Text = "Bội chung của 3 và 5 là: ";
                                    txt_test.Text += i.ToString();
                                }
                            }
                            h = "";
                            break;
                        }
                    case "Xóa số nguyên tố":
                        {
                            int d = 0;
                            int f = 0;
                          
                            ck_35.Checked = false;
                            ck_vtm.Checked = false;
                            break;
                        }
                    case "Số chính phương":
                        {
                            txt_test.Text = "Số chính phương: ";
                            foreach(int i in Arr)
                            {
                                if(scp(i)==1)
                                {
                                    txt_test.Text += i.ToString()+" ";
                                }
                            }
                            break;
                        }
                        
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void xoa(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            h = c.Text;
        }
    }
}
