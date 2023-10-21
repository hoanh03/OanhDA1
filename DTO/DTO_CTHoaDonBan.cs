using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHoaDonBan
    {
        public int maCTHDB { get; set; }
        public string MaHDB { get; set; }
        public string MaSP { get; set; }
        public int soluong { get; set; }
        public decimal gia { get; set; }
        public decimal thanhtien { get; set; }

        public DTO_CTHoaDonBan(int maCT, string MaHDB, string MaSP, int sl, decimal gia, decimal tt)
        {
            this.maCTHDB = maCT;
            this.MaHDB = MaHDB;
            this.MaSP = MaSP;
            this.soluong = sl;
            this.gia = gia;
            this.thanhtien = tt;
        }
    }
}
