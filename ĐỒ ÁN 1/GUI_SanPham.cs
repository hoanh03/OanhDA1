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
    public partial class GUI_SanPham : Form
    {
        BUS_SanPham bussp = new BUS_SanPham();
        public GUI_SanPham()
        {
            InitializeComponent();
        }

        private void GUI_SanPham_Load(object sender, EventArgs e)
        {
            dgvdssp.DataSource = bussp.getSanPham();
            dgvdssp.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvdssp.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvdssp.Columns["Mausac"].HeaderText = "Màu sắc";
            dgvdssp.Columns["Size"].HeaderText = "Size";
            dgvdssp.Columns["ChatLieu"].HeaderText = "Chất liệu";
            dgvdssp.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvdssp.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtmasp.Text;
            string ten = txttensp.Text;
            string ms = txtmau.Text;
            string sz = txtsize.Text;
            string cl = txtchatlieu.Text;
            int dg = int.Parse(txtdongia.Text);
            int sl = int.Parse(txtsoluong.Text);

            DTO_SanPham SP = new DTO_SanPham(ma, ten, ms, sz, cl, dg, sl);
            if (bussp.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else 
            {
                 
                int result = bussp.themSP(SP);
                if (result == -1)
                {
                    MessageBox.Show("Giá không được nhỏ hơn 0");
                }
                else if (result == -2)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn 0 ");

                }  
                else if (result == 1)
                {
                    MessageBox.Show("Thêm thành công! ");
                    dgvdssp.DataSource = bussp.getSanPham();
                }    

            }
        }

        private void dgvdssp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmasp.Text = dgvdssp[0, hang].Value.ToString();
            txttensp.Text = dgvdssp[1, hang].Value.ToString();
            txtmau.Text = dgvdssp[2,hang].Value.ToString(); 
            txtsize.Text = dgvdssp[3, hang].Value.ToString();
            txtchatlieu.Text = dgvdssp[4, hang].Value.ToString();
            txtdongia.Text = dgvdssp[5, hang].Value.ToString();
            txtsoluong.Text = dgvdssp[6, hang].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string masp = txtmasp.Text;
            string tensp = txttensp.Text;
            string ms = txtmau.Text;
            string sz = txtsize.Text;
            string cl = txtchatlieu.Text;
            int gia = int.Parse(txtdongia.Text);
            int sl = int.Parse( txtsoluong.Text);
            DTO_SanPham sp = new DTO_SanPham(masp, tensp, ms, sz, cl, gia, sl);
            int result = bussp.suaSP(sp);
            if (result == -1)
            {
                MessageBox.Show("Giá không được nhỏ hơn 0");
            }
            else if (result == -2)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0 ");

            }
            else if (result == 1)
            {
                MessageBox.Show("Sửa thành công! ");
                dgvdssp.DataSource = bussp.getSanPham();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmasp.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (bussp.xoaSP(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvdssp.DataSource = bussp.getSanPham();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKSPP.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdoTKMSP.Checked)
                {
                    string ma = tuKhoa;
                    dt = bussp.TimKiemSanPhamTheoMa(ma);
                }
                else
                {
                    dt = bussp.TimKiemSanPhamTheoTen(tuKhoa);
                }

                dgvdssp.DataSource = dt;
            }
        }

        private void c(object sender, EventArgs e)
        {

        }
    }
}
