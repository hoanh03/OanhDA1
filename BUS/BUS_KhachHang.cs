using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_KhachHang
    {

        DAL_KhachHang dakh = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dakh.getKhachHang();
        }
        public int kiemtramatrung(string ma)
        {
            return dakh.kiemtramatrung(ma);
        }
        public bool themKH(DTO_KhachHang kh)
        {
            return dakh.themKH(kh);
        }
        public bool suaKH(DTO_KhachHang kh)
        { 
            return dakh.suaKH(kh);
        }
        public bool xoaKH(string ma)
        {
            return dakh.xoaKH(ma);
        }



        //
        public DataTable TimKiemKhachHangTheoMa(string ma)
        {
            return dakh.TimKiemKhachHangTheoMa(ma);
        }

        public DataTable TimKiemKhachHangTheoTen(string ten)
        {
            return dakh.TimKiemKhachHangTheoTen(ten);
        }
        public bool KiemTraTonTaiMaKhachHang(string MaKH)
        {
            return dakh.KiemTraTonTaiMaKhachHang(MaKH);
        }
    }
}
