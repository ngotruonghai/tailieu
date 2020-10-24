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

namespace ontap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList Arr = new ArrayList();
        int dem = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text == "" || txt_name.Text == ""||txt_soluongCDthue.Text==""||txt_dongia.Text=="")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ", "Thông báo");
            }
            else
            {
                double thanhtien = 0;
                int soluong = int.Parse(txt_soluongCDthue.Text);

            }
        }

        private void chu(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void so(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txt_thanhtien.Enabled = false;
            txt_tongtien.Enabled = false;
            txt_tongsoluongCD.Enabled = false;
            txt_trungbinh.Enabled = false;
        }
    }
}
