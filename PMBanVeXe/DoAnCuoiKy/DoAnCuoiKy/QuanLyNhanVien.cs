using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DTO;

namespace DoAnCuoiKy
{
    public partial class QuanLyNhanVien : Form
    {
        DB con = new DB();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnQLaiMain_Click(object sender, EventArgs e)
        {
            Main_BanVeXe main =new Main_BanVeXe();
            main.Show();
            Hide();
        }

        private void QuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Chương Trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        public void loadNV()
        {
            string nv = "Select *from NhanVien";
            con.DA = new SqlDataAdapter(nv, con.StrConnection);
            con.DA.Fill(con.DS, "NhanVien");

            DataColumn[] key = new DataColumn[1];
            key[0] = con.DS.Tables["NhanVien"].Columns[0];
            con.DS.Tables["NhanVien"].PrimaryKey = key;
            dataGridView1.DataSource = con.DS.Tables["NhanVien"];
        }
        private void Databingdings(DataTable tb)
        {
            txt_MaNV.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            txt_NgaySinh.DataBindings.Clear();
            txt_vaitro.DataBindings.Clear();
            txt_TenNV.DataBindings.Clear();

            txt_MaNV.DataBindings.Add("Text", tb, "MaNV");
            txt_DiaChi.DataBindings.Add("Text", tb, "DiaChi");
            txt_NgaySinh.DataBindings.Add("Text", tb, "NgaySinh");
            txt_vaitro.DataBindings.Add("Text", tb, "ChucNang");
            txt_TenNV.DataBindings.Add("Text", tb, "TenNV");
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadNV();
            Databingdings(con.DS.Tables["NhanVien"]);
        }
        public bool KTThongTin()
        {
            if (txt_TenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNV.Focus();
                return false;
            }
            if (txt_NgaySinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_NgaySinh.Focus();
                return false;
            }
            if (txt_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                return false;
            }
            if (txt_vaitro.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vai trò nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_vaitro.Focus();
                return false;
            }
            return true;
        }
        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QuanlyXe"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "AddEmployee";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_MaNV.Text;
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = txt_TenNV.Text;
                    cmd.Parameters.Add("@Ngsinh", SqlDbType.Date).Value = txt_NgaySinh.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txt_DiaChi.Text;
                    cmd.Parameters.Add("@ChucNang", SqlDbType.NVarChar).Value = txt_vaitro.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    reset();
                    loadNV();
                    MessageBox.Show("Đã thêm mới nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_NgaySinh.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()).ToString("yyyy/MM/dd");
            }
            catch
            {
                txt_NgaySinh.Text = string.Empty;
            }
        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaNV.Focus();
            }
            else if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QuanlyXe"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "DeleteEmployee";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_MaNV.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    reset();
                    loadNV();
                    MessageBox.Show("Đã xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaNV.Focus();
            }
            else if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QuanlyXe"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "EditEmployee";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txt_MaNV.Text;
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = txt_TenNV.Text;
                    cmd.Parameters.Add("@Ngsinh", SqlDbType.Date).Value = txt_NgaySinh.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txt_DiaChi.Text;
                    cmd.Parameters.Add("@ChucNang", SqlDbType.NVarChar).Value = txt_vaitro.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    reset();
                    loadNV();
                    MessageBox.Show("Đã sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void reset()
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            txt_DiaChi.Text = "";
            txt_NgaySinh.Text = "";
            txt_vaitro.Text = "";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

    }
}
