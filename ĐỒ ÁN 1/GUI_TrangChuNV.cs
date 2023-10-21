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
    public partial class GUI_TrangChuNV : Form
    {
        public GUI_TrangChuNV()
        {
            InitializeComponent();
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            GUI_SanPham f = new GUI_SanPham();
            f.Show();
        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            GUI_KhachHang f = new GUI_KhachHang();
            f.Show();
        }

        private void btnhdb_Click(object sender, EventArgs e)
        {
            GUI_HoaDonBan f = new GUI_HoaDonBan();
            f.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
