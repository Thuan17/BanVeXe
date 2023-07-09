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

namespace DoAnCuoiKy
{
    public partial class QuanLyXe : Form
    {


        SqlConnection con;
        SqlCommand cmd;
        string str = " Data Source=DESKTOP-56FGVUT\\SQLEXPRESS; Initial Catalog=BanVeXe ;Integrated Security=True ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QuanLyXe()
        {
            InitializeComponent();
        }
        // 
        private void QuanLyLichXe_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();

            LoadData();
        }
        //chức năng
        private void btnQLX_RETURN_Click(object sender, EventArgs e)
        {
            Main_BanVeXe main = new Main_BanVeXe();
            main.Show();
            Hide();
        }
        //cell




        void LoadData()
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "select*from Xe";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                DGVXE.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Không Load được dữ liệu");
            }
        }
        void TimMaXe()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select*from Xe where MaXe='" + txtQLX_maxe.Text + "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGVXE.DataSource = table;

        }

        private void btnQLX_TIM_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtQLX_loaixe.Text))
                {

                    TimMaXe();
                }
                else if (string.IsNullOrEmpty(txtQLX_maxe.Text))
                {
                    MessageBox.Show("Vui Lòng Nhập");
                }


                else
                {
                    MessageBox.Show("Vui Lòng Nhập");
                }
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy","Thông Báo",MessageBoxButtons.OK);
            }
        }

        // SỬA
        private void btnQLX_SUA_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtQLX_maxe.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn Có Muốn Sửa Vé", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    return;
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "update Xe Set LoaiXe =N'" + txtQLX_loaixe.Text + "' where MaXe='" + txtQLX_maxe.Text + "'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    TimMaXe();

                }
            }

        }

        void themchuyenxe()
        {
            Random rand = new Random();
            string kytu = "X";
            string s = "";
            int temp = 9;
            string number;
            int num = 9;
            number = num.ToString();
            List<int> list = new List<int>();
            for (int i = 0; i <= 8; i++)
            {
                list.Add(i);
                //list.Add(rand.Next(a));
            }
            //random
            for (int i = 0; i <= 8; i++)
            {
                temp = rand.Next(list.Count);
                s += list[temp];
                list.RemoveAt(temp);

            }
            txtQLX_maxe.Text = kytu + s;
            LoadData();
            DialogResult dlr = MessageBox.Show(" Mã Xe :" + txtQLX_maxe.Text + "\n Số Ghế: " + txtQLX_soghe.Text + "\n Loại Xe :" + txtQLX_loaixe.Text + "" + "\n\tCảm Ơn Quý Khách ", "Mua Vé Thành Công ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into Xe values('" + txtQLX_maxe.Text + "','" + txtQLX_soghe.Text + "',N'" + txtQLX_loaixe.Text + "')";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                TimMaXe();
            }
        }

        private void btnQLX_THEM_Click(object sender, EventArgs e)
        {
            themchuyenxe();
            LoadData();
        }

        // HỦY

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQLX_maxe.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn Có Muốn Hủy Vé", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    return;
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "Delete from Xe where MaXe like'%" + txtQLX_maxe.Text + "%'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    TimMaXe();
                }
            }
            LoadData();
        }
        private void btnQLX_RESET_Click(object sender, EventArgs e)
        {
            txtQLX_maxe.Clear();
            txtQLX_loaixe.Clear();
            txtQLX_soghe.Clear();
            LoadData();
        }

     


        private void QLXE_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Chương Trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void DGVXE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGVXE.CurrentRow.Index;
            txtQLX_maxe.Text = DGVXE.Rows[i].Cells[0].Value.ToString();
           
            txtQLX_loaixe.Text = DGVXE.Rows[i].Cells[2].Value.ToString();
            
        }
    }
}