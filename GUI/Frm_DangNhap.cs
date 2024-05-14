using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL; // business logic layer
using DTO;// value object

namespace GUI
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;   
        }
        NhanVienDTO obj = new NhanVienDTO();// value object
        NhanVienBUS bus = new NhanVienBUS();// Business logic layer
        RolesBUS rolesBus = new RolesBUS();
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Gọi phương thức kiểm tra đăng nhập từ BLL
            bool isAuthenticated = bus.ValidateLogin(username, password);

            // Kiểm tra kết quả đăng nhập
            if (isAuthenticated)
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
                // Chuyển hướng đến giao diện chính
                // Ví dụ: MainForm mainForm = new MainForm();
                Form form = new Frm_QuanLyKhachSan(username);
                BLL.NhanVienBUS.setUserName(username);
                BLL.NhanVienBUS.setPassword(password);
                form.Show();
                //mainForm.Show();
                //this.Hide(); // ẩn form đăng nhập
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                labelError.Visible = true;
                labelError.Text = "Tên đăng nhập hoặc mật khẩu sai.";
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.Focus();
                btnLogin_Click(sender, e);
            }
        }
    }
}
