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
    public class DAL_NHACC : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị dsncc ra ngoài màn hình
        public DataTable getNHACC()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from NHACC", _con);
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
                string sql = "SELECT COUNT(*) FROM NHACC WHERE MaNCC = @MaNCC";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaNCC", ma);
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
        public bool themNCC(DTO_NHACC nc)
        {
            string sql = "Insert into NHACC values(N'" + nc.MaNCC + "',N'" + nc.TenNCC + "',N'" + nc.SDTNCC + "','" + nc.DiaChiNCC + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaNCC(DTO_NHACC nc)
        {
            string sql = "Update NHACC set TenNCC = N'" + nc.TenNCC + "', SDTNCC = '" + nc.SDTNCC + "',DiaChiNCC = N'" + nc.DiaChiNCC + "' where MaNCC = '" + nc.MaNCC + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaNCC(string ma)
        {
            {
                string sql = "Delete from NHACC where MANCC = '" + ma + "'";

                thucthisql(sql);
                return true;
            }
        }
        public DataTable TimKiemNHACCTheoMa(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM NHACC WHERE MaNCC = @MaNCC", _con);
            da.SelectCommand.Parameters.AddWithValue("@MaNCC", ma);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable TimKiemNHACCTheoTen(string ten)
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM NHACC WHERE TenNCC LIKE '%' + @TenNCC + '%'", _con);
            da.SelectCommand.Parameters.AddWithValue("@TenNCC", ten);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool KiemTraTonTaiMaNhaCungCap(string MaNCC)
        {
            _con.Open();
            string sql = "SELECT COUNT(*) FROM NHACC WHERE MaNCC = @MaNCC";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@MaNCC", MaNCC);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count > 0;
        }

    }

}
