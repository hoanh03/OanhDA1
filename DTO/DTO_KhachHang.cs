using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChiKH { get; set; }
        public string SDTKH { get; set; }
        public string EmailKH { get; set; }
        public string GioiTinh { get; set; }

       
        public DTO_KhachHang(string ma, string ten, string dc, string sdt, string email, string gt)
        {
            this.MaKH = ma;
            this.TenKH = ten;
            this.DiaChiKH = dc;
            this.SDTKH = sdt;
            this.EmailKH = email;
            this.GioiTinh = gt;
        }
    }
}
