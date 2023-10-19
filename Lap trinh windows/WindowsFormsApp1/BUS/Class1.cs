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
    public class Lop_BUS 
    {
        Lop_DAL Sp = new Lop_DAL();
        public DataTable Load_BUS()
        {
            return Sp.Load_SP();

        }
        public void Insert_BUS(Sanpham ob)
        {
            Sp.Insert_SP(ob);

        }
        public void Update_BUS(Sanpham ob)
        {
            Sp.Update_SP(ob);
        }
        public void Delete_BUS(Sanpham ob)
        {
            Sp.Delete_SP(ob);

        }
    }
}
