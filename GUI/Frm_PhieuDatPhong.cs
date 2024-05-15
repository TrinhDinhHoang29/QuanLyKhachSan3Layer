using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BLL;
using Guna.UI2.WinForms;
using System.Diagnostics.Eventing.Reader;

namespace GUI
{
    public partial class Frm_PhieuDatPhong : Form
    {
        private RoomsBUS roomBus = new RoomsBUS();
        private StatusBUS statusBus = new StatusBUS();
        private ServiceBUS serviceBus = new ServiceBUS();
        private KhachHangBUS khachHangBus = new KhachHangBUS();
        private BookingsBUS bookingsBus = new BookingsBUS();
        private NhanVienBUS nhanVienBus = new NhanVienBUS();
        private Booking_DetailsBUS booking_DetailsBus = new Booking_DetailsBUS();
        private string userName;

        public Frm_PhieuDatPhong(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        private DataRow accounts()
        {
            return nhanVienBus.getDataAllByUserName(this.userName).Rows[0];
        }
        private void printListViewRooms() // Hàm xuất ra trên listView 
        {
            lstView_DanhSachPhong.Items.Clear();
            foreach (DataRow row in roomBus.getDataKhacBaoTri().Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < roomBus.getDataAll().Columns.Count; i++)
                {
                    if (i == 5)
                    {
                        int statusId = Convert.ToInt32(row[i].ToString());
                        DataTable tableStatus = statusBus.getDataById(statusId);
                        foreach (DataRow rowStatus in tableStatus.Rows)
                        {
                            item.SubItems.Add(rowStatus[1].ToString());
                        }
                    }
                    else
                    {
                        item.SubItems.Add(row[i].ToString());
                    }

                }
                lstView_DanhSachPhong.Items.Add(item);
            }
        }
        private void printListViewBookings() // Hàm xuất ra trên listView 
        {
            lstView_Bookings.Items.Clear();
            foreach (DataRow row in bookingsBus.getDataAll().Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < bookingsBus.getDataAll().Columns.Count; i++)
                {
                    if (i == 1)
                    {
                        int customerId = Convert.ToInt32(row[i].ToString());
                        DataTable tableCustomer = khachHangBus.getDataByIdDeleted(customerId);
                        foreach (DataRow rowCustomer in tableCustomer.Rows)
                        {
                            item.SubItems.Add($"{rowCustomer[1].ToString()} {rowCustomer[2].ToString()}");
                        }
                    }
                    else if (i == 4)
                    {
                        int accountId = Convert.ToInt32(row[i].ToString());
                        DataTable tableAccount = nhanVienBus.getDataFullById(accountId);
                        foreach (DataRow rowAccount in tableAccount.Rows)
                        {
                            item.SubItems.Add($"{rowAccount[1].ToString()}");
                        }
                    }
                    else
                    {
                        item.SubItems.Add(row[i].ToString());
                    }

                }
                lstView_Bookings.Items.Add(item);
            }
        }
        private void Frm_PhieuDatPhong_Load(object sender, EventArgs e)
        {
            printListViewRooms();
            printListViewBookings();
        
        }
        private void lstView_DanhSachPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_DanhSachPhong.SelectedItems.Count > 0)
            {
                string listNameRoom = "";
                foreach (ListViewItem item in lstView_DanhSachPhong.SelectedItems)
                {
                    listNameRoom += $"{item.SubItems[1].Text} ";
                    printTotalPriceRoom();

                }
                txt_SoPhong.Text = listNameRoom;
            }
            else
            {
                txt_SoPhong.Text = "";
            }
        }
        private void btn_XemTongTien_Click(object sender, EventArgs e)
        {
            string sdateCheckIn = date_CheckIn.Value.ToString("MM/dd/yyyy"), sdateCheckOut = date_CheckOut.Value.ToString("MM/dd/yyyy");
            DateTime dateCheckIn = DateTime.Parse(sdateCheckIn), dateCheckOut = DateTime.Parse(sdateCheckOut);
            TimeSpan difference = dateCheckOut.Subtract(dateCheckIn);
            // Lấy số ngày dưới dạng số nguyên
            int numberOfDays = (int)difference.TotalDays;
            //select lstView Roooms start
            float totalPriceRooms = 0;
            foreach (ListViewItem item in lstView_DanhSachPhong.SelectedItems)
            {
                totalPriceRooms += float.Parse(item.SubItems[4].Text);
            }
            if (numberOfDays > 0)
            {
                txt_TongTien.Text = (totalPriceRooms * numberOfDays).ToString();
            }
            else
            {
                date_CheckIn.Value = date_CheckOut.Value;
                return;
            }


        }
        private bool checkDate(DateTime date_checkIn, DateTime date_checkOut)
        {
            if (lstView_DanhSachPhong.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lstView_DanhSachPhong.SelectedItems)
                {
                    int idRooms = Convert.ToInt32(item.SubItems[0].Text);
                    if (bookingsBus.checkDate(idRooms, date_checkIn, date_checkOut).Rows.Count > 0)
                    {
                        return false;
                    }

                }

                return true;
            }
            return false;
        }
        private void btn_XacNhanDatPhong_Click(object sender, EventArgs e)
        {
            string hoKhachHang = txt_HoKhachHang.Text;
            string tenKhachHang = txt_TenKhachHang.Text;
            string emailKhachHang = txt_Email.Text;
            string phoneKhachHang = txt_SoDienThoai.Text;
            string diaChiKhachHang = txt_DiaChi.Text;
            string sdateCheckIn = date_CheckIn.Value.ToString("MM/dd/yyyy"), sdateCheckOut = date_CheckOut.Value.ToString("MM/dd/yyyy");
            DateTime dateCheckIn = DateTime.Parse(sdateCheckIn), dateCheckOut = DateTime.Parse(sdateCheckOut);
            TimeSpan difference = dateCheckOut.Subtract(dateCheckIn);
            // Lấy số ngày dưới dạng số nguyên
            int numberOfDays = (int)difference.TotalDays;
            if (numberOfDays < 1)
            {
                MessageBox.Show("Ngày không hợp lệ!!", "Thông báo");
                return;
            }
            if (checkDate(dateCheckIn, dateCheckOut) == false)
            {
                MessageBox.Show("Ngày này đã có khách đặt !!", "Thông báo");
                return;
            }

            if (hoKhachHang != "" && tenKhachHang != "" && emailKhachHang != "" && phoneKhachHang != "" && diaChiKhachHang != "" && txt_TongTien.Text != "")
            {
                float tongTien = float.Parse(txt_TongTien.Text.Replace(" VND", "").Replace(",", ""));
                try
                {
                    int idKhachHang;

                    if (chk_KhachMoi.Checked == false)
                    {
                        idKhachHang = int.Parse(txtMaKH.Text);
                    }
                    else
                    {
                        idKhachHang = khachHangBus.getIdAndInsert(tenKhachHang, hoKhachHang, emailKhachHang, phoneKhachHang, diaChiKhachHang);
                    }

                    int idBookings = bookingsBus.getIdAndInsert(idKhachHang, dateCheckIn, dateCheckOut, int.Parse(accounts()[0].ToString()), tongTien);
                    foreach (ListViewItem item in lstView_DanhSachPhong.SelectedItems)
                    {
                        int idRooms = Convert.ToInt32(item.SubItems[0].Text);
                        float priceRoom = float.Parse(item.SubItems[4].Text.Replace(" VND", "").Replace(",", ""));
                        booking_DetailsBus.insertData(idBookings, idRooms, priceRoom);
                    }
                    MessageBox.Show("Đặt phòng thành công !!");
                    updateStatus();
                    printListViewBookings();

                }
                catch
                {
                    MessageBox.Show("Thêm thất bại !!");

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!");
            }
        }
        private void updateStatus()
        {
            DataTable roomsStatus = roomBus.updateStatus();


            foreach (DataRow row in roomBus.getDataAll().Rows)
            {
                bool coHieu = false;
                foreach (DataRow rowStatus in roomsStatus.Rows)
                {
                    if (row[0].ToString() == rowStatus[0].ToString())
                    {
                        int roomId = Convert.ToInt32(row[0].ToString());
                        float roomPrice = float.Parse(row[4].ToString());
                        roomBus.updateData(roomId, row[1].ToString(), row[2].ToString(), row[3].ToString(), roomPrice, 2);
                        coHieu = true;
                    }
                    //else
                    //{
                    //    int roomId = Convert.ToInt32(row[0].ToString());
                    //    float roomPrice = float.Parse(row[4].ToString());
                    //    roomBus.updateData(roomId, row[1].ToString(), row[2].ToString(), row[3].ToString(), roomPrice, 1);
                    //}
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
                    roomBus.updateData(roomId, row[1].ToString(), row[2].ToString(), row[3].ToString(), roomPrice, 1);
                }
            }
        }
        private void printTotalPriceRoom()
        {
            string sdateCheckIn = date_CheckIn.Value.ToString("MM/dd/yyyy"), sdateCheckOut = date_CheckOut.Value.ToString("MM/dd/yyyy");
            DateTime dateCheckIn = DateTime.Parse(sdateCheckIn), dateCheckOut = DateTime.Parse(sdateCheckOut);
            TimeSpan difference = dateCheckOut.Subtract(dateCheckIn);
            // Lấy số ngày dưới dạng số nguyên
            int numberOfDays = (int)difference.TotalDays;
            //select lstView Roooms start
            float totalPriceRooms = 0;
            foreach (ListViewItem item in lstView_DanhSachPhong.SelectedItems)
            {
                totalPriceRooms += float.Parse(item.SubItems[4].Text);
            }
            if (numberOfDays >= 0)
            {
                txt_TongTien.Text = (totalPriceRooms * numberOfDays).ToString("#,##0.00 VND");
            }
            else
            {

                date_CheckOut.Value = date_CheckIn.Value;
                return;
            }
        }
        private void date_CheckOut_ValueChanged(object sender, EventArgs e)
        {
            printTotalPriceRoom();
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_XacNhanDatPhong_Enter(object sender, EventArgs e)
        {
            btn_XacNhanDatPhong.BorderColor = Color.Red;
            btn_XacNhanDatPhong.BorderThickness = 2;
        }

        private void btn_XacNhanDatPhong_Leave(object sender, EventArgs e)
        {
            btn_XacNhanDatPhong.BorderColor = Color.Transparent;
            btn_XacNhanDatPhong.BorderThickness = 0;
        }

        private void chk_KhachMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_KhachMoi.Checked == true)
            {
                txtMaKH.Text = "";
                grp_ThongTinKhachHang.Enabled = true;
                grp_TimKhachHang.Enabled = false;
                foreach (Control control in grp_ThongTinKhachHang.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Text = "";
                    }
                }

            }
            else
            {
                grp_ThongTinKhachHang.Enabled = false;
                grp_TimKhachHang.Enabled = true;
            }
        }

        private void btn_TimMaKH_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                int maKH = int.Parse(txtMaKH.Text);
                DataTable dt = khachHangBus.getDataById(maKH);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"Mã khách hàng '{maKH}' Không tồn tại");
                }
                else
                {
                    txt_HoKhachHang.Text = dt.Rows[0]["last_name"].ToString();
                    txt_TenKhachHang.Text = dt.Rows[0]["first_name"].ToString();
                    txt_Email.Text = dt.Rows[0]["email"].ToString();
                    txt_SoDienThoai.Text = dt.Rows[0]["phone"].ToString();
                    txt_DiaChi.Text = dt.Rows[0]["address"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng");
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
