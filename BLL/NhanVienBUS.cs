using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;


namespace BLL
{
   public class NhanVienBUS
    {
        private NhanVienDAL nv = new NhanVienDAL();
        // lưu userName để có gì hiển thị lên giao diện
        private static string userName = "";
        private static string password = "";

        //
        private static int MIN_PASSWORD_LENGTH = 3;
        public static int getMIN_PASWORD()
        {
            return NhanVienBUS.MIN_PASSWORD_LENGTH;
        }
        public static void setUserName(string userName)
        {
            NhanVienBUS.userName = userName;
        }
        public static string getUserName()
        {
            return NhanVienBUS.userName;
        }

        public static void setPassword(string password)
        {
            NhanVienBUS.password = password;
        }

        public static string getPassword()
        {
            return NhanVienBUS.password;
        }
        public DataTable getDataAll ()
        {
            return nv.getDataAll();
        }
        public int insertData(string username,string password,string role)
        {
            return nv.insertData(username, password, role);
        }
        public int updateData(int id,string username,string password,string role)
        {
            return nv.updateData(id, username, password, role);
        }
        public DataTable getDataById(int id)
        {
            return nv.getDataById(id);
        }
        public DataTable selectLike(string username)
        {
            return nv.selectLike(username);
        }
        public int deleteDataSoft(int id)
        {
            return nv.deleteDataSoft(id);
        }
        public bool ValidateLogin(string username, string password)
        {
            // Lấy thông tin người dùng từ database dựa trên username
            DataTable dt = nv.getDataByUsername(username);

            // Kiểm tra xem có dữ liệu trả về từ database hay không
            if (dt.Rows.Count > 0)
            {
                // Lấy mật khẩu từ dữ liệu trả về
                string storedPassword = dt.Rows[0]["password_hash"].ToString();
                // So sánh mật khẩu đã nhập với mật khẩu trong database
                if (password == storedPassword)
                {
                    // Đăng nhập thành công
                    return true;
                }
            }

            // Đăng nhập thất bại
            return false;
        }
        // Phương thức thay đổi mật khẩu cho người dùng với username cụ thể
        public void changePassword(string username, string newPassword)
        {
            // Gọi phương thức updatePassword từ DAL để cập nhật mật khẩu trong cơ sở dữ liệu
            nv.updatePassword(username, newPassword);
        }

    }
}
