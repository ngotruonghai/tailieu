﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_vai
{
    public partial class menutrip : Form
    {
        public menutrip()
        {
            InitializeComponent();
        }
        private void menutrip_Load(object sender, EventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            LSV_vai.View = View.Details;
            LSV_vai.FullRowSelect = true;
            LSV_vai.GridLines = true;
            LSV_vai.Columns.Add("STT", 50);
            LSV_vai.Columns.Add("Mã mặt hàng", 150);
            LSV_vai.Columns.Add("Tên mặt hàng", 180);
            LSV_vai.Columns.Add("Ngày lấy", 100);
            LSV_vai.Columns.Add("Kho", 100);
            LSV_vai.Columns.Add("Giá tiền", 100);
            LSV_vai.Columns.Add("...", 100);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime d = DateTime.Now;
            Lb_ngay.Text = d.ToString("dd/MM/yyyy");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timKiêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            
        }

        private void menutrip_Load_1(object sender, EventArgs e)
        {

        }
    }
}
