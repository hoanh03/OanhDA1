using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhap
    {
        public string MaHDN { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayNhap { get; set; }
        public string DonGiaNhap { get; set; }


        public DTO_HoaDonNhap(string MaHDN, string MaNV, string MaNCC, DateTime nn, string dgn)
        {
            this.MaHDN = MaHDN;
            this.MaNV = MaNV;
            this.MaNCC = MaNCC;
            this.NgayNhap = nn;
            this.DonGiaNhap = dgn;
        }
    }
}
