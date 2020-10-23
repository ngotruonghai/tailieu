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

namespace Xử_lý_chuỗi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_kq.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            string chuoi = txt_name.Text;
            string chuoicon = txt_tim.Text;
            int vitri = 0;
            vitri = chuoi.IndexOf(chuoicon,vitri);
            arr.Add(vitri + 1);
            while(chuoi.IndexOf(chuoicon,vitri+1)>0)
            {
                vitri = chuoi.IndexOf(chuoicon, vitri + 1);
                arr.Add(vitri +1);
            }
            txt_kq.Text = "Tại vị trí: ";
            foreach(int i in arr)
            {
                txt_kq.Text += i.ToString()+"  ";
                txt_kq.Text.Trim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_kq.Clear();
            txt_kq.Text = txt_name.Text.Replace(txt_tim.Text, txt_doi.Text);
        }
    }
}
