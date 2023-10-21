using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinhNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDTNV { get; set; }
        public string EmailNV { get; set; }

        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien (string ma, string ten, string gt, DateTime ns, string dc, string sdt, string email)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.GioiTinhNV = gt;
            this.NgaySinh = ns;
            this.DiaChi = dc;
            this.SDTNV = sdt;
            this.EmailNV = email;
        }
    }
}
