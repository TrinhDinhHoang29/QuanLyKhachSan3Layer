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

        private static int id;
        private static string userName;
        private static string pass;

        public static int getId()
        {
            return id;
        }
        public static void setId(int id)
        {
            id = id;
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
    }
}
