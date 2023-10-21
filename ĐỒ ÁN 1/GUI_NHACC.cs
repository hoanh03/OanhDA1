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
    public partial class GUI_NHACC : Form
    {
        BUS_NHACC busncc = new BUS_NHACC();
        public GUI_NHACC()
        {
            InitializeComponent();
        }

        private void GUI_NHACC_Load(object sender, EventArgs e)
        {
            dgvdsncc.DataSource = busncc.getNHACC();
            dgvdsncc.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
            dgvdsncc.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dgvdsncc.Columns["SDTNCC"].HeaderText = "Số điện thoại";
            dgvdsncc.Columns["DiaChiNCC"].HeaderText = "Địa chỉ";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtmancc.Text;
            string ten = txttenncc.Text;
            string sdt = txtsdt.Text;
            string dc = txtdiachi.Text;
            

            DTO_NHACC nc = new DTO_NHACC(ma, ten, sdt, dc);
            if (busncc.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (busncc.themNCC(nc) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvdsncc.DataSource = busncc.getNHACC();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtmancc.Text;
            string ten = txttenncc.Text;
            string sdt = txtsdt.Text;
            string dc = txtdiachi.Text;

            DTO_NHACC nc = new DTO_NHACC(ma, ten, sdt, dc);

            if (busncc.suaNCC(nc) == true)
            {
                MessageBox.Show("sua thanh cong");
                dgvdsncc.DataSource = busncc.getNHACC();

            }
        }

        private void dgvdsncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmancc.Text = dgvdsncc[0, hang].Value.ToString();
            txttenncc.Text = dgvdsncc[1, hang].Value.ToString();
            txtsdt.Text = dgvdsncc[2, hang].Value.ToString();
            txtdiachi.Text = dgvdsncc[3, hang].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmancc.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busncc.xoaNCC(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvdsncc.DataSource = busncc.getNHACC();
                }
            }
        }

        private void btntimkiemncc_Click(object sender, EventArgs e)
        {
            string tuKhoa = txttkncc.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdomancc.Checked)
                {
                    string ma = tuKhoa;
                    dt = busncc.TimKiemNHACCTheoMa(ma);
                }
                else
                {
                    dt = busncc.TimKiemNHACCTheoTen(tuKhoa);
                }

                dgvdsncc.DataSource = dt;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
