using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace mohinh3L.BLL
{
    class DocGia:database
    {
        public DocGia()//ko can base cung dc
        {

        }
        public DataTable LayDSDocgia()
        {
            string sql = "select*from Docgia";
            return Docbang(sql);
        }
        public void them(string ma, string date)
        {
            string sql = string.Format("insert into Phieumuonsach values('{0}','{1}')", ma, date);
           Thuvienlenh(sql);
        }
     
}
