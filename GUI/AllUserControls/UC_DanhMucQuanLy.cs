using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AllUserControls
{
    public partial class UC_DanhMucQuanLy : UserControl
    {
        public UC_DanhMucQuanLy()
        {
            InitializeComponent();
        }


        private void btn_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            Frm_QuanLyKhachHang item = new Frm_QuanLyKhachHang();
            item.Show();
            
        }

        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            Frm_QuanLyNhanVien item = new Frm_QuanLyNhanVien();
            item.Show();
        }

        private void btn_QuanLyTienIch_Click(object sender, EventArgs e)
        {
            Frm_QuanLyTienIch item = new Frm_QuanLyTienIch();
            item.Show();
        }

        private void btn_QuanLyPhong_Click(object sender, EventArgs e)
        {
            Frm_QuanLyPhong item = new Frm_QuanLyPhong();
            item.Show();
        }
    }
}
