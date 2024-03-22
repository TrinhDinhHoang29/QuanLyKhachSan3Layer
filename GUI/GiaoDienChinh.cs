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
            uC_DanhMucQuanLy1.BringToFront();
            
        }

        private void uC_BaoCaoThongKe1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_BaoCaoThongKe_Click(object sender, EventArgs e)
        {
            uC_BaoCaoThongKe1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_HeThong1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
