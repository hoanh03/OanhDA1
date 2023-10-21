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
    public class BUS_NHACC
    {
        DAL_NHACC dancc = new DAL_NHACC();
        public DataTable getNHACC()
        {
            return dancc.getNHACC();
        }
        public int kiemtramatrung(string ma)
        {
            return dancc.kiemtramatrung(ma);
        }
        public bool themNCC(DTO_NHACC nc)
        {
            return dancc.themNCC(nc);
        }
        public bool suaNCC(DTO_NHACC nc)
        {
            return dancc.suaNCC(nc);
        }
        public bool xoaNCC(string ma)
        {
            return dancc.xoaNCC(ma);
        }
        public DataTable TimKiemNHACCTheoMa(string ma)
        {
            return dancc.TimKiemNHACCTheoMa(ma);
        }
        public DataTable TimKiemNHACCTheoTen(string ten)
        {
            return dancc.TimKiemNHACCTheoTen(ten);
        }
        public bool KiemTraTonTaiMaNhaCungCap(string MaNCC)
        {
            return dancc.KiemTraTonTaiMaNhaCungCap(MaNCC);
        }


    }
}
