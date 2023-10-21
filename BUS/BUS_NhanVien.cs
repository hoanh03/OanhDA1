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
    public class BUS_NhanVien
    {
        DAL_NhanVien danv = new DAL_NhanVien();
        public DataTable getNhanVien()
        {
            return danv.getNhanVien();
        }
        public int kiemtramatrung(string ma)
        {
            return danv.kiemtramatrung(ma);
        }
        public bool themNV(DTO_NhanVien nv)
        {
            return danv.themNV(nv);
        }
        public bool suaNV(DTO_NhanVien nv)
        {
            return danv.suaNV(nv);
        }
        public bool xoaNV(string ma)
        {
            return danv.xoaNV(ma);
        }



        //
        public DataTable TimKiemNhanVienTheoMa(string ma)
        {
            return danv.TimKiemNhanVienTheoMa(ma);
        }

        public DataTable TimKiemNhanVienTheoTen(string ten)
        {
            return danv.TimKiemNhanVienTheoTen(ten);
        }
        public bool KiemTraTonTaiMaNhanVien(string MaNV)
        {
            return danv.KiemTraTonTaiMaNhanVien(MaNV);
        }

    }

    
}
