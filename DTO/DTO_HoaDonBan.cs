using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonBan
    {
        public string MaHDB { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public DateTime Ngayban { get; set; }
        public string HinhThucTT { get; set; }
        public string DonGia { get; set; }


        public DTO_HoaDonBan(string MaHDB, string MaNV, string MaKH, DateTime nb,string httt, string dg)
        {
            this.MaHDB = MaHDB;
            this.MaNV = MaNV;
            this.MaKH = MaKH;
            this.Ngayban = nb;
            this.HinhThucTT = httt;
            this.DonGia = dg;

        }
    }
}
