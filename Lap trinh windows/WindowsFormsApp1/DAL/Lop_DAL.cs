using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Lop_DAL:connect {
        public DataTable Load_SP()
        {
            return Load_DL("select masp, tensp, dvt, gia from sanpham");
        }
        public void Insert_SP(Sanpham ob)
        {
            string sql = "insert into sanpham values('" + ob.Masp + "','" + ob.Tensp +","+ ob.DVT+ "," + ob.Gia +"')";
            Execute(sql);
        }
        public void Update_SP(Sanpham ob)
        {
            string sql = "update sanpham set tensp='" + ob.Tensp +"'"+ "Where masp='" + ob.Masp + "'";
            Execute(sql);
        }
        public void Delete_SP(Sanpham ob)
        {
            string sql = "delete from sanpham Where Masp='" + ob.Masp +"'";
            Execute(sql);
        }
    }
}
