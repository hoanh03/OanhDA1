using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NHACC
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDTNCC { get; set; }
        public string DiaChiNCC { get; set; }

        public DTO_NHACC()
        {

        }
        public DTO_NHACC(string ma, string ten, string sdt, string dc )
        {
            this.MaNCC = ma;
            this.TenNCC = ten;
            this.SDTNCC = sdt;
            this.DiaChiNCC = dc;
        }
    }
}
