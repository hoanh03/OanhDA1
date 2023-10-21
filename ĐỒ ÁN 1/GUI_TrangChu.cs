using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒ_ÁN_1
{
    public partial class GUI_TrangChu : Form
    {
        public GUI_TrangChu()
        {
            InitializeComponent();
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            GUI_SanPham f = new GUI_SanPham();
            f.Show();
        }

        private void btnncc_Click(object sender, EventArgs e)
        {
            GUI_NHACC f = new GUI_NHACC();
            f.Show();
        }

        private void btnnv_Click(object sender, EventArgs e)
        {
            GUI_NhanVien f = new GUI_NhanVien();
            f.Show();
        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            GUI_KhachHang f = new GUI_KhachHang();
            f.Show();
        }

        private void btnhdn_Click(object sender, EventArgs e)
        {
            GUI_HoaDonNhap f = new GUI_HoaDonNhap();
            f.Show();
        }

        private void btnhdb_Click(object sender, EventArgs e)
        {
            GUI_HoaDonBan f = new GUI_HoaDonBan();
            f.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                this.Hide();
                GUI_DangNhap frm = new GUI_DangNhap();
                frm.ShowDialog();

            }

        }
    }
}
