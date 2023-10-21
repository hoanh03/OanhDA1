using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHoaDonNhap
    {
        public int maCTHDN { get; set; }
        public string MaHDN { get; set; }
        public string MaSP { get; set; }
        public int soluong { get; set; }
        public decimal gia { get; set; }
        public decimal thanhtien { get; set; }

        public DTO_CTHoaDonNhap(int maCT, string MaHDN, string MaSP, int sl, decimal gia, decimal tt)
        {
            this.maCTHDN = maCT;
            this.MaHDN = MaHDN;
            this.MaSP = MaSP;
            this.soluong = sl;
            this.gia = gia;
            this.thanhtien = tt;
        }

    }
}
