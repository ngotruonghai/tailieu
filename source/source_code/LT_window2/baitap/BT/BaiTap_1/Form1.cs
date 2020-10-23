using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace BaiTap_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter A;
        DataSet data = new DataSet();
        public string server = "haingo1999";
        public string database = "QLTV";
        void ketnoi()
        {
            string scon = "server=" + server + ";database=" + database + ";Integrated Security=True";
            con = new SqlConnection(scon);
        }
        DataTable docdanhsach()
        {
            data.Tables.Clear();
            string sql = "select*from Nhanvien";
            A = new SqlDataAdapter(sql, con);
            A.Fill(data);
            return data.Tables[0];
        }
        public void loadlsv()
        {
            lsv_nhanvien.Items.Clear();
            lsv_nhanvien.View = View.Details;
            lsv_nhanvien.FullRowSelect = true;
            DataTable dt = docdanhsach();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                ListViewItem lsv = new ListViewItem();
                lsv = new ListViewItem(dt.Rows[i][1].ToString());
                lsv.SubItems.Add(dt.Rows[i][2].ToString());
                lsv.SubItems.Add(dt.Rows[i][3].ToString());
                lsv.SubItems.Add(dt.Rows[i][4].ToString());
                lsv.SubItems.Add(dt.Rows[i][5].ToString());
                lsv_nhanvien.Items.Add(lsv);
            }
        }
        public void txt_trong()
        {
            txt_diachi.Text = "";
            txt_name.Text = "";
            txt_SDT.Text = "";

        }
        public void mabc()
        {
            string sql = "select*from Bangcap";
            A = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            A.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Tenbangcap";
            comboBox1.ValueMember = "Mabangcap";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lsv_nhanvien.View = View.Details;
            lsv_nhanvien.GridLines = true;
            lsv_nhanvien.FullRowSelect = true;
            lsv_nhanvien.Columns.Add("Họ Tên", 150);//0
            lsv_nhanvien.Columns.Add("Ngày Sinh", 150);//1
            lsv_nhanvien.Columns.Add("Địa Chỉ", 260);//2
            lsv_nhanvien.Columns.Add("Điện Thoại", 100);//3
            lsv_nhanvien.Columns.Add("Bằng cấp", 100);//4
            ketnoi();
            loadlsv();
            button2.Enabled = false;
            button3.Enabled = false;
            mabc();
        }

        private void nhapchu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nhapso(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            }

            private void lsv_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0;i<lsv_nhanvien.Items.Count;i++)
            {
                if(lsv_nhanvien.Items[i].Selected)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    txt_name.Enabled = false;
                    txt_name.Text = lsv_nhanvien.Items[i].SubItems[0].Text;
                    txt_diachi.Text = lsv_nhanvien.Items[i].SubItems[2].Text;
                    txt_SDT.Text = lsv_nhanvien.Items[i].SubItems[3].Text;
                    date_ngaysinh.Text = lsv_nhanvien.Items[i].SubItems[1].Text;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(txt_diachi.Text==""||txt_name.Text==""||txt_SDT.Text=="")
            //{
            //    MessageBox.Show("Bạn chưa nhập thông tin đầy đủ","Thông Báo");
            //}
            //else
            //{
                string ten = txt_name.Text;
                string diachi = txt_diachi.Text;
                string sdt = txt_SDT.Text;
                string date = string.Format("{0:MM/dd/yyyy}", date_ngaysinh.Value);
                string BC = comboBox1.SelectedValue.ToString();
               // MessageBox.Show(BC);
                string sql = string.Format("Insert into Nhanvien Values(N'{0}','{1}',N'{2}','{3}','{4}')",ten,date,diachi,sdt,BC);
                string scon = "server=" + server + ";database=" + database + ";Integrated Security=True";
                SqlConnection con = new SqlConnection(scon);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                loadlsv();
                txt_trong();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (D)
            {
                case DialogResult.No:
                    {
                        break;
                    }
                case DialogResult.Yes:
                    {
                        string sql = string.Format("delete from Nhanvien where Hotennhanvien='" + txt_name.Text + "'");
                        string scon = "server=" + server + ";database=" + database + ";Integrated Security=True";
                        SqlConnection con = new SqlConnection(scon);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        loadlsv();
                        txt_trong();
                        break;
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = string.Format("{0:MM/dd/yyyy}", date_ngaysinh.Value);
            string BC = comboBox1.SelectedValue.ToString();
            string sql = string.Format("update Nhanvien set Diachi='" + txt_diachi.Text + "',Ngaysinh='" + date + "',Dienthoai='" + txt_SDT.Text + "',Mabangcap='" + BC + "' where Hotennhanvien='" + txt_name.Text + "'");
            string scon = "server=" + server + ";database=" + database + ";Integrated Security=True";
            SqlConnection con = new SqlConnection(scon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            loadlsv();
            txt_trong();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (D)
            {
                case DialogResult.No:
                    {
                        break;
                    }
                case DialogResult.Yes:
                    {
                        this.Close();
                        break;
                    }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_name.Enabled = true;
            txt_trong();
        }
    }
}
