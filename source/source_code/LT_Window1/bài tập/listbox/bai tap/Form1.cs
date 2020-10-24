using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_tap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d1 = cb_tramrang.Value.ToString();
            int tong = 0;
            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("Không có tên khách hàng", "Thông báo");
            }
            else
            {
                if (cb_tramrang.Value >= 0 && cb_caovoi.Checked)
                {
                    tong = 100 + int.Parse(d1) * 80;
                    txt_giatien.Text = tong.ToString() + ".000$";
                }
                if (cb_tramrang.Value >= 0 && cb_caovoi.Checked && cb_tayrang.Checked)
                {
                    tong = 100 + int.Parse(d1) * 80 + 1200;
                    txt_giatien.Text = tong.ToString() + ".000$";
                }
                if (cb_tramrang.Value >= 0 && cb_tayrang.Checked)
                {
                    tong = 1200 + int.Parse(d1) * 80;
                    txt_giatien.Text = tong.ToString() + ".000$";
                }
                if (cb_tramrang.Value >= 0 && cb_chuphinhrang.Checked)
                {
                    tong = 200 + int.Parse(d1) * 80;
                    txt_giatien.Text = tong.ToString() + ".000$";
                }
                if (cb_tramrang.Value >= 0 && cb_caovoi.Checked && cb_tayrang.Checked && cb_chuphinhrang.Checked)
                {
                    tong = 100 + int.Parse(d1) * 80 + 1200 + 200;
                    txt_giatien.Text = tong.ToString() + ".000$";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb_ketqua.Items.Clear();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            lb_ketqua.Items.Add(txt_songuyen.Text.Trim());
            txt_songuyen.Clear();
            txt_songuyen.Focus();
        }

        private void bt_tang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_ketqua.Items.Count; i++)
            {
                lb_ketqua.Items[i] = int.Parse(lb_ketqua.Items[i].ToString()) + 2;
            }
        }

        private void bt_chandau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_ketqua.Items.Count; i++)
            {
                if (int.Parse(lb_ketqua.Items[i].ToString()) % 2 == 0)
                {
                    lb_ketqua.SelectedIndex = i;
                    break;
                }
            }
        }

        private void bt_lecuoi_Click(object sender, EventArgs e)
        {
            for (int i = lb_ketqua.Items.Count - 1; i > 0; i--)
            {
                if (int.Parse(lb_ketqua.Items[i].ToString()) % 2 == 0)
                {
                    lb_ketqua.SelectedIndex = i;
                    break;
                }
            }
        }

        private void bt_xoadangchon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_ketqua.Items.Count; i++)
            {
                if (lb_ketqua.SelectedIndex == i)
                {
                    lb_ketqua.Items.RemoveAt(i);
                }

            }

        private void bt_xoadau_Click(object sender, EventArgs e)
        {
            /*if (lb_ketqua.Items.Count - 1 != 0)
            {
                lb_ketqua.Items.RemoveAt(lb_ketqua.Items.Count - 1);
            }*/
            //int n = lb_ketqua.Items.Count - 1;
           // lb_ketqua.Items.Remove(lb_ketqua.Items[0].ToString());
           for(int i=0;i<=lb_ketqua.Items.Count;i++)
            {
                lb_ketqua.Items.RemoveAt(i);
                break;
            }
        }

        private void bt_xoacuoi_Click(object sender, EventArgs e)
        {
            int n = lb_ketqua.Items.Count;
            lb_ketqua.Items.Remove(lb_ketqua.Items[n - 1].ToString());
        }

        private void bt_moi_Click(object sender, EventArgs e)
        {
            lb_trai.Items.Clear();
            lb_phai.Items.Clear();
        }

        private void bt_capnhat5_Click(object sender, EventArgs e)
        {
            lb_trai.Items.Add(txt_n.Text);
            txt_n.Clear();
            txt_n.Focus();
        }

        private void bt_trai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_phai.Items.Count; i++)
            {
                if (lb_phai.SelectedIndex == i)
                {
                    lb_trai.Items.Add(lb_phai.Items[i].ToString());
                    lb_phai.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void bt_phai_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < lb_trai.Items.Count; i++)
            {
                if (lb_trai.SelectedIndex == i)
                {
                    lb_phai.Items.Add(lb_trai.Items[i].ToString());
                    lb_trai.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void bt_traitrai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_phai.Items.Count; i++)
            {
                lb_trai.Items.Add(lb_phai.Items[i].ToString());
            }
            for (int i = lb_phai.Items.Count - 1; i >= 0; i--)
            {
                lb_phai.Items.RemoveAt(i);
            }
        }

        private void bt_phaiphai_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lb_trai.Items.Count;i++)
            {
                lb_phai.Items.Add(lb_trai.Items[i].ToString());
            }
            for(int i=lb_trai.Items.Count-1;i>=0;i--)
            {
                lb_trai.Items.RemoveAt(i);
            }
        }
    }
}