using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class Class1
    {
        Lop_DAL kh = new Lop_DAL();
        public DataTable Load_Bus()
        {
            return kh.Load_KH();
        }
        public DataTable Tinh_Bus()
        {
            return kh.Tinh();
        }
        public void Insert_Bus(khachhang ob)
        {
            kh.Insert_KH(ob);
        }
        public void Update_Bus(khachhang ob)
        {
            kh.Update_KH(ob);
        }
        public void Delete_Bus(khachhang ob)
        {
            kh.Delete_KH(ob);
        }

    }
}
