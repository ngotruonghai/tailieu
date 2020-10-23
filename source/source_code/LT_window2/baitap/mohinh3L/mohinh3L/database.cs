using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace mohinh3L
{
    class database
    {
        public SqlConnection con;
        public database()
        {
            string scon = "Data Source=HAINGO1999;Initial Catalog=QLTV;Integrated Security=True";
            con = new SqlConnection(scon);
        }
        public DataTable Docbang(string scon)
        {
            SqlDataAdapter A = new SqlDataAdapter(scon, con);
            DataTable dt = new DataTable();
            A.Fill(dt);
            return dt;
        }
        public void Thuvienlenh(string scon)
        {
            SqlCommand cmd = new SqlCommand(scon,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
