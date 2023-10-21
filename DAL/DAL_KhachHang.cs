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
    public class DAL_KhachHang : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dssp ra ngoài màn hình
        public DataTable getKhachHang()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from KhachHang", _con);
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
                string sql = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaKH", ma);
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

        public bool themKH(DTO_KhachHang kh)
        {
            string sql = "Insert into KhachHang values(N'" + kh.MaKH + "',N'" + kh.TenKH + "',N'" + kh.DiaChiKH + "','" + kh.SDTKH + "',N'" + kh.EmailKH + "','" + kh.GioiTinh + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaKH(DTO_KhachHang kh)
        {
            //string sql = "UPDATE KhachHang SET TenKH = N'" + kh.TenKH + "', DiaChiKH = N'" + kh.DiaChiKH + "', SDTKH = N'" + kh.SDTKH + "', EmailKH = N'" + kh.EmailKH + "', GioiTinh = N'" + kh.GioiTinh + "' WHERE MaKH = '" + kh.MaKH + "'";
            string sql = "Update KhachHang set TenKH = N'" + kh.TenKH + "', DiaChiKH = '" + kh.DiaChiKH + "',SDTKH = N'" + kh.SDTKH + "',EmailKH= '" + kh.EmailKH + "',GioiTinh= '" + kh.GioiTinh + "' where MaKH = '" + kh.MaKH + "'";

            thucthisql(sql);
            return true;
           
        }
        public bool xoaKH(string ma)
        {
            {
                string sql = "Delete from KhachHang where MaKH = '" + ma + "'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemKhachHangTheoMa(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM KhachHang WHERE MaKH = @MaKH", _con);
            da.SelectCommand.Parameters.AddWithValue("@MaKH", ma);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        public DataTable TimKiemKhachHangTheoTen(string ten)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM KhachHang WHERE TenKH LIKE '%' + @TenKH + '%'", _con);
            da.SelectCommand.Parameters.AddWithValue("@TenKH", ten);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool KiemTraTonTaiMaKhachHang(string MaKH)
        {
            _con.Open();
            string sql = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count > 0;
        }



        //SqlCommand cmd;
        //SqlDataAdapter da;
        //DataTable dt;
        ////hiển thị dskh ra ngoài màn hình
        //public DataTable getKhachHang()
        //{
        //    _con.Open();
        //    da = new SqlDataAdapter("Select * from KhachHang", _con);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    _con.Close();
        //    return dt;
        //}
        //void thucthisql(string sql)
        //{
        //    _con.Open();
        //    cmd = new SqlCommand(sql, _con);
        //    cmd.ExecuteNonQuery();
        //    _con.Close();
        //}
        //public int kiemtramatrung(string ma)
        //{
        //    int i = 0;
        //    try
        //    {
        //        _con.Open();
        //        string sql = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
        //        SqlCommand cmd = new SqlCommand(sql, _con);
        //        cmd.Parameters.AddWithValue("@MaKH", ma);
        //        i = (int)cmd.ExecuteScalar();
        //    }
        //    catch (Exception)
        //    {
        //        // Xử lý lỗi kết nối
        //    }
        //    finally
        //    {
        //        _con.Close();
        //    }
        //    return i;
        //}

        //public bool themKH(DTO_KhachHang KH)
        //{
        //    string sql = "Insert into KhachHang values(N'" + KH.MaKH + "',N'" + KH.TenKH + "',N'" + KH.DiaChiKH + "',N'" + KH.SDTKH + "','"+KH.EmailKH+"','"+KH.GioiTinh+"')";

        //    thucthisql(sql);
        //    return true;
        //}
        //public bool suaKH(DTO_KhachHang KH)
        //{
        //    string sql = "Update KhachHang set TenKH = N'" + KH.TenKH + "', DiaChiKH = '" + KH.DiaChiKH + "',SDTKH = N'" + KH.SDTKH + "',EmailKH= '" + KH.EmailKH+ "',GioiTinh= '" + KH.GioiTinh+ "' where MaKH = '" + KH.MaKH + "'";

        //    thucthisql(sql);
        //    return true;
        //}
        //public bool xoaKH(string ma)
        //{
        //    {
        //        string sql = "Delete from KhachHang where MaKH = '" + ma + "'";

        //        thucthisql(sql);
        //        return true;
        //    }
        //}



        ////
        //public DataTable TimKiemSanPhamTheoMa(string ma)
        //{
        //    _con.Open();
        //    da = new SqlDataAdapter("SELECT * FROM KhachHang WHERE MaKH = @MaKH", _con);
        //    da.SelectCommand.Parameters.AddWithValue("@MaKH", ma);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    _con.Close();
        //    return dt;
        //}

        //public DataTable TimKiemSanPhamTheoTen(string ten)
        //{
        //    _con.Open();
        //    da = new SqlDataAdapter("SELECT * FROM KhachHang WHERE TenKH LIKE '%' + @TenKH + '%'", _con);
        //    da.SelectCommand.Parameters.AddWithValue("@TenKH", ten);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    _con.Close();
        //    return dt;
        //}
        //public bool KiemTraTonTaiMaKhachHang(string maKH)
        //{
        //    _con.Open();
        //    string sql = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
        //    SqlCommand cmd = new SqlCommand(sql, _con);
        //    cmd.Parameters.AddWithValue("@MaKH", maKH);
        //    int count = (int)cmd.ExecuteScalar();
        //    _con.Close();
        //    return count > 0;
        //}
    }

}
