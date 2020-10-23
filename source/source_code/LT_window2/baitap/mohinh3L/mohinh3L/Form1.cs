using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mohinh3L.BLL;
namespace mohinh3L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void hienthidsDG()
        {
            DocGia dg = new DocGia();
            DataTable dsdg = dg.LayDSDocgia();
            cb_name.DataSource = dsdg;
            cb_name.DisplayMember = "Hotendocgia";
            cb_name.ValueMember = "Madocgia";
        }
        public void Hienthiphieumuon()
        {
            lsv_NV.Items.Clear();
            phieumuon pm = new phieumuon();
            DataTable data = pm.DSphieumuon();
            for(int i=0;i<data.Rows.Count;i++)
            {
                ListViewItem lsv = new ListViewItem(data.Rows[i]["Maphieumuonsach"].ToString());
                lsv.SubItems.Add(data.Rows[i]["Hotendocgia"].ToString());
                lsv.SubItems.Add(data.Rows[i]["Ngaymuon"].ToString());
                lsv_NV.Items.Add(lsv);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienthidsDG();
            lsv_NV.View = View.Details;
            lsv_NV.FullRowSelect = true;
            lsv_NV.GridLines = true;
            lsv_NV.Columns.Add("Ma phiếu mượn",50);
            lsv_NV.Columns.Add("Họ tên đọc giả",200);
            lsv_NV.Columns.Add("Ngay mượn",200);
            Hienthiphieumuon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", date.Value);
            string ma = cb_name.SelectedValue.ToString();
            DocGia pm = new DocGia();
            pm.them(ngay, ma);
            Hienthiphieumuon();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            phieumuon pm=new phieumuon();
            pm.xoaPM(lsv_NV.SelectedItems[0].SubItems[0].Text);
            Hienthiphieumuon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maDG = cb_name.SelectedValue.ToString();
            string maPM = lsv_NV.SelectedItems[0].SubItems[0].Text;
            string tenDG = lsv_NV.SelectedItems[0].SubItems[1].Text;
            chitietphiemuon c = new chitietphiemuon(maDG, maPM, tenDG);
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            phieumuon pm = new phieumuon();
            Form2 f = new Form2(pm.DSphieumuon());
            f.Show();

        }
    }
}
