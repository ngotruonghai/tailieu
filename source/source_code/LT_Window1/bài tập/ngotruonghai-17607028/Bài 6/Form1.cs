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

namespace Bài_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList Arr = new ArrayList();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txt_songuoi.Enabled = false;
            txt_sotien.Enabled = false;
            txt_thanhtien.Enabled = false;
            radioButton1.Checked = true;
            checkBox1.Checked = true;
            checkBox4.Checked = true;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void nhapchu(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dhuehueu(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(txt_name.Text==""||txt_ngay.Text==""||txt_diachi.Text=="")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ", "Thông báo");
            }
          else
            {
                int n = int.Parse(txt_ngay.Text);
                int tien = 0;
                int thanhtoan = 0;
                if (checkBox4.Checked)
                {
                    tien += 50;
                }
                if (checkBox5.Checked)
                {
                    tien += 15;
                }
                if (checkBox1.Checked)
                {
                    tien += 10;
                }
                if (checkBox2.Checked)
                {
                    tien += 10;
                }
                if (checkBox3.Checked)
                {
                    tien += 10;
                }
                if (radioButton1.Checked)
                {
                    tien += 300;
                }
                if (rd_2.Checked)
                {
                    tien += 350;
                }
                if (rd_3.Checked)
                {
                    tien += 400;
                }
                thanhtoan = tien * n;
                txt_thanhtien.Text = tien.ToString()+".000đ";
                Arr.Add(thanhtoan);
                thanhtoan = 0;
                tien = 0;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach(int i in Arr)
            {
                tong += i;
                txt_songuoi.Text = Arr.Count.ToString();
            }
            txt_sotien.Text = tong.ToString()+".000đ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_diachi.Text = "";
            txt_ngay.Text = "";
            radioButton1.Checked = true;
            checkBox1.Checked = true;
            checkBox4.Checked = true;
        }
    }
}
