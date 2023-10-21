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
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap daHDN = new DAL_HoaDonNhap();
        public DataTable getHoaDonNhap()
        {
            return daHDN.getHoaDonNhap();
        }
        public int kiemtramatrung(string MaHDN)
        {
            return daHDN.kiemtramatrung(MaHDN);
        }
        public bool themHDN(DTO_HoaDonNhap HDN)
        {
            return daHDN.themHDN(HDN);
        }
        public bool suaHDN(DTO_HoaDonNhap HDN)
        {
            return daHDN.suaHDN(HDN);
        }
        public bool xoaHDN(string MaHDN)
        {
            return daHDN.xoaHDN(MaHDN);
        }



        //
        public DataTable TimKiemHoaDonNhapTheoMa(string MaHDN)
        {
            return daHDN.TimKiemHoaDonNhapTheoMa(MaHDN);
        }

        public DataTable TimKiemHoaDonNhapTheoManhanvien(string MaNV)
        {
            return daHDN.TimKiemHoaDonNhapTheoManhanvien(MaNV);
        }
        //
        public bool KiemTraTonTaiHoaDonNhap(string MaHoaDonNhap)
        {
            return daHDN.KiemTraTonTaiHoaDonNhap(MaHoaDonNhap);
        }
        public string ThemHoaDonNhap(DTO_HoaDonNhap HDN)
        {
            return daHDN.ThemHoaDonNhap(HDN);
        }
    }
}
