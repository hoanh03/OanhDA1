using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.SqlClient;

namespace ĐỒ_ÁN_1
{
    public partial class GUI_HoaDonBan : Form
    {
        private BUS_HoaDonBan busHDB = new BUS_HoaDonBan();
        private BUS_NhanVien busnv = new BUS_NhanVien();
        private BUS_KhachHang buskh = new BUS_KhachHang();
        public GUI_HoaDonBan()
        {
            InitializeComponent();
        }

        private void GUI_HoaDonBan_Load(object sender, EventArgs e)
        {
            dgvdshdb.DataSource = busHDB.getHoaDonBan();
            dgvdshdb.Columns["MaHDB"].HeaderText = "Mã hóa đơn bán";
            dgvdshdb.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvdshdb.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvdshdb.Columns["Ngayban"].HeaderText = "Ngày bán";
            dgvdshdb.Columns["HinhThucTT"].HeaderText = "Hình thức thanh toán";
            dgvdshdb.Columns["DonGia"].HeaderText = "Đơn giá bán";
        }

        private void dgvdshdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmahdb.Text = dgvdshdb[0, hang].Value.ToString();
            txtmanv.Text = dgvdshdb[1, hang].Value.ToString();
            txtmakh.Text = dgvdshdb[2, hang].Value.ToString();
            dtpbir.Text = dgvdshdb[3, hang].Value.ToString();
            txthinhthuctt.Text = dgvdshdb[4, hang].Value.ToString();
            txtdongiaban.Text = dgvdshdb[5, hang].Value.ToString();
        }

        private void btncthdb_Click(object sender, EventArgs e)
        {
            GUI_CTHoaDonBan f = new GUI_CTHoaDonBan();
            f.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string MaHDB = txtmahdb.Text;
            string MaNV = txtmanv.Text;
            string MaKH = txtmakh.Text;
            DateTime Ngayban = DateTime.Parse(dtpbir.Value.ToShortDateString());
            string HinhThucTT = txthinhthuctt.Text;
            string DonGia = txtdongiaban.Text;


            if (!busnv.KiemTraTonTaiMaNhanVien(MaNV))
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            // Kiểm tra sự tồn tại của mã nhà cung cấp trong cơ sở dữ liệu
            if (!buskh.KiemTraTonTaiMaKhachHang(MaKH))
            {
                MessageBox.Show("Mã khách hàng không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            DTO_HoaDonBan HDB = new DTO_HoaDonBan(MaHDB, MaNV, MaKH, Ngayban,HinhThucTT, DonGia);
            if (busHDB.kiemtramatrung(MaHDB) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (busHDB.themHDB(HDB) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvdshdb.DataSource = busHDB.getHoaDonBan();
                    GUI_CTHoaDonBan f = new GUI_CTHoaDonBan();
                    f.MaHDB = MaHDB;
                    f.Show();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaHDB = txtmahdb.Text;
            string MaNV = txtmanv.Text;
            string MaKH = txtmakh.Text;
            DateTime Ngayban = DateTime.Parse(dtpbir.Value.ToShortDateString());
            string HinhThucTT = txthinhthuctt.Text;
            string DonGia = txtdongiaban.Text;


            bool isMaNhanVienValid = busnv.KiemTraTonTaiMaNhanVien(MaNV);
            bool isMaKhachHangValid = buskh.KiemTraTonTaiMaKhachHang(MaKH);

            if (!isMaNhanVienValid)
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            if (!isMaKhachHangValid)
            {
                MessageBox.Show("Mã khách hàng không tồn tại trong cơ sở dữ liệu!");
                return;
            }
            DTO_HoaDonBan HDB = new DTO_HoaDonBan(MaHDB, MaNV, MaKH, Ngayban, HinhThucTT, DonGia);
            if (busHDB.suaHDB(HDB) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvdshdb.DataSource = busHDB.getHoaDonBan();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaHDB = txtmahdb.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busHDB.xoaHDB(MaHDB) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvdshdb.DataSource = busHDB.getHoaDonBan();
                }
            }
        }

        private void btntkhdb_Click(object sender, EventArgs e)
        {
            string tuKhoa = txttkhdb.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdomahdb.Checked)
                {
                    int ma = int.Parse(tuKhoa);
                    dt = busHDB.TimKiemHoaDonBanTheoMa(tuKhoa);
                }
                else
                {
                    dt = busHDB.TimKiemHoaDonBanTheoManhanvien(tuKhoa);
                }
                dgvdshdb.DataSource = dt;
            }
        }
        public string MaHDB { get; set; }
    }
}
