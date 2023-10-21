using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Mausac { get; set; }
        public string Size { get; set; }
        public string ChatLieu { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public DTO_SanPham()
        {

        }
        public DTO_SanPham(string ma, string ten, string ms, string sz, string cl, int dg, int sl)
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.Mausac = ms;
            this.Size = sz;
            this.ChatLieu = cl;
            this.DonGia = dg;
            this.SoLuong = sl;
        }

    }
}
