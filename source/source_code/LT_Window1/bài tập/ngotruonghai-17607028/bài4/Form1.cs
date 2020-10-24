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

namespace bài4
{
    public partial class Form1 : Form
    {
        string t="";
        int dem = 0;
        ArrayList Arr = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        private void cafe(object sender, EventArgs e)
        {
            RadioButton b = sender as RadioButton;
            t = b.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            button3.Enabled = false;
            txt_tongkhachhang.Enabled = false;
            txt_tongtien.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_tongkhachhang.Clear();
            txt_tongtien.Clear();
            double tongtien = 0;
            foreach(double h in Arr)
            {
                tongtien += h;
                txt_tongtien.Text = tongtien.ToString()+".000đ";
            }
             dem++;
             txt_tongkhachhang.Text = dem.ToString();
             Arr.Clear();
             button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Chưa nhâp tên", "Thông báo");
            }
            else
            {
                button3.Enabled = true;
                int tien;
                double thanhtien;
                switch (t)
                {
                    case "cafe đen":
                        {
                            tien = 20;
                            if (cb_sinhvien.Checked)
                            {
                                thanhtien = tien - tien * 0.2;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "với giá :" + thanhtien.ToString()+".000đ"+" (Sinh viên)");
                            }
                            else
                            {
                                thanhtien = tien;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "\t với giá :" + thanhtien.ToString()+".000đ");
                            }
                            break;
                        }
                    case "cafe sữa":
                        {
                            tien = 25;
                            if (cb_sinhvien.Checked)
                            {
                                thanhtien = tien - tien * 0.2;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "với giá :" + thanhtien.ToString() + ".000đ" + " (Sinh viên)");
                            }
                            else
                            {
                                thanhtien = tien;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "\t với giá :" + thanhtien.ToString() + ".000đ");
                            }
                            break;
                        }
                    case "cafe sữa đá":
                        {
                            tien = 30;
                            if (cb_sinhvien.Checked)
                            {
                                thanhtien = tien - tien * 0.2;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "với giá :" + thanhtien.ToString() + ".000đ" + " (Sinh viên)");
                            }
                            else
                            {
                                thanhtien = tien;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "\t với giá :" + thanhtien.ToString() + ".000đ");
                            }
                            break;
                        }
                    case "cafe đá":
                        {
                            tien = 25;
                            if (cb_sinhvien.Checked)
                            {
                                thanhtien = tien - tien * 0.2;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "với giá :" + thanhtien.ToString() + ".000đ" + " (Sinh viên)");
                            }
                            else
                            {
                                thanhtien = tien;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "\t với giá :" + thanhtien.ToString() + ".000đ");
                            }
                            break;
                        }
                    case "cafe kem ":
                        {
                            tien = 35;
                            if (cb_sinhvien.Checked)
                            {
                                thanhtien = tien - tien * 0.2;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "với giá :" + thanhtien.ToString() + ".000đ" + " (Sinh viên)");
                            }
                            else
                            {
                                thanhtien = tien;
                                Arr.Add(thanhtien);
                                MessageBox.Show("Bạn đã mua " + t + "\t với giá :" + thanhtien.ToString() + ".000đ");
                            }
                            break;
                        }
                }
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            cb_sinhvien.Checked = false;
        }
    }
}
