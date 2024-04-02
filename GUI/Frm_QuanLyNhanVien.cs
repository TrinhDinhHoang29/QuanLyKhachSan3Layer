using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Frm_QuanLyNhanVien : Form
    {
        NhanVienBUS nv = new NhanVienBUS();
        public Frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dGridView_NhanVien.DataSource = nv.getDataAll();
        }

        private void btn_ThemAccount_Click(object sender, EventArgs e)
        {
            try
            {
                int checkInsertAccount = nv.insertData(txt_TenDangNhap.Text, txt_MatKhau.Text, txt_LoaiTaiKhoang.Text);
                MessageBox.Show("Update thành công");
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex+ txt_TenDangNhap.Text);
            }
          

        }
    }
}
