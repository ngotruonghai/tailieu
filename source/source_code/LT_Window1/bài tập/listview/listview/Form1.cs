using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ls1_b1.Columns.Add("STT");
            ls1_b1.Columns.Add("Tên sách",100);
            ls1_b1.Columns.Add("Giá sách");
            ls1_b1.View = View.Details;
            ls1_b1.FullRowSelect = true;
            ls1_b1.GridLines = true;
            ls2_b1.Columns.Add("STT");
            ls2_b1.Columns.Add("Tên sách",100);
            ls2_b1.Columns.Add("Giá sách");
            ls2_b1.View = View.Details;
            ls2_b1.FullRowSelect = true;
            ls2_b1.GridLines = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem ls1 = new ListViewItem(ls1_b1.Items.Count.ToString());
            ls1.SubItems.Add(txt_tenach.Text);
            ls1.SubItems.Add(txt_giasach.Text);
            ls1_b1.Items.Add(ls1);
            button1.Focus();
            txt_soluong.Clear();
            txt_giasach.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem ls2 = new ListViewItem(ls2_b1.Items.Count.ToString());
            ls2.SubItems.Add(ls1_b1.SelectedItems[0].SubItems[1]);
            ls2.SubItems.Add(ls1_b1.SelectedItems[0].SubItems[2]);
            ls2_b1.Items.Add(ls2);
        }
    }
}
