using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace ĐỒ_ÁN_1
{
    public partial class GUI_CTHoaDonBan : Form
    {
        BUS_CTHoaDonBan busCTHDB = new BUS_CTHoaDonBan();
        private BUS_HoaDonBan busHDB = new BUS_HoaDonBan();
        private BUS_SanPham bussp = new BUS_SanPham();
        public GUI_CTHoaDonBan()
        {
            InitializeComponent();
            //txtMaHDB.Text = MaHDB.ToString();
        }
        public string MaHDB { get; set; }

        private void dgvdsCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaCTHDB.Text = dgvdsCTHDB[0, hang].Value.ToString();
            txtMaHDB.Text = dgvdsCTHDB[1, hang].Value.ToString();
            txtSP.Text = dgvdsCTHDB[2, hang].Value.ToString();
            txtSL.Text = dgvdsCTHDB[3, hang].Value.ToString();
            txtdongia.Text = dgvdsCTHDB[4, hang].Value.ToString();
            txttongtien.Text = dgvdsCTHDB[5, hang].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            int maCTHDB = int.Parse(txtMaCTHDB.Text);
            string MaHDB = txtMaHDB.Text;
            string masp = txtSP.Text;
            int sl = int.Parse(txtSL.Text);
            //decimal gia = decimal.Parse(txtGia.Text);

            // Kiểm tra sự tồn tại của mã hóa đơn bán và mã sản phẩm trong cơ sở dữ liệu
            if (!busHDB.KiemTraTonTaiHoaDonBan(MaHDB))
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

            // Tạo đối tượng DTO_ChiTietHoaDonBan
            DTO_CTHoaDonBan CTHDB = new DTO_CTHoaDonBan(maCTHDB, MaHDB, masp, sl, gia, tongTien);

            // Kiểm tra mã trùng
            if (busCTHDB.kiemtramatrung(maCTHDB) == 1)
            {
                MessageBox.Show("Mã trùng!");
            }
            else
            {

                // Thực hiện thêm chi tiết hóa đơn bán vào cơ sở dữ liệu
                int result = busCTHDB.themCTHDB(CTHDB);
                if (result == -2)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn 0");
                }
                else if (result == 1)
                    MessageBox.Show("thêm thành công!");
                dgvdsCTHDB.DataSource = busCTHDB.getCTHDB();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int maCTHDB = int.Parse(txtMaCTHDB.Text);
            string MaHDB = txtMaHDB.Text;
            string masp = txtSP.Text;
            int sl = int.Parse(txtSL.Text);
            //decimal gia = decimal.Parse(txtGia.Text);

            decimal gia = bussp.LayGiaSanPham(masp);

            bool isMaHDNValid = busHDB.KiemTraTonTaiHoaDonBan(MaHDB);
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


            // Tính tổng tiền
            decimal tongTien = sl * gia;

            // Tạo đối tượng DTO_ChiTietHoaDonBan
            DTO_CTHoaDonBan CTHDB = new DTO_CTHoaDonBan(maCTHDB, MaHDB, masp, sl, gia, tongTien);

            // Thực hiện thêm chi tiết hóa đơn nhập vào cơ sở dữ liệu
            int result = busCTHDB.suaCTHDB(CTHDB);
            if (result == -2)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0");
            }
            else if (result == 1)
                MessageBox.Show("Sửa thành công!");
            dgvdsCTHDB.DataSource = busCTHDB.getCTHDB();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int maCTHDB = int.Parse(txtMaCTHDB.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busCTHDB.xoaCTHDB(maCTHDB) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvdsCTHDB.DataSource = busCTHDB.getCTHDB();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_CTHoaDonBan_Load(object sender, EventArgs e)
        {
            dgvdsCTHDB.DataSource = busCTHDB.getCTHDB();
            txtMaHDB.Text =MaHDB.ToString();
            dgvdsCTHDB.Columns["maCTHDB"].HeaderText = "Mã chi tiết hóa đơn bán";
            dgvdsCTHDB.Columns["maHDB"].HeaderText = "Mã hóa đơn bán";
            dgvdsCTHDB.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvdsCTHDB.Columns["soluong"].HeaderText = "Số lượng";
            dgvdsCTHDB.Columns["gia"].HeaderText = "Đơn giá";
            dgvdsCTHDB.Columns["tongtien"].HeaderText = "Tổng tiền";
        }

        private void btntongtien_Click(object sender, EventArgs e)
        {
            string maHDB = txtMaHDB.Text;
            decimal tongTien = busCTHDB.TinhTongTien(maHDB);
            txttongtienn.Text = tongTien.ToString();
        }
    }
}
