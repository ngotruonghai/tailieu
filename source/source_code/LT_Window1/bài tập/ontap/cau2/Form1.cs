using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cb1.Items.Add("12 ");
            cb1.Items.Add("24 ");
            cb1.Items.Add("36 ");
            lsv1.View = View.Details;
            lsv1.FullRowSelect = true;
            lsv1.GridLines = true;
            lsv1.Columns.Add("Mã");
            lsv1.Columns.Add("Họ tên",100);
            lsv1.Columns.Add("Số tiền vay",100);
            lsv1.Columns.Add("Lãi xuất tháng",100);
            lsv1.Columns.Add("Số tiền phải trả mỗi tháng", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sotienvay = double.Parse(txt_sotienvay.Text);
            double laisuat = (double.Parse(txt_laisuat.Text) / 100);
            double thanhtien = (sotienvay / int.Parse(cb1.Text)) * laisuat;
            ListViewItem lsv = new ListViewItem(txt_ma.Text);
            lsv.SubItems.Add(txt_name.Text);
            lsv.SubItems.Add(txt_sotienvay.Text);
            lsv.SubItems.Add(txt_laisuat.Text);
            lsv.SubItems.Add(thanhtien.ToString());
            lsv1.Items.Add(lsv);
            int d = 0;
            if(lsv1.Items.Count>=2)
            {
                for(int i=0;i<lsv1.Items.Count;i++)
                {
                    for(int j=i+1;j<lsv1.Items.Count;j++)
                    {
                        if(lsv1.Items[i].Text==lsv1.Items[j].Text&&i!=j)
                        {
                            d++;
                            lsv1.Items[j].Remove();
                        }
                    }
                }
                if(d>0)
                {
                    MessageBox.Show("Bi trung ma", "Thong bao");
                }
            }
            thanhtien = 0;
            txt_name.Text = "";
            txt_ma.Text = "";
            txt_laisuat.Text = "";
            txt_sotienvay.Text = "";
        }

        private void lsv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv1.SelectedItems.Count>0)
            {
                txt_ma.Text = lsv1.SelectedItems[0].Text;
                txt_name.Text = lsv1.SelectedItems[0].SubItems[1].Text;
                txt_sotienvay.Text = lsv1.SelectedItems[0].SubItems[2].Text;
                txt_laisuat.Text = lsv1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sotienvay = double.Parse(txt_sotienvay.Text);
            double laisuat = (double.Parse(txt_laisuat.Text) / 100);
            double thanhtien = (sotienvay / int.Parse(cb1.Text)) * laisuat;
            lsv1.SelectedItems[0].Text = txt_ma.Text;
            lsv1.SelectedItems[0].SubItems[1].Text = txt_name.Text;
            lsv1.SelectedItems[0].SubItems[2].Text = txt_sotienvay.Text;
            lsv1.SelectedItems[0].SubItems[3].Text = txt_laisuat.Text;
            lsv1.SelectedItems[0].SubItems[4].Text = thanhtien.ToString();
            txt_name.Text = "";
            txt_ma.Text = "";
            txt_laisuat.Text = "";
            txt_sotienvay.Text = "";
        }
    }
}
