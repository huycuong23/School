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
        Lop_DAL lop = new Lop_DAL();
        public DataTable Load_BUS()
        {
            return lop.Load_Lop();

        }
        public void Insert_BUS(Lop ob)
        {
            lop.Insert_Lop(ob);

        }
        public void Update_BUS(Lop ob)
        {
            lop.Update_Lop(ob);
        }
        public void Delete_BUS(Lop ob)
        {
            lop.Delete_Lop(ob);

        }
    }
}
