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
    public class DAL_NhanVien : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dssp ra ngoài màn hình
        public DataTable getNhanVien()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from NhanVien", _con);
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
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaNV", ma);
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

        public bool themNV(DTO_NhanVien nv)
        {
            string ngay = string.Format("{0}/{1}/{2}", nv.NgaySinh.Year, nv.NgaySinh.Month, nv.NgaySinh.Day);
            string sql = "Insert into NhanVien values(N'" + nv.MaNV + "',N'" + nv.TenNV + "',N'" + nv.GioiTinhNV + "','" + nv.NgaySinh + "',N'" + nv.DiaChi + "','" + nv.SDTNV + "','" + nv.EmailNV + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaNV(DTO_NhanVien nv)
        {
            string ngay = string.Format("{0}/{1}/{2}", nv.NgaySinh.Year, nv.NgaySinh.Month, nv.NgaySinh.Day);
            string sql = "Update NhanVien set TenNV = N'" + nv.TenNV + "', GioiTinhNV = '" + nv.GioiTinhNV + "',NgaySinh = '" + nv.NgaySinh + "', DiaChi = N'" + nv.DiaChi + "',SDTNV = '" + nv.SDTNV + "',EmailNV = '" + nv.EmailNV + "' where MaNV = '" + nv.MaNV + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaNV(string ma)
        {
            {
                string sql = "Delete from NhanVien where MaNV = '" + ma + "'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemNhanVienTheoMa(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM NhanVien WHERE MaNV = @MaNV", _con);
            da.SelectCommand.Parameters.AddWithValue("@MaNV", ma);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        public DataTable TimKiemNhanVienTheoTen(string ten)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM NhanVien WHERE TenNV LIKE '%' + @TenNV + '%'", _con);
            da.SelectCommand.Parameters.AddWithValue("@TenNV", ten);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool KiemTraTonTaiMaNhanVien(string MaNV)
        {
            _con.Open();
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count > 0;
        }

    }
}
