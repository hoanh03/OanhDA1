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
    public class DAL_SanPham: DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dssp ra ngoài màn hình
        public DataTable getSanPham()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from Sanpham", _con);
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
        public int kiemtramatrung(string ma)
        {
            int i = 0;
            try
            {
                _con.Open();
                string sql = "SELECT COUNT(*) FROM SanPham WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaSP", ma);
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

        public int themSP(DTO_SanPham SP)
        {
            if (SP.DonGia < 0)
            {
                return -1;
            }
            if (SP.SoLuong < 0)
            {
                return -2;
            }
            string sql = "Insert into Sanpham values(N'" + SP.MaSP + "',N'" + SP.TenSP + "',N'" + SP.Mausac + "','" + SP.Size + "',N'" + SP.ChatLieu + "','"+SP.DonGia+"','"+SP.SoLuong+"')";

            thucthisql(sql);
            return 1;
        }
        public int suaSP(DTO_SanPham SP)
        {
            if (SP.DonGia < 0)
            {
                return -1;
            }
            if (SP.SoLuong < 0)
            {
                return -2;
            } 
            string sql = "Update SanPham set TenSP = N'" + SP.TenSP + "', Mausac = '" + SP.Mausac + "',Size = '" + SP.Size + "', ChatLieu = N'" + SP.ChatLieu + "',DonGia = '"+SP.DonGia+"',SoLuong = '"+SP.SoLuong+"' where MaSP = '" + SP.MaSP + "'";

            thucthisql(sql);
            return 1;
        }
        public bool xoaSP(string ma)
        {
            {
                string sql = "Delete from SanPham where MaSP = '" + ma + "'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemSanPhamTheoMa(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM SanPham WHERE MaSP = @MaSP", _con);
            da.SelectCommand.Parameters.AddWithValue("@MaSP", ma);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        public DataTable TimKiemSanPhamTheoTen(string ten)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM SanPham WHERE TenSP LIKE '%' + @TenSP + '%'", _con);
            da.SelectCommand.Parameters.AddWithValue("@TenSP", ten);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public decimal LayGiaSanPham(string ma)
        {
            string query = "SELECT DonGia FROM SanPham WHERE MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(query, _con);
            cmd.Parameters.AddWithValue("@MaSP", ma);
            _con.Open();
            decimal gia = Convert.ToDecimal(cmd.ExecuteScalar());
            _con.Close();
            return gia;
        }
        public bool KiemTraTonTaiSanPham(string ma)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE MaSP = @MaSP", _con);
            cmd.Parameters.AddWithValue("@MaSP", ma);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();

            return count > 0;
        }
        public void themsoluongsanpham(string MaSP,int SoLuong)
        {
            string sql = "Update SanPham Set SoLuong = SoLuong + " + SoLuong + " Where MaSP = N'" + MaSP + "'";
            thucthisql(sql);
        }
        public void giamsoluongsanpham(string MaSP, int SoLuong)
        {
            string sql = "Update SanPham Set SoLuong = SoLuong - " + SoLuong + " Where MaSP = N'" + MaSP + "'";
            thucthisql(sql);
        }

    }


}
