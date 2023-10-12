using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachhang
    {
        public string makhach;
        public string tenkhach;
        public string diachi;
        public string sodienthoai;
        public khachhang() { }
        public khachhang(string makhach, string tenkhach, string diachi, string sodienthoai)
        {
            this.makhach = makhach;
            this.tenkhach = tenkhach;
            this.diachi = diachi;
            this.sodienthoai    = sodienthoai;
        }    
    }
}
