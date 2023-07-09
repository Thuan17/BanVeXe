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

namespace DoAnCuoiKy
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
        
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G398JU6\SQLEXPRESS; Initial Catalog=BanVeXeNew ;Integrated Security=True ");
            string username = txtTKhoan.Text;
            string paW = txtPW.Text;
            if(username== null ||username.Equals(""))//ký tự trắng ko tồn tại
            {
                MessageBox.Show("Tài Khoản Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(paW== null ||paW.Equals(""))
            {
                MessageBox.Show("Mật Khẩu Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Open();
            string tk = "select * From NhanVien Where userNV='" + txtTKhoan.Text + "' and pWNV='" + txtPW.Text + "'";
            SqlCommand cmd = new SqlCommand(tk, con);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read())
            {
                MessageBox.Show("Đăng Nhập Thành Công\nXin Chào" + username, "Đăng Nhập Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_BanVeXe main = new Main_BanVeXe();
                main.Show();
                Hide();// 
            }
            else
            {
                MessageBox.Show("Tài KHoản Không Tồn Tài", "Đăng Nhập Thất Bại", MessageBoxButtons.OK);
            }
            con.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Chương Trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
