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
    public partial class hh : Form
    {
        public hh()
        {
            InitializeComponent();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menu_QLNV_Click(object sender, EventArgs e)
        {
            QLNV ql = new QLNV();
            ql.MdiParent = this;
            ql.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýDanhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSP ql=new QLSP();
            ql.MdiParent = this;
            ql.Show();
        }

        private void quảnLýBăngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLBD p = new QLBD();
            p.MdiParent = this;
            p.Show(); 
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLp p = new QLp();
            this.Hide();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("bạn có muốn thoát ko", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (thoat)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void kkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kk k = new kk();
            k.MdiParent = this;
            k.Show();
        }

        private void kkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 l = new Form3();
            l.MdiParent = this;
            l.Show();
        }
    }
}
