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
    public partial class GUI_CTHoaDonNhap : Form
    {
        BUS_CTHoaDonNhap busCTHDN = new BUS_CTHoaDonNhap();
        private BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();
        private BUS_SanPham bussp = new BUS_SanPham();
        public GUI_CTHoaDonNhap()
        {
            InitializeComponent();
            //txtMaHDN.Text = MaHDN.ToString();
        }
        public string MaHDN { get; set; }

        private void GUI_CTHoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvdsCTHDN.DataSource = busCTHDN.getCTHDN();
            //
            txtMaHDN.Text = MaHDN.ToString();
            //
            dgvdsCTHDN.Columns["maCTHDN"].HeaderText = "Mã chi tiết hóa đơn nhập";
            dgvdsCTHDN.Columns["maHDN"].HeaderText = "Mã hóa đơn nhập";
            dgvdsCTHDN.Columns["maSP"].HeaderText = "Mã sản phẩm";
            dgvdsCTHDN.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvdsCTHDN.Columns["gia"].HeaderText = "Đơn giá";
            dgvdsCTHDN.Columns["tongtien"].HeaderText = "Tổng tiền";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            int MaCTHDN = int.Parse(txtMaCTHDN.Text);
            string MaHDN = txtMaHDN.Text;
            string masp = txtSP.Text;
            int sl = int.Parse(txtSL.Text);
            //decimal gia = decimal.Parse(txtGia.Text);

            // Kiểm tra sự tồn tại của mã hóa đơn nhập và mã sản phẩm trong cơ sở dữ liệu
            if (!busHDN.KiemTraTonTaiHoaDonNhap(MaHDN))
            {
                MessageBox.Show("Mã hóa đơn nhập không tồn tại!");
                return;
            }

            decimal gia = bussp.LayGiaSanPham(masp);

            if (!bussp.KiemTraTonTaiSanPham(masp))
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!");
                return;
            }

            // Tính tổng tiền
            decimal tongTien = sl * gia;

            // Tạo đối tượng DTO_ChiTietHoaDonNhap
            DTO_CTHoaDonNhap CTHDN = new DTO_CTHoaDonNhap(MaCTHDN, MaHDN, masp, sl, gia, tongTien);

            // Kiểm tra mã trùng
            if (busCTHDN.kiemtramatrung(MaCTHDN) == 1)
            {
                MessageBox.Show("Mã trùng!");
            }
            else
            {
                // Thực hiện thêm chi tiết hóa đơn nhập vào cơ sở dữ liệu
                int result = busCTHDN.themCTHDN(CTHDN);
                if (result == -2)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn 0");
                }
                else if (result == 1)
                    MessageBox.Show("thêm thành công!");
                dgvdsCTHDN.DataSource = busCTHDN.getCTHDN();
            }    
            
        }

        private void dgvdsCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaCTHDN.Text = dgvdsCTHDN[0, hang].Value.ToString();
            txtMaHDN.Text = dgvdsCTHDN[1, hang].Value.ToString();
            txtSP.Text = dgvdsCTHDN[2, hang].Value.ToString();
            txtSL.Text = dgvdsCTHDN[3, hang].Value.ToString();
            txtdongia.Text = dgvdsCTHDN[4, hang].Value.ToString();
            txttongtien.Text = dgvdsCTHDN[5, hang].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int maCTHDN = int.Parse(txtMaCTHDN.Text);
            string MaHDN = txtMaHDN.Text;
            string masp = txtSP.Text;
            int sl = int.Parse(txtSL.Text);
            //decimal gia = decimal.Parse(txtGia.Text);

            decimal gia = bussp.LayGiaSanPham(masp);

            bool isMaHDNValid = busHDN.KiemTraTonTaiHoaDonNhap(MaHDN);
            bool isMaSPValid = bussp.KiemTraTonTaiSanPham(masp);

            if (!isMaHDNValid)
            {
                MessageBox.Show("Mã hóa đơn nhập không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            if (!isMaSPValid)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại trong cơ sở dữ liệu!");
                return;
            }


            // Tính thành tiền
            decimal thanhtien = sl * gia;

            // Tạo đối tượng DTO_ChiTietHoaDonNhap
            DTO_CTHoaDonNhap CTHDN = new DTO_CTHoaDonNhap(maCTHDN, MaHDN, masp, sl, gia, thanhtien);

            // Thực hiện thêm chi tiết hóa đơn nhập vào cơ sở dữ liệu
            int result = busCTHDN.suaCTHDN(CTHDN);
            if (result == -2)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0");
            }
            else if (result == 1)
                MessageBox.Show("Sửa thành công!");
            dgvdsCTHDN.DataSource = busCTHDN.getCTHDN();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int maCTHDN = int.Parse(txtMaCTHDN.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busCTHDN.xoaCTHDN(maCTHDN) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvdsCTHDN.DataSource = busCTHDN.getCTHDN();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntongtien_Click(object sender, EventArgs e)
        {
            string maHDN = txtMaHDN.Text;
            decimal tongTien = busCTHDN.TinhTongTien(maHDN);
            txttongtienn.Text = tongTien.ToString();
        }
    } 
}
