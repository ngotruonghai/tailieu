using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        int dem = 0;
        int giainhat = 0;
        int giainhi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            dem++;
            int a = rd.Next(0,10);
            int b = rd.Next(0, 10);
            int c = rd.Next(0, 10);
            txt_bang1.Text = a.ToString();
            txt_bang2.Text = b.ToString();
            txt_bang3.Text = c.ToString();
            txt_solanquay.Text = dem.ToString();
            if(a==b || b==c)
            {
                giainhi++;
                txt_gainhi.Text = giainhi.ToString();
            }
            else if(a==b && a==c && b==c)
            {
                giainhat++;
                txt_giainhat.Text = giainhat.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "vòng quay star")
            {
                button2.Text = " Stop";
                time_1.Start();
            }
            else
            {
                time_1.Stop();
                button2.Text = "vòng quay star";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dem++;
            int a = rd.Next(0, 10);
            int b = rd.Next(0, 10);
            int c = rd.Next(0, 10);
            txt_bang1.Text = a.ToString();
            txt_bang2.Text = b.ToString();
            txt_bang3.Text = c.ToString();
            txt_solanquay.Text = dem.ToString();
            if (a == b || b == c)
            {
                giainhi++;
                txt_gainhi.Text = giainhi.ToString();
            }
            else if (a == b && a == c && b == c)
            {
                giainhat++;
                txt_giainhat.Text = giainhat.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_bang1.Text = "";
            txt_bang2.Text = "";
            txt_bang3.Text = "";
            txt_gainhi.Text = "";
            txt_giainhat.Text = "";
            txt_solanquay.Text = "";
            dem = 0;
            giainhat = 0;
            giainhi = 0;
            time_1.Stop();
            time_2.Stop();
            time_2.Interval = 50;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            time_2.Start();
            
        }

        private void time_2_Tick(object sender, EventArgs e)
        {
    
            time_2.Interval += 50;
            txt_time.Text = time_2.Interval.ToString();
            dem++;
            int a = rd.Next(0, 10);
            int b = rd.Next(0, 10);
            int c = rd.Next(0, 10);
            txt_bang1.Text = a.ToString();
            txt_bang2.Text = b.ToString();
            txt_bang3.Text = c.ToString();
            txt_solanquay.Text = dem.ToString();
            if (a == b || b == c)
            {
                giainhi++;
                txt_gainhi.Text = giainhi.ToString();
            }
            else if (a == b && a == c && b == c)
            {
                giainhat++;
                txt_giainhat.Text = giainhat.ToString();
            }
            if (time_2.Interval == 600)
            {
                time_2.Stop();
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = rd.Next(65, 91);
            int b = rd.Next(65, 91);
            int c = rd.Next(65, 91);
            txt_bang1.Text = Convert.ToChar(a).ToString();
            txt_bang2.Text = Convert.ToChar(b).ToString();
            txt_bang3.Text = Convert.ToChar(c).ToString();
        }
    }
}
