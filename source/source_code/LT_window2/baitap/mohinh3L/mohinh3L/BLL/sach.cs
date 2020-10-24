using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace mohinh3L.BLL
{
    class sach:database
    {
        public sach()
        {

        }
        public DataTable hienthisachCO()
        {
            string sql = "select*from Sach";
            return Docbang(sql);
        }
        public DataTable hienthisachMuon(string maphieu)
        {
            string sql = string.Format("select * from Sach, Chitietphieumuon where Sach.Masach = Chitietphieumuon.Masach and Maphieumuon ='{0}'", maphieu);
            return Docbang(sql);
        }
        public void themsachmuon(string masach,string maphieu)
        {
            string sql = string.Format("insert into Chitietphieumuon values('{0}','{1}')", masach, maphieu);
            Thuvienlenh(sql);
        }
    }
}
