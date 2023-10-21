using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan daHDB = new DAL_HoaDonBan();
        public DataTable getHoaDonBan()
        {
            return daHDB.getHoaDonBan();
        }
        public int kiemtramatrung(string MaHDB)
        {
            return daHDB.kiemtramatrung(MaHDB);
        }
        public bool themHDB(DTO_HoaDonBan HDB)
        {
            return daHDB.themHDB(HDB);
        }
        public bool suaHDB(DTO_HoaDonBan HDB)
        {
            return daHDB.suaHDB(HDB);
        }
        public bool xoaHDB(string MaHDB)
        {
            return daHDB.xoaHDB(MaHDB);
        }



        //
        public DataTable TimKiemHoaDonBanTheoMa(string MaHDB)
        {
            return daHDB.TimKiemHoaDonBanTheoMa(MaHDB);
        }

        public DataTable TimKiemHoaDonBanTheoManhanvien(string MaNV)
        {
            return daHDB.TimKiemHoaDonBanTheoManhanvien(MaNV);
        }
        //
        public bool KiemTraTonTaiHoaDonBan(string MaHoaDonBan)
        {
            return daHDB.KiemTraTonTaiHoaDonBan(MaHoaDonBan);
        }
        public string ThemHoaDonBan(DTO_HoaDonBan HDB)
        {
            return daHDB.ThemHoaDonBan(HDB);
        }
    }
}
