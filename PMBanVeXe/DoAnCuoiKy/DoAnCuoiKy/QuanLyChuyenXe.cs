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
    public partial class QuanLyChuyenXe : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = " Data Source=DESKTOP-56FGVUT\\SQLEXPRESS; Initial Catalog=BanVeXe ;Integrated Security=True ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QuanLyChuyenXe()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "select*from ChuyenXe";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                DGVLichXe.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Không Load được dữ liệu");
            }

        }
       
        //void MaXe()
        //{
        //    cmd = con.CreateCommand();
        //    cmd.CommandText = "select MaXe from ChuyenXe ";
        //    adapter.SelectCommand = cmd;
        //    table.Clear();
        //    adapter.Fill(table);
        //    cbxLX_LoaiXe.DataSource = table;
        //    cbxLX_LoaiXe.DisplayMember = "MaXe";
        //}
      
        private void QuanLyLichXe_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            TimLoaiXe();
            //MaXe();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main_BanVeXe Main = new Main_BanVeXe();
            Main.Show();
            Hide();
        }



        //tim ma chuyen xe

        void TimMaChuyenXe()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select*from ChuyenXe where MaChuyenXe='" + txtTimCX.Text + "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGVLichXe.DataSource = table;
            DGVLichXe.Columns[0].HeaderText = "Mã Chuyến Xe";
            DGVLichXe.Columns[1].HeaderText = "Mã Xe";
            DGVLichXe.Columns[2].HeaderText = "Tên Bến Đi";
            DGVLichXe.Columns[3].HeaderText = "Tên Bến Đến";
            DGVLichXe.Columns[4].HeaderText = "Ngày Khởi Hành";
            DGVLichXe.Columns[5].HeaderText = "Giờ Khởi Hành";
        }
        private void btnQLLX_TCXe_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtTimCX.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
           
            else
            {
            
                TimMaChuyenXe();
                txtBDi.Enabled = txtLXeBenDen.Enabled = txtLXeNXp.Enabled = true;
               
            }    

        }
        //random ma khi tao chuyen moi

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGVLichXe.CurrentRow.Index;
            txtTimCX.Text = DGVLichXe.Rows[i].Cells[1].Value.ToString();
            txtBDi.Text = DGVLichXe.Rows[i].Cells[2].Value.ToString();
            txtLXeBenDen.Text = DGVLichXe.Rows[i].Cells[3].Value.ToString();
            txtLXeNXp.Text = DGVLichXe.Rows[i].Cells[5].Value.ToString();
        }
        //sửa và save
        private void btnQLLX_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimCX.Text))
            {
                MessageBox.Show("Vui Lòng Tìm Chuyến Xe ");
                btnQLLX_Save.Enabled = true;
            }
            else
            {
                txtBDi.Enabled = true;
                txtLXeBenDen.Enabled = true;
                NXphat.Enabled = true;
            }

        }
        private void btnQLLX_Save_Click(object sender, EventArgs e)
        {
            DGVLichXe.ReadOnly = false;
            if (string.IsNullOrEmpty(txtTimCX.Text))
            {
                MessageBox.Show("Vui Lòng Tìm Chuyến Xe ");
            }

            else
            {

                cmd = con.CreateCommand();
                cmd.CommandText = " Update ChuyenXe set MaXe ='" + cbxLX_LoaiXe.Text + "' , TenBenDi =N'" + txtBDi.Text + "',TenBenDen=N'"+ txtLXeBenDen .Text+ "',NgayXuatPhat='"+ NXphat.Value.ToString("yyyy-MM-dd") + "' where MaChuyenXe='" + txtTimCX.Text + "'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                DialogResult dlr = MessageBox.Show("Đã Lưu\n Bạn Muốn Xem Thay Đổi", "Thay Đổi Chuyến Xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = " select * from ChuyenXe where MaChuyenXe='" + txtTimCX.Text + "'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    DGVLichXe.DataSource = table;
                }
                
            }
           

        }
  
  
        void TimLoaiXe()
        {


            cmd = con.CreateCommand();
            cmd.CommandText = "  select MaXe from Xe  ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            cbxLX_LoaiXe.DataSource = table;
            cbxLX_LoaiXe.DisplayMember = "MaXe";


        }


        //them chuyen xe
        void ThemChuyenXe()
        {
            Random rand = new Random();
            string kytu = "CX";
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
            txtTimCX.Text = kytu + s;
            DialogResult dlr = MessageBox.Show("\nMã Chuyến Xe:" + txtTimCX.Text +"\nBến Đi:"+ txtBDi.Text +"\n Bến Đến :" + txtLXeBenDen.Text + "\nNgày Xuất Bến:"+ NXphat.Value.ToString("yyyy-MM-dd") + "","Bạn Có Muốn Mở Thêm Chuyến", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into ChuyenXe values('" + txtTimCX.Text + "','X002',N'" + txtBDi.Text + "',N'" + txtLXeBenDen.Text + "','" + NXphat.Value.ToString("yyyy-MM-dd") + "','07:15:00')";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                TimMaChuyenXe();
            }
        }
        private void btn_TCXe_Click(object sender, EventArgs e)
        {
          
            ThemChuyenXe();
        }
        ////reset
        private void btnLX_reset_Click(object sender, EventArgs e)
        {
            txtTimCX.Clear();
            txtBDi.Clear();
            txtLXeBenDen.Clear();
            txtLXeNXp.Clear();
         
        }

        private void QuanLyLichXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Chương Trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLX_XemAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        ////Xem Toan Bo Lich Xe
        private void btnLX_XemAll_Click_1(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from ChuyenXe";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGVLichXe.DataSource = table;
        }
        //// Xoa Chuyen Xe  
        void DeleteChuyenXe()
        {
            if(string.IsNullOrEmpty(txtTimCX.Text))
            {
                MessageBox.Show("Hãy Nhập Chuyến Xe Cần Xóa","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                DialogResult dlr = MessageBox.Show("Mã Xe:"+ txtTimCX.Text+ "\nBến Đi:"+ txtBDi .Text+"\nBến Đến"+ txtLXeBenDen .Text+ "","Bạn Muốn Xóa Chuyến Xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = " delete from ChuyenXe where MaChuyenXe like'" + txtTimCX.Text + "'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    txtTimCX.Clear();
                    txtBDi.Clear();
                    txtLXeBenDen.Clear();
                    MessageBox.Show("Xóa Thành Công","Thông Báo",MessageBoxButtons.OK);
                }
            }
        }
        private void btnLX_Xoa_Click(object sender, EventArgs e)
        {
            DeleteChuyenXe();
        }
        private void btnLX_reset_Click_1(object sender, EventArgs e)
        {
            txtTimCX.Clear();
            txtBDi.Clear();
            txtLXeBenDen.Clear();
        }

       
    }
}
