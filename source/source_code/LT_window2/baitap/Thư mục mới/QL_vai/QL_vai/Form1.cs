using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
