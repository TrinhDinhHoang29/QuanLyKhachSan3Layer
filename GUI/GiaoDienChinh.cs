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
    public partial class Frm_QuanLyKhachSan : Form
    {
        NhanVienBUS nv = new NhanVienBUS();
        RoomsBUS roomsBus = new RoomsBUS();
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

        private void Frm_QuanLyKhachSan_Load(object sender, EventArgs e)
        {
            updateStatus();
            DataTable dt = roomsBus.getDataAll();
            int tongTrang = dt.Rows.Count;
            float divide = tongTrang / 12f;
            double tongPagination = Math.Ceiling(divide);
            printButtonPagination(tongPagination);
            if (tongTrang >= 12)
            {
                printRooms(0, 12);
            }
            else
            {
                printRooms(0, tongTrang);
            }
        }
        public void printButtonPagination(double length)
        {
            int locationX = 40, locationY = 500;
            for (int i = 1; i <= length; i++)
            {
                buttonPagination(locationX, locationY, i).BringToFront();
                locationX += 110;
            }
        }
        public void printRooms(int start, int end)
        {
            int locationX = 40, locationY = 250;
            DataTable dt = roomsBus.getDataAll();
            start++;
            while(start<=end)
            {
                int idStatus = Convert.ToInt32(dt.Rows[start - 1][5].ToString());
                rooms(locationX, locationY, dt.Rows[start - 1][1].ToString(), "", idStatus).BringToFront();

                locationX += 210;
                if (start % 6 == 0)
                {
                    locationX = 40;
                    locationY = 360;
                }
                start++;
            }
        }
        public Button rooms(int toaDoX,int toaDoY,string tenPhong,string date, int id)
        {
            // Tạo một button mới
            Button button = new Button();
            // Thiết lập vị trí và kích thước của button
            button.Location = new System.Drawing.Point(toaDoX, toaDoY);
            button.Size = new System.Drawing.Size(200, 100);
            // Thiết lập nội dung của button
            button.Text = $"\t {tenPhong}\t \n \t{date}\t";
            button.Font = new System.Drawing.Font(button.Font, System.Drawing.FontStyle.Bold);
            button.ForeColor = System.Drawing.Color.White;
            button.Font = new System.Drawing.Font(button.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
            if (id == 1)
            {
                button.BackColor = System.Drawing.Color.Green;
            }else if (id==2)
                button.BackColor = System.Drawing.Color.Maroon;
            else
                button.BackColor = System.Drawing.Color.DarkOrange;


            // Đăng ký sự kiện Click cho button
            // Thêm button vào Form
            this.Controls.Add(button);
            return button;
        }
        public Button buttonPagination(int toaDoX, int toaDoY, int text)
        {
            // Tạo một button mới
            Button button = new Button();

            // Thiết lập vị trí và kích thước của button
            button.Location = new System.Drawing.Point(toaDoX, toaDoY);
            button.Size = new System.Drawing.Size(100, 50);

            // Thiết lập nội dung của button
            button.Text = $"Khu vực {text} ";
            button.BackColor = System.Drawing.Color.Green;
            button.Click += click_pagination;
            // Đăng ký sự kiện Click cho button
            // Thêm button vào Form
            this.Controls.Add(button);
            return button;
        }
        private void click_pagination(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Lấy ra văn bản của nút
                int buttonText = Convert.ToInt16(clickedButton.Text.Substring(8));
                DataTable dt = roomsBus.getDataAll();
                int tongTrang = dt.Rows.Count;
                float divide = tongTrang / 12f;
                double tongPagination = Math.Ceiling(divide);
                int skip = (buttonText - 1) * 12;
                if (buttonText == tongPagination)
                {
                    panel_ListRooms.BringToFront();
                    printRooms(skip, tongTrang);
                    printButtonPagination(tongPagination);

                }
                else
                {
                    panel_ListRooms.BringToFront();
                    printRooms(skip, skip + 12);
                    printButtonPagination(tongPagination);

                }

                // Hiển thị văn bản của nút trong một hộp thoại

            }

        }
        private void btn_QuanLiTrangThai_Click(object sender, EventArgs e)
        {
            Form frm_QuanLiTrangThai = new Frm_Status();
            frm_QuanLiTrangThai.Show();

        }
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            Form frm_DatPhong = new Frm_PhieuDatPhong();
            frm_DatPhong.Show();
        }

        private void updateStatus()
        {
            DataTable roomsStatus = roomsBus.updateStatus();


            foreach (DataRow row in roomsBus.getDataAll().Rows)
            {
                bool coHieu = false;
                foreach (DataRow rowStatus in roomsStatus.Rows)
                {
                    if (row[0].ToString() == rowStatus[0].ToString())
                    {
                        int roomId = Convert.ToInt32(row[0].ToString());
                        float roomPrice = float.Parse(row[4].ToString());
                        roomsBus.updateData(roomId, row[1].ToString(), row[2].ToString(), row[3].ToString(), roomPrice, 2);
                        coHieu = true;
                    }
                    else if (row[5].ToString() == "6")
                    {
                        coHieu = true;
                        continue;
                    }
                }
                if (coHieu == false)
                {
                    int roomId = Convert.ToInt32(row[0].ToString());
                    float roomPrice = float.Parse(row[4].ToString());
                    roomsBus.updateData(roomId, row[1].ToString(), row[2].ToString(), row[3].ToString(), roomPrice, 1);
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            this.Close();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            Form frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.Show();
            this.Hide(); // Ẩn form hiện tại thay vì đóng nó.
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frm_DoiMatKhau = new Frm_DoiMatKhau();
            frm_DoiMatKhau.Show();
        }


    }
}
