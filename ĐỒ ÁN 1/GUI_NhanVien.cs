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
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            dgvdsnv.DataSource = busnv.getNhanVien();
            dgvdsnv.Columns["MaNV"].HeaderText = "Mã nhân  viên";
            dgvdsnv.Columns["TenNV"].HeaderText = "Tên nhân  viên";
            dgvdsnv.Columns["GioiTinhNV"].HeaderText = "Giới tính";
            dgvdsnv.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvdsnv.Columns["Diachi"].HeaderText = "Địa chỉ";
            dgvdsnv.Columns["SDTNV"].HeaderText = "Số điện thoại";
            dgvdsnv.Columns["EmailNV"].HeaderText = "Email";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtmanv.Text;
            string ten = txttennv.Text;
            string gt = txtgioitinh.Text;
            DateTime ns = DateTime.Parse(dtpBir.Value.ToShortDateString());
            string dc = txtdiachi.Text;
            string sdt = txtdienthoai.Text;
            string email = txtemail.Text;

            DTO_NhanVien nv = new DTO_NhanVien(ma, ten, gt, ns, dc,sdt,email);
            if (busnv.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (busnv.themNV(nv) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvdsnv.DataSource = busnv.getNhanVien();
                }
            }
        }


        private void btnsua_Click(object sender, EventArgs e)
        {

            string ma = txtmanv.Text;
            string ten = txttennv.Text;
            string gt = txtgioitinh.Text;
            DateTime ns = DateTime.Parse(dtpBir.Value.ToShortDateString());
            string dc = txtdiachi.Text;
            string sdt = txtdienthoai.Text;
            string email = txtemail.Text;

            DTO_NhanVien nv = new DTO_NhanVien(ma, ten, gt, ns, dc, sdt, email);
            if (busnv.suaNV(nv) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvdsnv.DataSource = busnv.getNhanVien();
            }
        }

        private void dgvdsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmanv.Text = dgvdsnv[0, hang].Value.ToString();
            txttennv.Text = dgvdsnv[1, hang].Value.ToString();
            txtgioitinh.Text = dgvdsnv[2, hang].Value.ToString();
            dtpBir.Text = dgvdsnv[3, hang].Value.ToString();
            txtdiachi.Text = dgvdsnv[4, hang].Value.ToString();
            txtdienthoai.Text = dgvdsnv[5, hang].Value.ToString();
            txtemail.Text = dgvdsnv[6, hang].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmanv.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busnv.xoaNV(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvdsnv.DataSource = busnv.getNhanVien();
                }
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txttknv.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdomanv.Checked)
                {
                    string ma = tuKhoa;
                    dt = busnv.TimKiemNhanVienTheoMa(ma);
                }
                else
                {
                    dt = busnv.TimKiemNhanVienTheoTen(tuKhoa);
                }

                dgvdsnv.DataSource = dt;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
