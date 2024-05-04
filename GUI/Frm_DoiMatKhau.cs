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

namespace GUI
{
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        NhanVienDTO obj = new NhanVienDTO();// value object
        NhanVienBUS bus = new NhanVienBUS();// Business logic layer
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_Username.Text = BLL.NhanVienBUS.getUserName();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string currentPassword = txt_CurrentPassword.Text;
            string newPassword = txt_NewPassword.Text;
            string confirmNewPassword = txt_ConfirmNewPassword.Text;

            // Kiểm tra xem mật khẩu hiện tại có đúng không
            if (currentPassword == BLL.NhanVienBUS.getPassword())
            {
                // Kiểm tra xem mật khẩu mới và mật khẩu xác nhận có khớp nhau không
                if (newPassword == confirmNewPassword)
                {
                    // Kiểm tra xem mật khẩu mới có đạt yêu cầu không (ví dụ: độ dài và không chứa khoảng trắng)
                    if (newPassword.Length >= BLL.NhanVienBUS.getMIN_PASWORD() && !newPassword.Contains(" "))
                    {
                        // Thực hiện thay đổi mật khẩu ở BLL
                        bus.changePassword(BLL.NhanVienBUS.getUserName(), newPassword);
                        MessageBox.Show("Thay đổi mật khẩu thành công!");
                        this.Close();
                    }
                    else if (newPassword.Contains(" "))
                    {
                        MessageBox.Show("Mật khẩu mới không được chứa khoảng trắng.");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới phải chứa ít nhất " + BLL.NhanVienBUS.getMIN_PASWORD() + " ký tự.");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không khớp nhau.");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng.");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowPassword.Checked)
            {
                txt_NewPassword.PasswordChar = '\0';
                txt_ConfirmNewPassword.PasswordChar = '\0';

            }
            else
            {
                txt_NewPassword.PasswordChar = '*';
                txt_ConfirmNewPassword.PasswordChar = '*';
            }

        }
    }
}
