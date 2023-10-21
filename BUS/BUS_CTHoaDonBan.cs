using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_CTHoaDonBan
    {
        DAL_CTHoaDonBan daCTHDB = new DAL_CTHoaDonBan();
        DAL_SanPham dasp = new DAL_SanPham();
        public DataTable getCTHDB()
        {
            return daCTHDB.getCTHDB();
        }
        public int kiemtramatrung(int maCTHDB)
        {
            return daCTHDB.kiemtramatrung(maCTHDB);
        }
        public int themCTHDB(DTO_CTHoaDonBan CTHDB)
        {
            //return daCTHDB.themCTHDB(CTHDB);
            int result = daCTHDB.themCTHDB(CTHDB);
            if (result == 1)
            {
                dasp.giamsoluongsanpham(CTHDB.MaSP, CTHDB.soluong);
            }
            return result;
        }
        public int suaCTHDB(DTO_CTHoaDonBan CTHDB)
        {
            return daCTHDB.suaCTHDB(CTHDB);
        }
        public bool xoaCTHDB(int maCTHDB)
        {
            return daCTHDB.xoaCTHDB(maCTHDB);
        }
        public bool KiemTraTonTaiMaCTHDB(int maCTHDB)
        {
            return daCTHDB.KiemTraTonTaiMaCTHDB(maCTHDB);
        }
        public decimal TinhTongTien(string maHDB)
        {
            return daCTHDB.TinhTongTien(maHDB);
        }
    }
}
