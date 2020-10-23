using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace máy_tính
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string t;
        bool check;
        float valuse;
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
         
        }

        private void nt_nhan_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_ketqua_Click(object sender, EventArgs e)
        {
            switch (t)
            {
                case "+":
                    txt_nhap.Text = txt_bang.Text;
                    txt_bang.Text = (float.Parse(txt_bang.Text) + valuse).ToString();
                    break;
            }
        }
        private void number(object sender, EventArgs e)
        {
            if(t=="+")
            {
                if(check)
                {
                    //txt_nhapp.Text = txt_bang.Text;
                    check = false;
                    txt_bang.Text = "0";
                }
            }
            Button b = sender as Button;
            if(txt_bang.Text=="0")
            {
                txt_bang.Text = b.Text;
            }
            else
            {
                txt_bang.Text += b.Text;
            }
        }

        private void dau(object sender, EventArgs e)
        {
            Button b = sender as Button;
            t = b.Text;
            valuse = float.Parse(txt_bang.Text);
            txt_bang.Text = txt_bang.Text + b.Text;
            txt_nhapp.Text =txt_bang.Text;
            check = true;
        }
    }
}
