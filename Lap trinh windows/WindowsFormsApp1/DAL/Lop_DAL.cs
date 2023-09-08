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
        public DataTable Load_Lop()
        {
            return Load_DL("select * from Lop");
        }
        public void Insert_Lop(Lop ob)
        {
            string sql = "insert into Lop values('" + ob.Malop + "','" + ob.Tenlop + "')";
            Execute(sql);
        }
        public void Update_Lop(Lop ob)
        {
            string sql = "update Lop set tenlop='" + ob.Tenlop + "'" + "Where malop='" + ob.Malop + "'";
            Execute(sql);
        }
        public void Delete_Lop(Lop ob)
        {
            string sql = "delete from Lop Where malop='" + ob.Malop +"'";
            Execute(sql);
        }
    }
}
