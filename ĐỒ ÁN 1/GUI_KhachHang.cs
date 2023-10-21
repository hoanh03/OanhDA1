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
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        public GUI_KhachHang()
        {
            InitializeComponent();
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            dgvdskh.DataSource = buskh.getKhachHang();
            dgvdskh.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvdskh.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvdskh.Columns["DiaChiKH"].HeaderText = "Địa chỉ";
            dgvdskh.Columns["SDTKH"].HeaderText = "Số điện thoại";
            dgvdskh.Columns["EmailKH"].HeaderText = "Email";
            dgvdskh.Columns["GioiTinh"].HeaderText = "Giới tính";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtmakh.Text;
            string ten = txttenkh.Text;
            string dc = txtdiachi.Text;
            string sdt = txtdienthoai.Text;
            string email = txtemail.Text;
            string gt = txtgioitinh.Text;

            DTO_KhachHang kh = new DTO_KhachHang(ma, ten, dc, sdt, email, gt);
            if (buskh.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (buskh.themKH(kh) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvdskh.DataSource = buskh.getKhachHang();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //string ma = txtmakh.Text;
            //string ten = txttenkh.Text;
            //string dc = txtdiachi.Text;
            //string sdt = txtdienthoai.Text;
            //string email = txtemail.Text;
            //string gt = txtgioitinh.Text;

            //DTO_KhachHang KH = new DTO_KhachHang(ma, ten, dc, sdt, email, gt);
            //if (buskh.themKH(KH) == true)
            //{
            //    MessageBox.Show("Sửa thành công!");
            //    dgvdskh.DataSource = buskh.getKhachHang();
            //}
            string ma = txtmakh.Text;
            string ten = txttenkh.Text;
            string dc = txtdiachi.Text;
            string sdt = txtdienthoai.Text;
            string email = txtemail.Text;
            string gt = txtgioitinh.Text;

            DTO_KhachHang KH = new DTO_KhachHang(ma, ten, dc, sdt, email, gt);
            if (buskh.suaKH(KH) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvdskh.DataSource = buskh.getKhachHang();
            }
        }

        private void dgvdskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmakh.Text = dgvdskh[0, hang].Value.ToString();
            txttenkh.Text = dgvdskh[1, hang].Value.ToString();
            txtdiachi.Text = dgvdskh[2, hang].Value.ToString();
            txtdienthoai.Text = dgvdskh[3, hang].Value.ToString();
            txtemail.Text = dgvdskh[4, hang].Value.ToString();
            txtgioitinh.Text = dgvdskh[5, hang].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmakh.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (buskh.xoaKH(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvdskh.DataSource = buskh.getKhachHang();
                }
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txttkkh.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdomakh.Checked)
                {
                    string ma = tuKhoa;
                    dt = buskh.TimKiemKhachHangTheoMa(ma);
                }
                else
                {
                    dt = buskh.TimKiemKhachHangTheoTen(tuKhoa);
                }

                dgvdskh.DataSource = dt;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
