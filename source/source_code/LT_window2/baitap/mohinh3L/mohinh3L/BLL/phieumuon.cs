using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace mohinh3L.BLL
{
    class phieumuon:database
    {
        public phieumuon()
        { }
        public DataTable DSphieumuon()
        {
            string sql = "select Docgia.Hotendocgia,Phieumuonsach.Maphieumuonsach,Phieumuonsach.Ngaymuon,tienno from Docgia, Phieumuonsach where Docgia.Madocgia = Phieumuonsach.Madocgia";
            return Docbang(sql);
        }
        public void xoaPM(string mapm)
        {
            string sql = string.Format("delete from Chitietphieumuon where Maphieumuon ='{0}'", mapm);
            Thuvienlenh(sql);
            sql = string.Format("delete from Phieumuonsach where Maphieumuonsach ='{0}'", mapm);
            Thuvienlenh(sql);
        }
    }
}
