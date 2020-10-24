using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        Random rd = new Random();
        int quay = 0;
        int nhat = 0;
        int nhi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rd.Next(0, 10);
            int b = rd.Next(0, 10);
            int c = rd.Next(0, 10);
            txt_bang1.Text = a.ToString();
            txt_bang2.Text = b.ToString();
            txt_bang3.Text = c.ToString();
            quay++;
            lb_solanquay.Text = quay.ToString();
            if(a==b||b==c||a==c)
            {
                nhi++;
                lb_giainhi.Text = nhi.ToString();
            }
            else if(a==b && a==c)
            {
                nhat++;
                lb_giainhat.Text = nhat.ToString();
            }
        }

        private void time_vongquay_Tick(object sender, EventArgs e)
        {
            int a = rd.Next(0, 10);
            int b = rd.Next(0, 10);
            int c = rd.Next(0, 10);
            txt_bang1.Text = a.ToString();
            txt_bang2.Text = b.ToString();
            txt_bang3.Text = c.ToString();
            quay++;
            lb_solanquay.Text = quay.ToString();
            if (a == b || b == c || a == c)
            {
                nhi++;
                lb_giainhi.Text = nhi.ToString();
            }
            else if (a == b && a == c)
            {
                nhat++;
                lb_giainhat.Text = nhat.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(bt_vongquay.Text== "vong quay")
            {
                time_vongquay.Start();
                bt_vongquay.Text = "Stop";
            }
            else
            {
                time_vongquay.Stop();
                bt_vongquay.Text = "vong quay";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txt_bang1.Text = "";
            txt_bang2.Text = "";
            txt_bang3.Text = "";
            quay = 0;
            nhat = 0;
            nhi = 0;
            lb_giainhat.Text = "";
            lb_giainhi.Text = "";
            lb_solanquay.Text = "";
            time_vongquay.Stop();
            time_2.Stop();
            time_2.Interval = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time_2.Start() ;
            lb_chu.Text = "Đang quay Auto..";
        }

        private void time_2_Tick(object sender, EventArgs e)
        {
            time_2.Interval += 50;
            lb_so.Text = time_2.Interval.ToString();
            int a = rd.Next(0, 10);
            int b = rd.Next(0, 10);
            int c = rd.Next(0, 10);
            txt_bang1.Text = a.ToString();
            txt_bang2.Text = b.ToString();
            txt_bang3.Text = c.ToString();
            quay++;
            lb_solanquay.Text = quay.ToString();
            if (a == b || b == c || a == c)
            {
                nhi++;
                lb_giainhi.Text = nhi.ToString();
            }
            else if (a == b && a == c)
            {
                nhat++;
                lb_giainhat.Text = nhat.ToString();
            }
            if(time_2.Interval==600)
            {
                time_2.Stop();
                lb_chu.Text = "Vòng quay may mắn";
            }
        }
    }
}
