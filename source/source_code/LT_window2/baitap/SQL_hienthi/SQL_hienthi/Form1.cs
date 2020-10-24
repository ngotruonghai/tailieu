using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL_hienthi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ma = "";
        SqlConnection con;
        SqlDataAdapter A;
        DataSet datas = new DataSet();//chứa kết quả truy vấn
        public string sever = "HAINGO1999";
        public string database = "nhanvien";
        void ketnoiSQL()
        {
            datas.Tables.Clear();
            string cons = "server=" + sever + "; Integrated Security=true; database=" + database;
            con = new SqlConnection(cons);
        }
        DataTable docdanhsach()//phục vụ cho loadlistview();
        {
            datas.Tables.Clear();
            string sql = "select*from nhanvien";
            A = new SqlDataAdapter(sql, con);
            A.Fill(datas);
            return datas.Tables[0];
        }
        public void loadlistview()
        {
            lsv_nhanvien.Items.Clear();
            lsv_nhanvien.View = View.Details;
            lsv_nhanvien.FullRowSelect = true;
            DataTable data = docdanhsach();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ListViewItem lsv = new ListViewItem();
                lsv = new ListViewItem(data.Rows[i][0].ToString());
                lsv.SubItems.Add(data.Rows[i][1].ToString());
                lsv.SubItems.Add(data.Rows[i][2].ToString());
                lsv.SubItems.Add(data.Rows[i][3].ToString());
                lsv.SubItems.Add(data.Rows[i][4].ToString());
                lsv_nhanvien.Items.Add(lsv);
            }
        }
        public void dsBC()
        {
            DataTable data = docdanhsach();
            cbb_bc.DataSource = data;
            cbb_bc.DisplayMember = "Bằng Cấp";

        }
            private void Form1_Load(object sender, EventArgs e)
            {
                lsv_nhanvien.View = View.Details;
                lsv_nhanvien.FullRowSelect = true;
                lsv_nhanvien.GridLines = true;
                lsv_nhanvien.Columns.Add("Mã NV");
                lsv_nhanvien.Columns.Add("Họ Tên", 150);
                lsv_nhanvien.Columns.Add("Ngày Sinh", 150);
                lsv_nhanvien.Columns.Add("Địa Chỉ", 150);
                lsv_nhanvien.Columns.Add("Bằng cấp", 150);

                ////Tạo cầu connection
                //string cons = "server=HAINGO1999; Integrated Security=true; database=nhanvien";
                //SqlConnection con = new SqlConnection(cons);

                ////đọc dữ liệu
                //string sql = "select*from nhanvien";
                //SqlDataAdapter A = new SqlDataAdapter(sql, cons);

                ////thực hiện dữ liệu
                //DataTable data = new DataTable();
                //A.Fill(data);//thục hiện

                ////xuất dữ liệu
                //for (int i = 0; i < data.Rows.Count; i++)
                //{
                //    ListViewItem lsv = new ListViewItem();
                //    lsv = new ListViewItem(data.Rows[i][0].ToString());
                //    lsv.SubItems.Add(data.Rows[i][1].ToString());
                //    lsv.SubItems.Add(data.Rows[i][2].ToString());
                //    lsv.SubItems.Add(data.Rows[i][3].ToString());
                //    lsv.SubItems.Add(data.Rows[i][4].ToString());
                //    lsv_nhanvien.Items.Add(lsv);
                //}

                //làm cbb kết nối với SQL
                ketnoiSQL();
                loadlistview();
            //string sql = "select*from nhanvien";
            //A = new SqlDataAdapter(sql, con);
            //DataTable data = new DataTable();
            //A.Fill(data);
            //cbb_bc.DataSource = data;
            //cbb_bc.DisplayMember = "Bằng Cấp";
            dsBC();
                txt_diachi.Text = "";
                txt_mnv.Text = "";
                txt_name.Text = "";

            }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string day = string.Format("{0:MM/dd/yyyy}", datatime_ngaysinh.Value);
            string ten = txt_name.Text;
            string manv = txt_mnv.Text;
            string diachi = txt_diachi.Text;
            string bc = cbb_bc.SelectedValue.ToString();
            string sql = string.Format("Insert into nhanvien Values('{0}',N'{1}','{2}',N'{3}',N'{4}')", manv, ten, day, diachi, bc);
            string cons = "server=" + sever + "; Integrated Security=true; database=" + database;
            SqlConnection con = new SqlConnection(cons);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            con.Close();
            ketnoiSQL();
            loadlistview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Delete from nhanvien where [Mã NV] =" + txt_mnv.Text;
            string scon = "server=HAINGO1999; Integrated Security=true; database=nhanvien";
            SqlConnection con = new SqlConnection(scon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            sql = "select*from nhanvien";
            scon = "server=HAINGO1999; Integrated Security=true; database=nhanvien";
            con = new SqlConnection(scon);
            SqlDataAdapter A = new SqlDataAdapter(sql, con);
            DataTable data = new DataTable();
            A.Fill(data);
            lsv_nhanvien.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ListViewItem lsv = new ListViewItem();
                lsv = new ListViewItem(data.Rows[i][0].ToString());
                lsv.SubItems.Add(data.Rows[i][1].ToString());
                lsv.SubItems.Add(data.Rows[i][2].ToString());
                lsv.SubItems.Add(data.Rows[i][3].ToString());
                lsv.SubItems.Add(data.Rows[i][4].ToString());
                lsv_nhanvien.Items.Add(lsv);
            }
            txt_diachi.Text = "";
            txt_mnv.Text = "";
            txt_name.Text = "";
        }

        private void lsv_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lsv_nhanvien.Items.Count; i++)
            {
                if (lsv_nhanvien.Items[i].Selected)
                {
                    txt_mnv.Text = lsv_nhanvien.Items[i].SubItems[0].Text;
                    txt_name.Text = lsv_nhanvien.Items[i].SubItems[1].Text;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string sql = string.Format("Update Nhanvien set  [Mã NV]='{0}' ,[Họ Tên]=N'{1}' where  [Mã NV]={0} [Họ Tên]=N'{1}'", txt_mnv.Text,txt_name.Text);
            string sql = "update Nhanvien set  [Mã NV]='" +txt_mnv.Text +"' ,[Họ tên]='"+txt_name.Text +"' where  [Mã NV]='" + txt_mnv.Text+"'";
            string scon= "server=HAINGO1999; Integrated Security=true; database=nhanvien";
            SqlConnection con = new SqlConnection(scon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

           // ketnoiSQL();
            loadlistview();
        }
    }
}
