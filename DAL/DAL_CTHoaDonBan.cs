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
    public class DAL_CTHoaDonBan : DBConnect
    {
        DAL_SanPham dasp = new DAL_SanPham();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dskh ra ngoài màn hình
        public DataTable getCTHDB()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from ChitietHDB", _con);
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
        public int kiemtramatrung(int maCTHDB)
        {
            int i = 0;
            try
            {
                _con.Open();
                string sql = "SELECT COUNT(*) FROM ChitietHDB WHERE maCTHDB = @MaCTHDB";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaCTHDB", maCTHDB);
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

        public int themCTHDB(DTO_CTHoaDonBan CTHDB)
        {

            if (CTHDB.soluong < 0)
            {
                return -2;
            }
            string sql = "Insert into ChitietHDB values(N'" + CTHDB.maCTHDB + "',N'" + CTHDB.MaHDB + "',N'" + CTHDB.MaSP + "',N'" + CTHDB.soluong + "','" + CTHDB.gia + "','" + CTHDB.thanhtien + "')";

            thucthisql(sql);
           // dasp.giamsoluongsanpham(CTHDB.MaSP, CTHDB.soluong);
            return 1;


        }
        public int suaCTHDB(DTO_CTHoaDonBan CTHDB)
        {

            if (CTHDB.soluong < 0)
            {
                return -2;
            }
            //string ngay = string.Format("{0}/{1}/{2}", HDB.ngaynhap.Year, HDB.ngaynhap.Month, HDB.ngaynhap.Day);
            string sql = "Update ChitietHDB set MaHDB = N'" + CTHDB.MaHDB + "', MaSP = '" + CTHDB.MaSP + "',soluong = '" + CTHDB.soluong + "',gia = '" + CTHDB.gia + "',tongtien = '" + CTHDB.thanhtien + "' where maCTHDB = '" + CTHDB.maCTHDB + "'";

            thucthisql(sql);
            dasp.giamsoluongsanpham(CTHDB.MaSP, CTHDB.soluong);
            return 1;
        }
        public bool xoaCTHDB(int maCTHDB)
        {
            {
                string sql = "Delete from ChitietHDB where maCTHDB = '" + maCTHDB + "'";

                thucthisql(sql);
                return true;
            }
        }
        public bool KiemTraTonTaiMaCTHDB(int maCTHDB)
        {
            _con.Open();
            string sql = "SELECT COUNT(*) FROM ChitietHDB WHERE maCTHDB = @maCTHDB";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@maCTHDB", maCTHDB);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count > 0;
        }
        public decimal TinhTongTien(string maHDB)
        {

            decimal Tongtien = 0;

            
            {
                _con.Open();

                string query = "SELECT SUM(tongtien) FROM ChitietHDB WHERE MaHDB = @MaHDB";

                using (SqlCommand command = new SqlCommand(query, _con))
                {
                    command.Parameters.AddWithValue("@MaHDB", maHDB);

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
