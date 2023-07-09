using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Collections;


//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

namespace DoAnCuoiKy
{

    public partial class Main_BanVeXe : Form
    {
        DB connection;
        DataColumn[] primaryKey;
        SqlDataAdapter adapter1, adapter2;
      



        public Main_BanVeXe()
        {
            InitializeComponent();
            connection = new DB();
            primaryKey = new DataColumn[1];
        }

        /////main load
        private void Form1_Load(object sender, EventArgs e)
        {

            ///lich Xe
            loadDGView();
            LoadMaChuyenXe();



            LoadDGVChuyenXe();
         
            loadCBX();
            
        }

        private void btnCN_Ex_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Chương Trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        ///////////////////////////Quản Lý Vé Xe///////////////////////////


        void FindMaVe()
        {
            string FindVe = "select * from Ve where MaVe like'%" + textBoxQLV_MaVe.Text + "%'";
            var table = connection.GetDataTable(FindVe, "Ve");
            DataGViewQLV.DataSource = table;
            DataGViewQLV.Columns[0].HeaderText = "Mã Vé";
            DataGViewQLV.Columns[1].HeaderText = "Mã Chuyến Xe";
            DataGViewQLV.Columns[2].HeaderText = "Tên Bến Đi";
            DataGViewQLV.Columns[3].HeaderText = "Tên Bến Đến";
            DataGViewQLV.Columns[4].HeaderText = "Tên Khách Hàng";
            DataGViewQLV.Columns[5].HeaderText = "Giá Vé";
            DataGViewQLV.Columns[6].HeaderText = "Giờ Khởi Hành";
            DataGViewQLV.Columns[7].HeaderText = "Ngày Khởi Hành";



        }
        void LoadFull()
        {
            string FindVe = "select * from Ve ";
            var table = connection.GetDataTable(FindVe, "Ve");
            DataGViewQLV.DataSource = table;
            DataGViewQLV.Columns[0].HeaderText = "Mã Vé";
            DataGViewQLV.Columns[1].HeaderText = "Mã Chuyến Xe";
            DataGViewQLV.Columns[2].HeaderText = "Tên Bến Đi";
            DataGViewQLV.Columns[3].HeaderText = "Tên Bến Đến";
            DataGViewQLV.Columns[4].HeaderText = "Tên Khách Hàng";
            DataGViewQLV.Columns[5].HeaderText = "Giá Vé";
            DataGViewQLV.Columns[6].HeaderText = "Giờ Khởi Hành";
            DataGViewQLV.Columns[7].HeaderText = "Ngày Khởi Hành";
        }
 
    
      void loadDGView()
        {
            
            try
            {
                string selection = "select *from Ve   where MaChuyenXe like'%" + cbxQLV.Text + "%'";
                var table = connection.GetDataTable(selection, "Ve");
                DataGViewQLV.DataSource = table;
                DataGViewQLV.Columns[0].HeaderText = "Mã Vé";
                DataGViewQLV.Columns[1].HeaderText = "Mã Chuyến Xe";
                DataGViewQLV.Columns[2].HeaderText = "Tên Bến Đi";
                DataGViewQLV.Columns[3].HeaderText = "Tên Bến Đến";
                DataGViewQLV.Columns[4].HeaderText = "Tên Khách Hàng";
                DataGViewQLV.Columns[5].HeaderText = "Giá Vé";
                DataGViewQLV.Columns[6].HeaderText = "Giờ Khởi Hành";
                DataGViewQLV.Columns[7].HeaderText = "Ngày Khởi Hành";

            }
            catch
            {
                MessageBox.Show("Không Load được dữ liệu");
            }
        }

     
        ///Tìm Theo Mã Chuyến Xe
        private void btnQLV_Tim_Click(object sender, EventArgs e)
        {
            loadDGView();
        }
        private void btnTim_MVe_Click(object sender, EventArgs e)
        {
            FindMaVe();
        }
        private void textBoxQLV_MaVe_TextChanged(object sender, EventArgs e)
        {
            btnTim_MVe.Enabled = true;
        }

        //// click 
        private void DataGViewQLV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DataGViewQLV.CurrentRow.Index;
            textBoxQLV_MaVe.Text= DataGViewQLV.Rows[i].Cells[0].Value.ToString();
            cbxQLV.Text= DataGViewQLV.Rows[i].Cells[1].Value.ToString();
            txt_BDi.Text = DataGViewQLV.Rows[i].Cells[2].Value.ToString();
            txt_BDen.Text = DataGViewQLV.Rows[i].Cells[3].Value.ToString();
            textBoxQLY_NameKH.Text= DataGViewQLV.Rows[i].Cells[4].Value.ToString();
            textBoxQLY_Gia.Text= DataGViewQLV.Rows[i].Cells[5].Value.ToString();
            txt_GXp.Text= DataGViewQLV.Rows[i].Cells[6].Value.ToString();
            txtQLV_NXP.Text= DataGViewQLV.Rows[i].Cells[7].Value.ToString();
        }

        //load gio
     
        //sửa đổi vé xe
        private void btnQLV_edit_Click(object sender, EventArgs e)
        {
            DataGViewQLV.ReadOnly = false;
            if (string.IsNullOrEmpty(textBoxQLV_MaVe.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                string CNhap = "update Ve Set TenKhachHang =N'" + textBoxQLY_NameKH.Text + "' where MaVe='" + textBoxQLV_MaVe.Text + "'";
              
                DialogResult r;
                r = MessageBox.Show("Bạn Có Muốn Chỉnh Sửa Vé ", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    return;
                }
                else
                {
              
                    var table = connection.GetDataTable(CNhap, "Ve");
                    DataGViewQLV.DataSource = table;
                    loadDGView();
                }
            }

        }
        private void ck_SuaVe_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_SuaVe.Checked == true)
            {
                textBoxQLV_MaVe.Enabled =true;
                btnQLV_edit.Enabled=true;
            }
            else
            {
                textBoxQLV_MaVe.Enabled = false;
                btnQLV_edit.Enabled = false;
            }

        }
        //hủy vé xe
        private void btnQLV_Huy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxQLV_MaVe.Text))
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
                    string HVe = "Delete from Ve where MaVe like'%" + textBoxQLV_MaVe.Text + "%'";
                    var table = connection.GetDataTable(HVe, "Ve");
                    DataGViewQLV.DataSource = table;
                    loadDGView();
                }
            }
           
        }
        private void ck_HuyVe_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_HuyVe.Checked == true)
            {
                
                btnQLV_Huy.Enabled = true;
            }
            else
            {
                btnQLV_Huy.Enabled = false;
            }

        }

        //load cbox ma chuyen xe
        void loadCBX()
        {
            try
            {
                string selection = "select MaChuyenXe from ChuyenXe";
                var table = connection.GetDataTable(selection,"ChuyenXe");
                cbxQLV.DataSource = table;
          
                cbxQLV.DisplayMember = "MaChuyenXe";
            }
            catch
            {
                MessageBox.Show("Không Load được dữ liệu");
            }
        }

     
        void DataBing(DataTable pDT)
        {

            txt_BDi.DataBindings.Add("Text", pDT, "TenBenDi");
        }
        void loadTenBenDi()
        {
            string BenDi = "Select TenBenDi from ChuyenXe where MaCHuyenXe like'CX013825467 '";
        }
        //Mua Vé Xe
        private void btnQLV_Buy_Click(object sender, EventArgs e)
        {
            txt_BDi.Enabled=false;
            txt_BDen.Enabled=false;
           
            if((string.IsNullOrEmpty(txt_BDi.Text))||(string.IsNullOrEmpty(txt_BDen.Text)))
            {
                MessageBox.Show("Vui Lòng Chọn Bến");

            }
            else
            {
              
                if (string.IsNullOrEmpty(textBoxQLY_NameKH.Text))
                {
                    MessageBox.Show("Vui Lòng Nhập Tên Khách Hàng");
                }
                else
                {
                    if (string.IsNullOrEmpty(cbxQLV.Text))
                    {
                        MessageBox.Show("Vui Lòng Chọn Chuyến Xe !", "Thông Báo");
                    }
                    else
                    {
                        Random rand = new Random();
                        string kytu = "V";
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
                        textBoxQLV_MaVe.Text = kytu + s;
                        loadDGView();
                        DialogResult dlr = MessageBox.Show("Mã Vé :" + textBoxQLV_MaVe.Text + "\nTên Khách Hàng: " + textBoxQLY_NameKH.Text + "\n Mã Chuyến Xe :" + cbxQLV.Text + "\n Bến Đi :" + txt_BDi.Text + "\n Bến Đi :" + txt_BDen.Text + "\n Giá :" + textBoxQLY_Gia.Text + "\n Giờ Xuất Phát:" + txt_GXp.Text + "\n Ngày Đi :" + txtQLV_NXP.Text + "\n\tCảm Ơn Quý Khách ", "Mua Vé Thành Công ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            string MuaVe = "insert into Ve values('" + textBoxQLV_MaVe.Text + "','" + cbxQLV.Text + "',N'" + txt_BDi.Text + "',N'" + txt_BDen.Text + "',N'" + textBoxQLY_NameKH.Text + "', '" + textBoxQLY_Gia.Text + "','" + txt_GXp.Text + "','" + txtQLV_NXP.Text + "')";
                            var table = connection.GetDataTable(MuaVe, "Ve");
                            DataGViewQLV.AllowUserToAddRows = true;
                            DataGViewQLV.DataSource = table;
                            loadDGView();
                        }
                        else
                        {

                        }
                    }
                }
            }

        }
        private void ck_MuaVe_CheckedChanged(object sender, EventArgs e)
        {
            if(ck_MuaVe.Checked==true)
            {
                btnQLV_Buy.Enabled = true;
                textBoxQLY_NameKH.Enabled = true;
                textBoxQLV_MaVe.Enabled = false;
                
            }    
            else
            {
                btnQLV_Buy.Enabled = false;
                textBoxQLY_NameKH.Enabled = false;
                textBoxQLV_MaVe.Enabled = true;
            }
        }




        ///////////////////////////Mo from ///////////////////////////
        private void btnCN_CXe_Click(object sender, EventArgs e)
        {
            QuanLyChuyenXe Child = new QuanLyChuyenXe();
            Child.Show();
            Hide();
        }
        //Quan ly Xe 
        private void btnCN_QLLXe_Click(object sender, EventArgs e)
        {
            QuanLyXe Child = new QuanLyXe();
            Child.Show();
            Hide();
        }

     

        private void btnQLV_Reset_Click(object sender, EventArgs e)
        {
            loadCBX();
            loadDGView();
            LoadFull();

            textBoxQLV_MaVe.Clear();
            textBoxQLY_NameKH.Clear();
            
            textBoxQLY_Gia.Clear();
            txt_GXp.Clear();
            txtQLV_NXP.Clear();
            // Enabled
            
            btnTim_MVe.Enabled = false;
            textBoxQLV_MaVe.Enabled = true;
      
            //DataGViewQLV.DataSource = null;

            //data gv

        }
        void TimMaChuyenXe()
        {
            string find = " select MaChuyenXe from Ve where TenBenDi like N'"+ txt_BDi .Text+ "' and TenBenDen like N'"+ txt_BDen .Text+ "'";
            var table = connection.GetDataTable(find, "Ve");
            cbxQLV.DataSource = table;
            cbxQLV.DisplayMember = "MaChuyenXe";

        }
     
      
        private void btnTMCX_Click(object sender, EventArgs e)
        {
            try
            {
                string TMCK = "Select MaChuyenXe from ChuyenXe where TenBenDi =N'" + txt_BDi.Text + "' and TenBenDen =N'" + txt_BDen.Text + "'";
                var table = connection.GetDataTable(TMCK, "ChuyenXe");
                cbxQLV.DataSource = table;
                cbxQLV.DisplayMember = "MaChuyenXe";
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy Bến Xe", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnCN_BXe_Click(object sender, EventArgs e)
        {
            QuanLyBenXe benxe = new QuanLyBenXe();
            benxe.Show();
            Hide();
        }

        private void btnCN_NVien_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien nhanvien = new QuanLyNhanVien();
            nhanvien.Show();
            Hide();
        }

        private void btn_XAll_Click(object sender, EventArgs e)
        {
            LoadFull();
        }






        //////////////////////////////QLLCX///////////////////////////
        // chức năng
        private void btnCN_LogOut_Click(object sender, EventArgs e)
        {
            DangNhap LogIn = new DangNhap();
            LogIn.Show();
            Hide();//đong from
        }


        ///////////////////////////QLLXe///////////////////////////
        void LoadDGVChuyenXe()
        {

            string ma = "select * from ChuyenXe";

            var table = connection.GetDataTable(ma, "ChuyenXe");
            DGVLX.DataSource = table;



        }

        void LoadMaChuyenXe()
        {
            try
            {
                string selection = "select MaChuyenXe from ChuyenXe";
                var table = connection.GetDataTable(selection, "ChuyenXe");
                cbxLX_MCX.DataSource = table;

                cbxLX_MCX.DisplayMember = "MaChuyenXe";
            }
            catch
            {
                MessageBox.Show("Không Load được dữ liệu2 ");
            }
        }
        void FindCX1()
        {

            string findCX = "select * from ChuyenXe where MaChuyenXe ='" + cbxLX_MCX.Text + "'";
            var table = connection.GetDataTable(findCX, "ChuyenXe");
            DGVLX.DataSource = table;


        }
     
        private void btnLX_ALL_Click(object sender, EventArgs e)
        {
            LoadDGVChuyenXe();
        }

        private void DGVLX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGVLX.CurrentRow.Index;
            cbxLX_MCX.Text = DGVLX.Rows[i].Cells[0].Value.ToString();

            txtLX_bendi.Text = DGVLX.Rows[i].Cells[2].Value.ToString();
            txtLX_benden.Text = DGVLX.Rows[i].Cells[3].Value.ToString();
            txtLX_GXP.Text = DGVLX.Rows[i].Cells[5].Value.ToString();
            txtLX_NXP.Text = DGVLX.Rows[i].Cells[4].Value.ToString();
        }

       

        private void btnLX_TIM_Click(object sender, EventArgs e)
        {
            FindCX1();
        }

    }
}
