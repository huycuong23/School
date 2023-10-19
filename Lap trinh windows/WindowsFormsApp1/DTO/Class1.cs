using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sanpham
    {
        public string Masp;
        public string Tensp;
        public string DVT;
        public string Gia;
        public Sanpham() { }
        public Sanpham(string Masp, string Tensp, string DVT, string Gia) {
           this.Masp = Masp;
            this.Tensp = Tensp;
            this.DVT = DVT;
            this.Gia = Gia;
        }
    }
}
