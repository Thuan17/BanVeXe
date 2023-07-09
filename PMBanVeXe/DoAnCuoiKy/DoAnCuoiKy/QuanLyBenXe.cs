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
    public partial class QuanLyBenXe : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = " Data Source=DESKTOP-56FGVUT\\SQLEXPRESS; Initial Catalog=BanVeXe ;Integrated Security=True ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public QuanLyBenXe()
        {
            InitializeComponent();
        }
        ////load toan bo ben xe
       
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //////Chức năng
        private void btnLX_return_Click(object sender, EventArgs e)
        {
            Main_BanVeXe mainn=new Main_BanVeXe();
            mainn.Show();
            Hide(); 


        }

        private void QuanLyBenXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Chương Trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        //xem toan bo
        void loadToanBoBen()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELect * from BenXe";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataBenXe.DataSource = table;
        }
        private void btn_XemToanBo_Click(object sender, EventArgs e)
        {
            loadToanBoBen();
        }

        //ten toan bo xe
        void TenBenXe()
        {

            cmd = con.CreateCommand();
            cmd.CommandText = " SELect TenBenXe from BenXe  ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            cbx_TenBenXe.DataSource = table;
            cbx_TenBenXe.DisplayMember = "TenBenXe";

        }
        private void QuanLyBenXe_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            TenBenXe();
        }
        ////Tìm Bến Xe
      
        void TimBen()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELect * from BenXe where TenBenXe like N'"+ cbx_TenBenXe.Text+ "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataBenXe.DataSource = table;
           
        }

        private void btnQLLX_TCXe_Click(object sender, EventArgs e)
        {
           
            TimBen();
        }

        /////Thêm BẾn
        private void ck_ThemBenMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ThemBenMoi.Checked == true)
            {
                btn_TCXe.Visible = true;
                txtThemBenXe.Visible = true;
              
                label_Tinh.Visible = true;
                label_TenBen.Visible = true;
                txtThemTinh.Visible=true;
                gThemBen.Visible=true;
            }
            else
            {
                btn_TCXe.Visible = false;
                
                txtThemBenXe.Visible = false;
                label_Tinh.Visible = false;
                label_TenBen.Visible = false;
                txtThemTinh.Visible = false;
                gThemBen.Visible = false;
            }

        }
        void ThemBEn()
        {
            try
            {
                if((string.IsNullOrEmpty(txtThemBenXe.Text)))
                {
                    MessageBox.Show("Vui Lòng Nhập Tên Bến Xe","Thông Báo",MessageBoxButtons.OK);
                }  
                else if((string.IsNullOrEmpty(txtThemTinh.Text)))
                {
                    MessageBox.Show("Vui Lòng Nhập Tỉnh Bến Xe", "Thông Báo", MessageBoxButtons.OK);
                } 
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "insert into BenXe values(N'" + txtThemBenXe.Text + "',N'" + txtThemTinh.Text + "')";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                }
            }
            catch
            {
                MessageBox.Show("Bến Xe Đã Tồn Tại");
            }
         
        }
        private void btn_TCXe_Click(object sender, EventArgs e)
        {
           
            DialogResult dlr = MessageBox.Show("Tên Bến Xe :"+ txtThemBenXe.Text +"\n Tỉnh Bến:"+ txtThemTinh.Text +"", "Bạn Muốn Mở Thêm Bến Xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                ThemBEn();
                MessageBox.Show("Thêm Bến Thành Công", "Thông Báo", MessageBoxButtons.OK);
                gThemBen.Visible = false;
                loadToanBoBen();
            }
            else
            {
                MessageBox.Show("Đã Hủy Thêm Bến Xe", "Thông Báo");
            }
           
        }
        /////sưa  BẾn
        private void rd_SuaBen_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_SuaBen.Checked == true)
            {
                btnQLLX_Save.Enabled = true;
                Txt_Tinh.Enabled = true;
            }
            else
            {
                btnQLLX_Save.Enabled = false;
                Txt_Tinh.Enabled = false;
            }

        }
        void SuaDoiBenXe()
        {
                cmd = con.CreateCommand();
                cmd.CommandText = "update BenXe set Tinh=N'Tp.Vũng Tàu'  where TenBenXe=N'" + cbx_TenBenXe.Text + "'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                MessageBox.Show("Thay Đổi Địa Chỉ Bến Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnQLLX_Save_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Tên Bến Xe :" + cbx_TenBenXe.Text + "\nĐịa Chỉ Mới :" + Txt_Tinh.Text + "", "Bạn Muốn Đổi Địa Chỉ Bến Xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                SuaDoiBenXe();
                TenBenXe();
            }
            else
            {
                MessageBox.Show("Đã Hủy Thay Đổi", "Thông Báo");
            }
        }

        //XÓa Bến Xe
       
        //cell
        private void dataBenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataBenXe.CurrentRow.Index;
            Txt_Tinh.Text = dataBenXe.Rows[i].Cells[1].Value.ToString();
            
        }

        private void btnLX_reset_Click(object sender, EventArgs e)
        {
            TenBenXe();
            loadToanBoBen();
        }
    }








        /////Xóa  BẾn
    
}
