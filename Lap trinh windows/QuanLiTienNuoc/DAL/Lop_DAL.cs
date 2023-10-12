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
            string sql = "select * from giadinh";
            return Load_KH(sql);
        }
        public void Insert_KH(khachhang ob)
        {
            string sql = "insert into giadinh values ('" + ob.makhach + "','" + ob.tenkhach + "','" + ob.sodienthoai + "','" + ob.diachi + "')";
            Excute(sql);
        }
        public void Update_KH(khachhang ob)
        {
            string sql = "update giadinh set hoten = '" + ob.tenkhach + "'" + "where makh = '" + ob.makhach + "'";
            Excute(sql);

        }
        public void Delete_KH(khachhang ob)
        {
            string sql = "delete from giadinh where makh='" + ob.makhach+"'";
            Excute(sql);

        }
    }
}
