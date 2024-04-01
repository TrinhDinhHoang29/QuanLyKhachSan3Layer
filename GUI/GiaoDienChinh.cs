using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Frm_QuanLyKhachSan : Form
    {
        public Frm_QuanLyKhachSan()
        {
            InitializeComponent();
        }

        private void btn_DanhSachQuanLy_Click(object sender, EventArgs e)
        {
            
        }

        private void uC_BaoCaoThongKe1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_BaoCaoThongKe_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            Form frm_QuanLiNhanVien = new Frm_QuanLyNhanVien();
            frm_QuanLiNhanVien.Show();
        }

        private void btn_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            Form frm_QuanLiKhachHang = new Frm_QuanLyKhachHang();
            frm_QuanLiKhachHang.Show();
        }

        private void btn_QuanLyDichVu_Click(object sender, EventArgs e)
        {
            Form frm_QuanLyDichVu = new Frm_QuanLyTienIch();
            frm_QuanLyDichVu.Show();
        }

        private void btn_QuanLyPhong_Click(object sender, EventArgs e)
        {
            Form frm_QuanLyPhong = new Frm_QuanLyPhong();
            frm_QuanLyPhong.Show();
        }

        private void btn_ThongKeDanhThu_Click(object sender, EventArgs e)
        {
            Form frm_ThongKeDanhThu = new Frm_ThongKeDanhThu();
            frm_ThongKeDanhThu.Show();
        }
    }
}
