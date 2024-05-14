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
        RolesBUS roleBus = new RolesBUS();
        BookingsBUS bookingsBus = new BookingsBUS();
        private string userName;
        public Frm_QuanLyKhachSan(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        public DataTable permissions()
        {
            return roleBus.GetDataTableRoleDetailsById(int.Parse(accounts()[4].ToString()));
        }
        private DataRow accounts()
        {
            return nv.getDataAllByUserName(this.userName).Rows[0];
        }


        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            foreach(DataRow row in permissions().Rows)
            {
                if (row[3].ToString() == "Accounts permission")
                {
                    Form frm_QuanLiNhanVien = new Frm_QuanLyNhanVien(userName);
                    frm_QuanLiNhanVien.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Bạn không có quyền truy cập !!", "Thông báo");
           
            
        }

        private void btn_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in permissions().Rows)
            {
                if (row[3].ToString() == "Customers permission")
                {
                    Form frm_QuanLiKhachHang = new Frm_QuanLyKhachHang();
                    frm_QuanLiKhachHang.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Bạn không có quyền truy cập !!", "Thông báo");
            
        }

        private void btn_QuanLyDichVu_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in permissions().Rows)
            {
                if (row[3].ToString() == "Services permission")
                {
                    Form frm_QuanLyDichVu = new Frm_QuanLyTienIch();
                    frm_QuanLyDichVu.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Bạn không có quyền truy cập !!", "Thông báo");
            
        }

        private void btn_QuanLyPhong_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in permissions().Rows)
            {
                if (row[3].ToString() == "Rooms permission")
                {
                    Form frm_QuanLyPhong = new Frm_QuanLyPhong();
                    frm_QuanLyPhong.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Bạn không có quyền truy cập !!", "Thông báo");
            
        }

        private void btn_ThongKeDanhThu_Click(object sender, EventArgs e)
        {
            Form frm_ThongKeDanhThu = new Frm_ThongKeDoanhThu();
            frm_ThongKeDanhThu.ShowDialog();
        }

        private void Frm_QuanLyKhachSan_Load(object sender, EventArgs e)
        {
            
            updateStatus();
            printCountStatus();
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
        public void printCountStatus()
        {
            DataTable tatCaPhong = roomsBus.getDataAll();
            btn_TatCaPhong.Text = $"Tất cả: {tatCaPhong.Rows.Count}";
            DataTable phongTrong = roomsBus.getDataTrong();
            btn_PhongTrong.Text = $"Phòng trống: {phongTrong.Rows.Count}";
            DataTable coKhach = roomsBus.getDataCoKhach();
            btn_CoKhach.Text = $"Có khách: {coKhach.Rows.Count}";
            DataTable baoTri = roomsBus.getDataBaoTri();
            btn_BaoTri.Text = $"Bảo trì: {baoTri.Rows.Count}";
        }
        public void printRoomsTrong(int start, int end)
        {
            int locationX = 40, locationY = 250;
            DataTable dt = roomsBus.getDataTrong();
            start++;
            while (start <= end)
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
        public void printRoomsCoKhach(int start, int end)
        {
            int locationX = 40, locationY = 250;
            DataTable dt = roomsBus.getDataCoKhach();
            start++;
            while (start <= end)
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
        public void printRoomsBaoTri(int start, int end)
        {
            int locationX = 40, locationY = 250;
            DataTable dt = roomsBus.getDataBaoTri();
            start++;
            while (start <= end)
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
            button.Text = $"\tPhòng: {tenPhong} \t";
            button.Font = new System.Drawing.Font(button.Font, System.Drawing.FontStyle.Bold);
            button.ForeColor = System.Drawing.Color.White;
            button.Font = new System.Drawing.Font(button.Font.FontFamily, 9, System.Drawing.FontStyle.Bold);
            if (id == 1)
            {
                button.BackColor = System.Drawing.Color.Green;
                button.Text += "\n\n\t(Phòng trống)";
                button.Click += room_click1;
            }else if (id == 2)
            {
                DataRow bookingRow = bookingsBus.getDataByIdRoomAndCurrentDate(tenPhong).Rows[0];
                button.BackColor = System.Drawing.Color.Maroon;
                button.Text += $"\nIn: {bookingRow[2].ToString()}\nOut: {bookingRow[3].ToString()}";
                if (bookingRow[4].ToString() == "Paid")
                    button.Text += "\n\n\t(Đã thanh toán)";
                else
                    button.Text += "\n\n\t(Chưa thanh toán)";
                button.Click += room_click;
            }
            else
            {
                button.Text += "\n\n\t(Phòng bảo trì)";
                button.BackColor = System.Drawing.Color.DarkOrange;

            }


            // Đăng ký sự kiện Click cho button
            // Thêm button vào Form
            this.Controls.Add(button);
            return button;
        }
        public void room_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DataRow bookingRow = bookingsBus.getDataByIdRoomAndCurrentDate(int.Parse(button.Text.Split(' ')[1]).ToString()).Rows[0];
            Form hoaDon = new Frm_HoaDon(bookingRow[1].ToString());
            hoaDon.ShowDialog();
        }
        public void room_click1(object sender, EventArgs e)
        {

            Form phieuDatPhong = new Frm_PhieuDatPhong(userName);
            phieuDatPhong.ShowDialog();
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
            button.Font = new System.Drawing.Font(button.Font, System.Drawing.FontStyle.Bold);
            button.ForeColor = System.Drawing.Color.White;
            button.Font = new System.Drawing.Font(button.Font.FontFamily, 10, System.Drawing.FontStyle.Bold);
            button.BackColor = System.Drawing.Color.Gray;
            button.Click += click_pagination;
            // Đăng ký sự kiện Click cho button
            // Thêm button vào Form
            this.Controls.Add(button);
            return button;

        }
        private void click_pagination(object sender, EventArgs e)
        {
            updateStatus();
            printCountStatus();
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
            foreach (DataRow row in permissions().Rows)
            {
                if (row[3].ToString() == "Management permission")
                {
                    Form frm_QuanLiTrangThai = new Frm_Roles();
                    frm_QuanLiTrangThai.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Bạn không có quyền truy cập !!", "Thông báo");
            

        }
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            Form frm_DatPhong = new Frm_PhieuDatPhong(this.userName);
            frm_DatPhong.ShowDialog();
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
                        roomsBus.updateDataNew(roomId, row[1].ToString(), row[2].ToString(), row[3].ToString(), roomPrice, 2);

                        coHieu = true;
                    }
                }
                if (row[5].ToString() == "6")
                {
                    coHieu = true;
                    continue;
                }
                if (coHieu == false)
                {
                    int roomId = Convert.ToInt32(row[0].ToString());
                    float roomPrice = float.Parse(row[4].ToString());
                    roomsBus.updateDataNew(roomId, row[1].ToString(), row[2].ToString(), row[3].ToString(), roomPrice, 1);
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
            frm_DangNhap.ShowDialog();
            this.Hide(); // Ẩn form hiện tại thay vì đóng nó.
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frm_DoiMatKhau = new Frm_DoiMatKhau();
            frm_DoiMatKhau.ShowDialog();
        }

        private void btn_TatCaPhong_Click(object sender, EventArgs e)
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

        private void btn_PhongTrong_Click(object sender, EventArgs e)
        {
            updateStatus();

            DataTable dt = roomsBus.getDataTrong();
            panel_ListRooms.BringToFront();
            int tongTrang = dt.Rows.Count;
            float divide = tongTrang / 12f;
            double tongPagination = Math.Ceiling(divide);
            printButtonPagination(tongPagination);
            if (tongTrang >= 12)
            {
                printRoomsTrong(0, 12);
            }
            else
            {
                printRoomsTrong(0, tongTrang);
            }
        }

        private void btn_CoKhach_Click(object sender, EventArgs e)
        {
            updateStatus();
            DataTable dt = roomsBus.getDataCoKhach();
            panel_ListRooms.BringToFront();
            int tongTrang = dt.Rows.Count;
            float divide = tongTrang / 12f;
            double tongPagination = Math.Ceiling(divide);
            printButtonPagination(tongPagination);
            if (tongTrang >= 12)
            {
                printRoomsCoKhach(0, 12);
            }
            else
            {
                printRoomsCoKhach(0, tongTrang);
            }
        }

        private void btn_BaoTri_Click(object sender, EventArgs e)
        {
            updateStatus();

            DataTable dt = roomsBus.getDataBaoTri();
            panel_ListRooms.BringToFront();
            int tongTrang = dt.Rows.Count;
            float divide = tongTrang / 12f;
            double tongPagination = Math.Ceiling(divide);
            printButtonPagination(tongPagination);
            if (tongTrang >= 12)
            {
                printRoomsBaoTri(0, 12);
            }
            else
            {
                printRoomsBaoTri(0, tongTrang);
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {


            Form frmThanhToan = new Frm_ThanhToan();
            frmThanhToan.ShowDialog();
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            //TabPage tab = tabControl.TabPages[e.Index];
            //Button button = new Button();
            //button.Text = tab.Text;
            //button.BackColor = Color.LightGray; // Màu của nút button
            //button.Size = new Size(80, 30); // Kích thước của nút button
            //e.Graphics.FillRectangle(new SolidBrush(button.BackColor), e.Bounds);
            //e.Graphics.DrawString(button.Text, button.Font, Brushes.Black, e.Bounds, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }

        private void btn_ThongKeHoaDon_Click(object sender, EventArgs e)
        {
            Frm_ThongKePhong frm_ThongKePhong = new Frm_ThongKePhong();
            frm_ThongKePhong.ShowDialog();
        }

        private void Frm_QuanLyKhachSan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
