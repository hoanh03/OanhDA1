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
     public class DAL_HoaDonBan : DBConnect
     {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dskh ra ngoài màn hình
        public DataTable getHoaDonBan()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HoaDonBan", _con);
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
        public int kiemtramatrung(string MaHDB)
        {
            int i = 0;
            try
            {
                _con.Open();
                string sql = "SELECT COUNT(*) FROM HoaDonBan WHERE MaHDB = @MaHDB";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaHDB", MaHDB);
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
        public bool themHDB(DTO_HoaDonBan HDB)
        {
            string ngay = string.Format("{0}/{1}/{2}", HDB.Ngayban.Year, HDB.Ngayban.Month, HDB.Ngayban.Day);
            string sql = "Insert into HoaDonBan values(N'" + HDB.MaHDB + "',N'" + HDB.MaNV + "',N'" + HDB.MaKH + "',N'" + ngay + "',N'" + HDB.HinhThucTT + "',N'" + HDB.DonGia + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaHDB(DTO_HoaDonBan HDB)
        {
            string ngay = string.Format("{0}/{1}/{2}", HDB.Ngayban.Year, HDB.Ngayban.Month, HDB.Ngayban.Day);
            string sql = "Update HoaDonBan set MaNV = N'" + HDB.MaNV + "', MaKH = '" + HDB.MaKH + "',Ngayban = '" + ngay + "',HinhThucTT = N'" + HDB.HinhThucTT + "', DonGia = '" + HDB.DonGia + "' where MaHDB = '" + HDB.MaHDB + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaHDB(string MaHDB)
        {
            {
                string sql = "Delete from HoaDonBan where MaHDB = '" + MaHDB + "'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemHoaDonBanTheoMa(string MaHDB)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM HoaDonBan WHERE MaHDB = @MaHDB", _con);
            da.SelectCommand.Parameters.AddWithValue("@MaHDB", MaHDB);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        public DataTable TimKiemHoaDonBanTheoManhanvien(string MaNV)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM HoaDonBan WHERE MaNV LIKE '%' + @MaNV + '%'", _con);
            da.SelectCommand.Parameters.AddWithValue("@MaNV", MaNV);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        //
        public bool KiemTraTonTaiHoaDonBan(string MaHoaDonBan)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM HoaDonBan WHERE MaHDB = @MaHoaDonBan", _con);
            cmd.Parameters.AddWithValue("@MaHoaDonBan", MaHoaDonBan);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();

            return count > 0;
        }
        public string ThemHoaDonBan(DTO_HoaDonBan HDB)
        {
            string query = $"INSERT INTO HoaDonBan(MaHDB, MaNV,MaKH, Ngayban,HinhThucTT,DonGia) VALUES({HDB.MaHDB}, {HDB.MaNV}, {HDB.MaKH}, '{HDB.Ngayban.ToString("yyyy-MM-dd")}',{HDB.HinhThucTT},{HDB.DonGia})";

            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand(query, _con);
                cmd.ExecuteNonQuery();

                // Lấy mã hóa đơn bán vừa thêm và trả về
                query = "SELECT IDENT_CURRENT('HoaDonBan')";
                cmd.CommandText = query;
                string maHDB = cmd.ExecuteScalar().ToString();

                return maHDB;
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
