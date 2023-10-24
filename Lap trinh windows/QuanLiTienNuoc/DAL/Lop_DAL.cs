using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Lop_DAL : connect
    {
        public Lop_DAL() { }
        public DataTable Load_KH()
        {
            string sql = "select * from hoadon";
            return Load_KH(sql);
        }
        public DataTable Tinh()
        {
            string sql = "SELECT dbo.giadinh.makhach, dbo.giadinh.tenkhach, dbo.giadinh.sodienthoai, dbo.giadinh.diachi, dbo.HoaDon.chisomoi, dbo.HoaDon.chisocu, dbo.DonGia.DonGia\r\nFROM dbo.giadinh INNER JOIN\r\n dbo.HoaDon ON dbo.giadinh.makhach = dbo.HoaDon.makhach INNER JOIN\r\n dbo.DonGia ON dbo.HoaDon.mahoadon = dbo.DonGia.MaHoaDon";
            return Load_KH(sql);
        }
        public void Insert_KH(khachhang ob)
        {
            string sql = "insert into giadinh values ('" + ob.makhach + "','" + ob.tenkhach + "','" + ob.sodienthoai + "','" + ob.diachi + "')";
            Excute(sql);
        }
        public void Update_KH(khachhang ob)
        {
            string sql = "update giadinh set tenkhach = '" + ob.tenkhach + "'" + "where makhach = '" + ob.makhach + "'";
            Excute(sql);

        }
        public void Delete_KH(khachhang ob)
        {
            string sql = "delete from giadinh where makhach='" + ob.makhach+"'";
            Excute(sql);

        }
    }
}
