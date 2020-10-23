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
    public partial class chitietphiemuon : Form
    {
        string madg;
        string mapm;
        string tendg;
        public void hienthisachdaco()
        {
            lsv_sachdangco.Items.Clear();
            sach s = new sach();
            DataTable dt = s.hienthisachCO();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lsv = new ListViewItem(dt.Rows[i]["Masach"].ToString());
                lsv.SubItems.Add(dt.Rows[i]["Tensach"].ToString());
                lsv.SubItems.Add(dt.Rows[i]["Tacgia"].ToString());
                lsv.SubItems.Add(dt.Rows[i]["Namxuatban"].ToString());
                lsv.SubItems.Add(dt.Rows[i]["Nhaxuatban"].ToString());
                lsv.SubItems.Add(dt.Rows[i]["Trigia"].ToString());
                lsv.SubItems.Add(dt.Rows[i]["Ngaynhap"].ToString());
                lsv_sachdangco.Items.Add(lsv);
            }
        }
        private void chitietphiemuon_Load(object sender, EventArgs e)
        {
            lsv_sachdangco.View = View.Details;
            lsv_sachdachon.View = View.Details;
            lsv_sachdachon.FullRowSelect = true;
            lsv_sachdangco.FullRowSelect = true;
            lsv_sachdangco.GridLines = true;
            lsv_sachdachon.GridLines = true;
            lsv_sachdachon.Columns.Add("Masach");
            lsv_sachdachon.Columns.Add("Ten Sách", 150);
            lsv_sachdachon.Columns.Add("tác giả", 150);
            lsv_sachdachon.Columns.Add("Nam XB");
            lsv_sachdachon.Columns.Add("Nhà XB");
            lsv_sachdachon.Columns.Add("Trị giá");
            lsv_sachdachon.Columns.Add("Ngày nhập");

            lsv_sachdangco.Columns.Add("MaSP");
            lsv_sachdangco.Columns.Add("Ten Sách", 150);
            lsv_sachdangco.Columns.Add("tác giả", 150);
            lsv_sachdangco.Columns.Add("Nam XB");
            lsv_sachdangco.Columns.Add("Nhà XB");
            lsv_sachdangco.Columns.Add("Trị giá");
            lsv_sachdangco.Columns.Add("Ngày nhập");
            hienthisachdaco();
            hienthidanhsachmuon();
        }
        public chitietphiemuon(string maDG, string maPM, string tenDG)
        {
            InitializeComponent();
            lb_hoten.Text = tenDG;
            lb_ma.Text = maPM;
            madg = maDG;
            tendg = tenDG;
            mapm = maPM;
        }
        public void hienthidanhsachmuon()
        {
            lsv_sachdachon.Items.Clear();
            sach s = new sach();
            DataTable dt = s.hienthisachMuon(mapm);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lsv = new ListViewItem(dt.Rows[i]["Masach"].ToString());
                lsv.SubItems.Add(dt.Rows[i]["Tensach"].ToString());
                lsv_sachdachon.Items.Add(lsv);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maS = lsv_sachdangco.SelectedItems[0].SubItems[0].Text;
            sach s = new sach();
            s.themsachmuon(maS,mapm);
            hienthidanhsachmuon();
        }
    }
}
