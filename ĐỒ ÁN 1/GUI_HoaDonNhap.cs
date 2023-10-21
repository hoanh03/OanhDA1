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
    public partial class GUI_HoaDonNhap : Form
    {
        private BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();
        private BUS_NhanVien busnv = new BUS_NhanVien();
        private BUS_NHACC busNCC = new BUS_NHACC();
        public GUI_HoaDonNhap()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string MaHDN = txtmahdn.Text;
            string MaNV = txtmanv.Text;
            string MaNCC = txtmancc.Text;
            DateTime NgayNhap = DateTime.Parse(dtpbir.Value.ToShortDateString());
            string DonGiaNhap = txtdongianhap.Text;


            if (!busnv.KiemTraTonTaiMaNhanVien(MaNV))
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            // Kiểm tra sự tồn tại của mã nhà cung cấp trong cơ sở dữ liệu
            if (!busNCC.KiemTraTonTaiMaNhaCungCap(MaNCC))
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            DTO_HoaDonNhap HDN = new DTO_HoaDonNhap(MaHDN, MaNV, MaNCC, NgayNhap, DonGiaNhap);
            if (busHDN.kiemtramatrung(MaHDN) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (busHDN.themHDN(HDN) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvdshdn.DataSource = busHDN.getHoaDonNhap();
                    GUI_CTHoaDonNhap f = new GUI_CTHoaDonNhap();
                    f.MaHDN = MaHDN;
                    f.Show();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaHDN = txtmahdn.Text;
            string MaNV = txtmanv.Text;
            string MaNCC = txtmancc.Text;
            DateTime NgayNhap = DateTime.Parse(dtpbir.Value.ToShortDateString());
            string DonGiaNhap = txtdongianhap.Text;


            bool isMaNhanVienValid = busnv.KiemTraTonTaiMaNhanVien(MaNV);
            bool isMaNhaCungCapValid = busNCC.KiemTraTonTaiMaNhaCungCap(MaNCC);

            if (!isMaNhanVienValid)
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            if (!isMaNhaCungCapValid)
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại trong cơ sở dữ liệu!");
                return;
            }
            DTO_HoaDonNhap HDN = new DTO_HoaDonNhap(MaHDN, MaNV, MaNCC, NgayNhap, DonGiaNhap);
            if (busHDN.suaHDN(HDN) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvdshdn.DataSource = busHDN.getHoaDonNhap();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaHDN = txtmahdn.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busHDN.xoaHDN(MaHDN) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvdshdn.DataSource = busHDN.getHoaDonNhap();
                }    
            }    
        }

        private void btntkhdn_Click(object sender, EventArgs e)
        {
            string tuKhoa = txttkhdn.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdomahdn.Checked)
                {
                    int ma = int.Parse(tuKhoa);
                    dt = busHDN.TimKiemHoaDonNhapTheoMa(tuKhoa);
                }
                else
                {
                   
                        dt = busHDN.TimKiemHoaDonNhapTheoManhanvien(tuKhoa);
                    
                }

                dgvdshdn.DataSource = dt;
            }


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvdshdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmahdn.Text = dgvdshdn[0, hang].Value.ToString();
            txtmanv.Text = dgvdshdn[1, hang].Value.ToString();
            txtmancc.Text = dgvdshdn[2, hang].Value.ToString();
            dtpbir.Text = dgvdshdn[3, hang].Value.ToString();
            txtdongianhap.Text = dgvdshdn[4, hang].Value.ToString();
        }

        private void btncthdn_Click(object sender, EventArgs e)
        {
            GUI_CTHoaDonNhap f = new GUI_CTHoaDonNhap();
            f.Show();
        }

        private void GUI_HoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvdshdn.DataSource = busHDN.getHoaDonNhap();
            dgvdshdn.Columns["MaHDN"].HeaderText = "Mã hóa đơn nhập";
            dgvdshdn.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvdshdn.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
            dgvdshdn.Columns["MgayNhap"].HeaderText = "Ngày nhập";
            dgvdshdn.Columns["DonGiaNhap"].HeaderText = "Đơn giá nhập";
        }
        public string MaHDN { get;set; }
    }
}

