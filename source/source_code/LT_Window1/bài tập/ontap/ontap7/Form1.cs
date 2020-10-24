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

namespace ontap7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int thanhtien = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lsv_1.View = View.Details;
            lsv_1.FullRowSelect = true;
            lsv_1.GridLines = true;
            lsv_1.Columns.Add("Mã phòng", 100);
            lsv_1.Columns.Add("Ngày thuê",100);
            lsv_1.Columns.Add("Giá phòng",100);
            lsv_1.Columns.Add("Dịch vụ",100);
            lsv_1.Columns.Add("Tính tiền", 100);
            cbox.Items.Add("Thuê xe");
            cbox.Items.Add("Giặt đồ");
            cbox.Items.Add("Hướng dẫn viên");
            bt_sua.Enabled = false;
            cbox.Text = "không có";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_giaphong.Text == "" || txt_ma.Text == "" || txt_ngaythue.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin đầy đủ", "Thông báo");
            }
            else
            {
                string cb = cbox.Text;
                int giaphong = 1;
                int ngaythue = 1;
                int dem = 0;
                ListViewItem lsv = new ListViewItem(txt_ma.Text);
                lsv.SubItems.Add(txt_ngaythue.Text);
                lsv.SubItems.Add(txt_giaphong.Text);
                lsv.SubItems.Add(cbox.Text);
                if (cb == "Thuê xe")
                {
                    ngaythue = int.Parse(txt_ngaythue.Text);
                    giaphong = int.Parse(txt_giaphong.Text);
                    thanhtien = (giaphong * ngaythue) + 900;
                }
                if (cb == "Giặt đồ")
                {
                    ngaythue = int.Parse(txt_ngaythue.Text);
                    giaphong = int.Parse(txt_giaphong.Text);
                    thanhtien = (giaphong * ngaythue) + 200;
                }
                if (cb == "Hướng dẫn viên")
                {
                    ngaythue = int.Parse(txt_ngaythue.Text);
                    giaphong = int.Parse(txt_giaphong.Text);
                    thanhtien = (giaphong * ngaythue) + 500;
                }
                if (cb == "không có")
                {
                    ngaythue = int.Parse(txt_ngaythue.Text);
                    giaphong = int.Parse(txt_giaphong.Text);
                    thanhtien = (giaphong * ngaythue) ;
                }
            
                lsv.SubItems.Add(thanhtien.ToString());
                lsv_1.Items.Add(lsv);
                if (lsv_1.Items.Count >= 2)
                {
                    for (int i = 0; i < lsv_1.Items.Count; i++)
                    {
                        for (int j = i + 1; j < lsv_1.Items.Count; j++)
                        {
                            if (lsv_1.Items[i].Text == lsv_1.Items[j].Text && i != j)
                            {
                                dem++;
                                lsv_1.Items[j].Remove();
                            }
                        }
                    }
                    if (dem > 0)
                    {
                        MessageBox.Show("Bị trùng mã phòng","Thông báo");

                    }
                }
                for(int i=0;i<lsv_1.Items.Count;i++)
                {
                    giaphong = int.Parse(lsv_1.Items[i].SubItems[2].Text);
                    ngaythue= int.Parse(lsv_1.Items[i].SubItems[1].Text);
                }
                if(cb== "Thuê xe")
                {
                    thanhtien = (giaphong * ngaythue) + 500;
                }
                button1.Focus();
                txt_giaphong.Text = "";
                txt_ma.Text = "";
                txt_ngaythue.Text = "";
                cbox.Text = "không có";
            }
        }

        private void so(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsv_1.SelectedItems[0].SubItems[0].Text = txt_ma.Text;
            lsv_1.SelectedItems[0].SubItems[1].Text = txt_ngaythue.Text;
            lsv_1.SelectedItems[0].SubItems[2].Text = txt_giaphong.Text;
            lsv_1.SelectedItems[0].SubItems[3].Text = cbox.Text;
            int giaphong = 1;
            int ngaythue = 1;
            string cb = cbox.Text;
            if (cbox.Text=="không có")
            {
                ngaythue = int.Parse(txt_ngaythue.Text);
                giaphong = int.Parse(txt_giaphong.Text);
                thanhtien = giaphong * ngaythue;
            }
            else if (cb == "Thuê xe")
            {
                ngaythue = int.Parse(txt_ngaythue.Text);
                giaphong = int.Parse(txt_giaphong.Text);
                thanhtien = (giaphong * ngaythue) + 900;
            }
             else if (cb == "Giặt đồ")
            {
                ngaythue = int.Parse(txt_ngaythue.Text);
                giaphong = int.Parse(txt_giaphong.Text);
                thanhtien = (giaphong * ngaythue) + 200;
            }
           else if (cb == "Hướng dẫn viên")
            {
                ngaythue = int.Parse(txt_ngaythue.Text);
                giaphong = int.Parse(txt_giaphong.Text);
                thanhtien = (giaphong * ngaythue) + 500;
            }
            lsv_1.SelectedItems[0].SubItems[4].Text = thanhtien.ToString();
            button1.Focus();
            txt_giaphong.Text = "";
            txt_ma.Text = "";
            txt_ngaythue.Text = "";
            cbox.Text = "không có";
            bt_sua.Enabled = false;
        }

        private void lsv_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_1.SelectedItems.Count>0)
            {
                bt_sua.Enabled = true;
            }
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
