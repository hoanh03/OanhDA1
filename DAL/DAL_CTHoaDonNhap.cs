using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_CTHoaDonNhap : DBConnect
    {
        DAL_SanPham dasp = new DAL_SanPham();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dskh ra ngoài màn hình
        public DataTable getCTHDN()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from ChitietHDN", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int kiemtramatrung(int maCTHDN)
        {
            int i = 0;
            try
            {
                _con.Open();
                string sql = "SELECT COUNT(*) FROM ChitietHDN WHERE maCTHDN = @MaCTHDN";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaCTHDN", maCTHDN);
                i = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                // Xử lý lỗi kết nối
            }
            finally
            {
                _con.Close();
            }
            return i;
        }

        public int themCTHDN(DTO_CTHoaDonNhap CTHDN)
        {
            if (CTHDN.soluong < 0)
            {
                return -2;
            }
            string sql = "Insert into ChitietHDN values(N'" + CTHDN.maCTHDN + "',N'" + CTHDN.MaHDN + "',N'" + CTHDN.MaSP + "',N'" + CTHDN.soluong + "','" + CTHDN.gia + "','" + CTHDN.thanhtien + "')";

            thucthisql(sql);
            return 1;


        }
        public int suaCTHDN(DTO_CTHoaDonNhap CTHDN)
        {
            if (CTHDN.soluong < 0)
            {
                return -2;
            }
            //string ngay = string.Format("{0}/{1}/{2}", HDN.ngaynhap.Year, HDN.ngaynhap.Month, HDN.ngaynhap.Day);
            string sql = "Update ChitietHDN set MaHDN = N'" + CTHDN.MaHDN + "', MaSP = '" + CTHDN.MaSP + "',soluong = '" + CTHDN.soluong + "',gia = '" + CTHDN.gia + "',tongtien = '" + CTHDN.thanhtien + "' where maCTHDN = '" + CTHDN.maCTHDN + "'";

            thucthisql(sql);
            dasp.themsoluongsanpham(CTHDN.MaSP, CTHDN.soluong);
            return 1;
        }
        public bool xoaCTHDN(int maCTHDN)
        {
            {
                string sql = "Delete from ChitietHDN where maCTHDN = '" + maCTHDN + "'";

                thucthisql(sql);
                return true;
            }
        }
        public bool KiemTraTonTaiMaCTHDN(int maCTHDN)
        {
            _con.Open();
            string sql = "SELECT COUNT(*) FROM ChitietHDN WHERE maCTHDN = @maCTHDN";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@maCTHDN", maCTHDN);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count > 0;
        }
        public decimal TinhTongTien(string maHDN)
        {

            decimal Tongtien = 0;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                _con.Open();

                string query = "SELECT SUM(tongtien) FROM ChitietHDN WHERE MaHDN = @MaHDN";

                using (SqlCommand command = new SqlCommand(query, _con))
                {
                    command.Parameters.AddWithValue("@MaHDN", maHDN);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        Tongtien = Convert.ToDecimal(result);
                    }
                }
            }
            _con.Close();
            return Tongtien;

        }
    }
}
