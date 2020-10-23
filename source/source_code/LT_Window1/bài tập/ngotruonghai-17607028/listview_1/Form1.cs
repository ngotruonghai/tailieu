using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsv_nhanvien.Columns.Add("Họ tên",100);
            lsv_nhanvien.Columns.Add("Ngày sinh", 200);
            lsv_nhanvien.Columns.Add("Địa chỉ", 150);
            lsv_nhanvien.Columns.Add("Điện thoại",135);
            lsv_nhanvien.View = View.Details;
            lsv_nhanvien.FullRowSelect = true;
            lsv_nhanvien.GridLines = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lsv = new ListViewItem(txt_name.Text);
            lsv.SubItems.Add(datetime.Text);
            lsv.SubItems.Add(txt_dc.Text);
            lsv.SubItems.Add(txt_sdt.Text);
            lsv_nhanvien.Items.Add(lsv);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lsv_nhanvien.Items.Count;i++)
            {
                if(lsv_nhanvien.Items[i].Selected)
                {
                    lsv_nhanvien.Items[i].Remove();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(lsv_nhanvien.SelectedItems.Count>0)
            {
                lsv_nhanvien.SelectedItems[0].SubItems[0].Text = txt_name.Text;
                lsv_nhanvien.SelectedItems[0].SubItems[1].Text = txt_dc.Text;
                lsv_nhanvien.SelectedItems[0].SubItems[2].Text = txt_sdt.Text;
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
