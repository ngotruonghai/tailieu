using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly
{
    public partial class QLBD : Form
    {
        public QLBD()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lsv_nv.View = View.Details;
            lsv_nv.FullRowSelect = true;
            lsv_nv.GridLines = true;
            lsv_nv.Columns.Add("Mã nhân viên ", 150);
            lsv_nv.Columns.Add("Tên nhân viên", 150);
            lsv_nv.Columns.Add("Phong ban",150);
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txt_maNV.Text==""||txt_phongban.Text==""||txt_tenNV.Text=="")
           {
               MessageBox.Show("Bạn chưa nhập thông tin dầy đủ", "Thông báo");
           }
            else
           {
               ListViewItem lsv = new ListViewItem(txt_maNV.Text);
               lsv.SubItems.Add(txt_tenNV.Text);
               lsv.SubItems.Add(txt_phongban.Text);
               lsv_nv.Items.Add(lsv);
           }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void chu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }     
        }

        private void lsv_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_nv.SelectedItems.Count>0)
            {
                button3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lsv_nv.Items.Count;i++)
            {
                if(lsv_nv.Items[i].Selected)
                {
                    lsv_nv.Items[i].Remove();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(lsv_nv.Items.Count>0)
            {
                lsv_nv.SelectedItems[0].Text = txt_maNV.Text;
                lsv_nv.SelectedItems[0].SubItems[1].Text = txt_tenNV.Text;
                lsv_nv.SelectedItems[0].SubItems[2].Text = txt_phongban.Text;
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
