using BLL;
using DTO;
using Guna.UI2.WinForms;
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
            // Thiết lập nút lưu (btn_Save) là nút mặc định của form
            this.AcceptButton = btn_Save;

            foreach (Control control in Controls)
            {
                if (control is Guna2Button)
                {
                    control.Enter += new EventHandler(this.Button_Enter);
                    control.Leave += new EventHandler(this.Button_Leave);
                }
            }

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

        private void btn_Save_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Save.Focus();
                btn_Save_Click(sender, e);
            }
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            var button = sender as Guna2Button;
            button.BorderColor = Color.Red; // Thiết lập màu border của button khi focus
            button.BorderThickness = 2; // Thiết lập độ dày của border
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            var button = sender as Guna2Button;
            button.BorderColor = Color.Transparent; // Loại bỏ border khi mất focus
            button.BorderThickness = 0; // Loại bỏ border khi mất focus
        }

    }
}