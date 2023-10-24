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
        public string sodienthoai;
        public string diachi;
        public string chisomoi;
        public string chisocu;
        public string tongtien;
        public khachhang() { }
        public khachhang(string makhach, string tenkhach, string sodienthoai, string diachi)
        {
            this.makhach = makhach;
            this.tenkhach = tenkhach;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
        }    
    }
}
