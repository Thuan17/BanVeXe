using System;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Form2());
            Application.Run(new DangNhap());
            //Application.Run(new QuanLyLichXe());
            //Application.Run(new Main_BanVeXe());
            //Application.Run(new QuanLyBenXe());
            //Application.Run(new QuanLyChuyenXe());
            //Application.Run(new QuanLyNhanVien());
            //Application.Run(new QuanLyXe());

        }
    }
}
