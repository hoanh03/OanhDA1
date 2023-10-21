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
    public class DAL_HoaDonNhap : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dskh ra ngoài màn hình
        public DataTable getHoaDonNhap()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HoaDonNhap", _con);
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
        public int kiemtramatrung(string MaHDN)
        {
            int i = 0;
            try
            {
                _con.Open();
                string sql = "SELECT COUNT(*) FROM HoaDonNhap WHERE MaHDN = @MaHDN";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaHDN", MaHDN);
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

        public bool themHDN(DTO_HoaDonNhap HDN)
        {
            string ngay = string.Format("{0}/{1}/{2}", HDN.NgayNhap.Year, HDN.NgayNhap.Month, HDN.NgayNhap.Day);
            string sql = "Insert into HoaDonNhap values(N'" + HDN.MaHDN + "',N'" + HDN.MaNV + "',N'" + HDN.MaNCC + "',N'" + ngay + "',N'" + HDN.DonGiaNhap + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaHDN(DTO_HoaDonNhap HDN)
        {
            string ngay = string.Format("{0}/{1}/{2}", HDN.NgayNhap.Year, HDN.NgayNhap.Month, HDN.NgayNhap.Day);
            string sql = "Update HoaDonNhap set MaNV = N'" + HDN.MaNV + "', MaNCC = '" + HDN.MaNCC + "',MgayNhap = '" + ngay + "',DonGiaNhap = '" + HDN.DonGiaNhap + "' where MaHDN = '" + HDN.MaHDN + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaHDN(string MaHDN)
        {
            {
                string sql = "Delete from HoaDonNhap where MaHDN = '" + MaHDN + "'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemHoaDonNhapTheoMa(string MaHDN)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM HoaDonNhap WHERE MaHDN = @MaHDN", _con);
            da.SelectCommand.Parameters.AddWithValue("@MaHDN", MaHDN);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        public DataTable TimKiemHoaDonNhapTheoManhanvien(string MaNV)
        {
            _con.Open();
            //da = new SqlDataAdapter("SELECT * FROM HoaDonNhap WHERE MaNV LIKE '%' + @MaNV + '%'", _con);
            da = new SqlDataAdapter("SELECT * FROM HoaDonNhap WHERE MaNV = @MaNV", _con);
            da.SelectCommand.Parameters.AddWithValue("@MaNV", MaNV);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        //
        public bool KiemTraTonTaiHoaDonNhap(string MaHDN)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM HoaDonNhap WHERE MaHDN = @MaHDN", _con);
            cmd.Parameters.AddWithValue("@MaHDN", MaHDN);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();

            return count > 0;
        }
        public string ThemHoaDonNhap(DTO_HoaDonNhap HDN)
        {
            string query = $"INSERT INTO HoaDonNhap(MaHDN, MaNV,MaNCC, NgayNhap) VALUES({HDN.MaHDN}, {HDN.MaNV}, {HDN.MaNCC}, '{HDN.NgayNhap.ToString("yyyy-MM-dd")}')";

            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand(query, _con);
                cmd.ExecuteNonQuery();

                // Lấy mã hóa đơn nhập vừa thêm và trả về
                query = "SELECT IDENT_CURRENT('HoaDonNhap')";
                cmd.CommandText = query;
                string maHDN = cmd.ExecuteScalar().ToString();

                return maHDN;
            }
            catch (Exception)
            {
                // Xử lý ngoại lệ (Exception)
                // ...
            }
            finally
            {
                _con.Close();
            }

            return "-1"; // Trả về -1 nếu có lỗi
        }
    }
}
