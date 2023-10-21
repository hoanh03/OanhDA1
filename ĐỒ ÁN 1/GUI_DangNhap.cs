using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ĐỒ_ÁN_1
{
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection _con;
        string _constring = @"Data Source=LAPTOP-ANTLCG4B\SQLEXPRESS;Initial Catalog=doann;Integrated Security=True";

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                _con = new SqlConnection(_constring);
                _con.Open();

                string query = string.Empty;
                Form mainForm = null;

                // Kiểm tra đăng nhập với bảng DangNhap
                query = "SELECT * FROM DangNhap WHERE TenDN = @TenDN and matkhau = @MatKhau";

                SqlCommand cmd = new SqlCommand(query, _con);
                cmd.Parameters.AddWithValue("@TenDN", txttendangnhap.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtmatkhau.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mainForm = new GUI_TrangChu();
                }
                else
                {
                    reader.Close();

                    // Kiểm tra đăng nhập với bảng DangNhapNV
                    query = "SELECT * FROM DangNhapNV WHERE TenDN = @TenDN and matkhau = @MatKhau";

                    cmd = new SqlCommand(query, _con);
                    cmd.Parameters.AddWithValue("@TenDN", txttendangnhap.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtmatkhau.Text);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        mainForm = new GUI_TrangChuNV();
                    }
                }

                reader.Close();

                if (mainForm != null)
                {
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Hãy nhập lại", "Thông báo");
                }
        }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo");
            }
    _con.Close();
        }

        private void ckbHTMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHTMK.Checked == true)
            {
                txtmatkhau.PasswordChar = (char)0;
            }
            else
            {
                txtmatkhau.PasswordChar = '.';
            }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            txtmatkhau.PasswordChar = '.';
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
