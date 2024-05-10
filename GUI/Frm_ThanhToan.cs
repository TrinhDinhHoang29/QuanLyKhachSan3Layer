using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class Frm_ThanhToan : Form
    {
        private RoomsBUS roomBus = new RoomsBUS();
        private StatusBUS statusBus = new StatusBUS();
        private ServiceBUS serviceBus = new ServiceBUS();
        private KhachHangBUS khachHangBus = new KhachHangBUS();
        private BookingsBUS bookingsBus = new BookingsBUS();
        private NhanVienBUS nhanVienBus = new NhanVienBUS();
        private Service_DetailsBUS serviceDetailBus = new Service_DetailsBUS();
        private Booking_DetailsBUS booking_DetailsBus = new Booking_DetailsBUS();
        public Frm_ThanhToan()
        {
            InitializeComponent();
        }
       
        private void printListViewBookings(DataTable bookings) // Hàm xuất ra trên listView 
        {
            lstView_Bookings.Items.Clear();
            foreach (DataRow row in bookings.Rows)
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
                if (item.SubItems[6].Text == "Cancel")
                    lstView_Bookings.Items.Add(item).BackColor = Color.Gray;
                else if (item.SubItems[6].Text == "Unpaid")
                    lstView_Bookings.Items.Add(item).BackColor = Color.DarkRed;
                else
                    lstView_Bookings.Items.Add(item).BackColor = Color.Green;

            }
        }

        private void printListView() // Hàm xuất ra trên listView 
        {
            lstView_DanhSachDichVu.Items.Clear();
            foreach (DataRow row in serviceBus.getDataAll().Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < serviceBus.getDataAll().Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());

                }
                lstView_DanhSachDichVu.Items.Add(item);
            }
        }

        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            cbBox_DonViLoc.Text = "Tất cả";
            printListViewBookings(bookingsBus.getDataAll());
            printListView();
            printListViewRooms();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstView_Bookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_Bookings.SelectedItems.Count > 0)
            {
                ListViewItem item = lstView_Bookings.SelectedItems[0];
                txt_HoKhachHang.Text = item.SubItems[1].Text;
                date_CheckIn.Value = DateTime.Parse(item.SubItems[2].Text);
                date_CheckOut.Value = DateTime.Parse(item.SubItems[3].Text);
                txt_booking_status.Text = item.SubItems[6].Text;
                dateTime_checkInChuyenPhong.Value = DateTime.Parse(item.SubItems[2].Text);
                dateTime_checkOutChuyenPhong.Value = DateTime.Parse(item.SubItems[3].Text);
                txt_TenKHChuyenPhong.Text = item.SubItems[1].Text;
                txt_TrangThaiChuyenPhong.Text = item.SubItems[6].Text;
                DataTable data = booking_DetailsBus.getDataAllByBookingId(int.Parse(item.SubItems[0].Text));
                data.Columns.Add("combined_id_price", typeof(string));

                cbo_ListRoom.DisplayMember = "room_number";
                foreach (DataRow row in data.Rows)
                {
                    row["combined_id_price"] = row["room_id"] + "-" + row["price"];
                }
                cbo_ListRoom.DataSource = data;
                cbo_ListRoom.ValueMember = "combined_id_price";
            }
        }

        private void lstView_DanhSachDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_DanhSachDichVu.SelectedItems.Count > 0)
            {
                ListViewItem item = lstView_DanhSachDichVu.SelectedItems[0];
                txt_TenDichVu.Text = item.SubItems[1].Text;
                txt_GiaDichVu.Text = item.SubItems[2].Text;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (lstView_Bookings.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Nhấn yes để xoá hoá đơn !!","Thông báo",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    ListViewItem item = lstView_Bookings.SelectedItems[0];
                    int booking_id = int.Parse(item.SubItems[0].Text);
                    string status = item.SubItems[6].Text;
                    try
                    {
                        if (status != "Cancel" && status != "Paid")
                        {
                            bookingsBus.updateStatusById(booking_id, "Cancel");
                            printListViewBookings(bookingsBus.getDataAll());
                            MessageBox.Show("Hủy hóa đơn thành công", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Hủy hóa đơn thất bại", "Thông báo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Hủy hóa đơn thất bại", "Thông báo");
                    }


                }
              
                
            }
        }

        private void btn_ThemDichVu_Click(object sender, EventArgs e)
        {
            if (lstView_Bookings.SelectedItems.Count > 0 && lstView_DanhSachDichVu.SelectedItems.Count > 0)
            {
                ListViewItem itemBooking = lstView_Bookings.SelectedItems[0];
                int booking_id = int.Parse(itemBooking.SubItems[0].Text);
                ListViewItem itemService = lstView_DanhSachDichVu.SelectedItems[0];
                int service_id = int.Parse(itemService.SubItems[0].Text);
                if (txt_Quantity.Text != "")
                {
                    int soLuong = int.Parse(txt_Quantity.Text);
                    if (soLuong > 0)
                    {
                        string status = itemBooking.SubItems[6].Text;
                        try
                        {
                            if (status != "Paid" && status != "Cancel")
                            {
                                serviceDetailBus.insertData(booking_id, service_id, soLuong);
                                MessageBox.Show("Thêm dịch vụ thành công ", "Thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo");

                            }

                        }
                        catch
                        {
                            MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo");

                    }


                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo");

                }
            }
        }
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (lstView_Bookings.SelectedItems.Count > 0)
            {
                ListViewItem itemBooking = lstView_Bookings.SelectedItems[0];
                if (itemBooking.SubItems[6].Text != "Cancel")
                {
                    string maHoaDon = itemBooking.SubItems[0].Text;             
                    Form bill = new Frm_HoaDon(maHoaDon);
                    bill.Show();
                }
                else
                {
                    MessageBox.Show("Hóa đơn đã bị hủy!!", "Thông báo");
                }
            }
        }

        private void txt_Quantity_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chk_LocTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_LocTheoTen.Checked == true)
            {
                txt_LocTheoTen.Enabled = true;
            }
            else
            {
                txt_LocTheoTen.Enabled = false;

            }
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
        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (cbBox_DonViLoc.Text == "Tất cả"&& chk_LocTheoTen.Checked == false)
            {
                printListViewBookings(bookingsBus.getDataAll());
            }
            else if (chk_LocTheoTen.Checked == true && cbBox_DonViLoc.Text == "Tất cả") 
            {
                printListViewBookings(bookingsBus.getBookingsByFullNameCustomer(txt_LocTheoTen.Text));
            }else if (cbBox_DonViLoc.Text == "Khách đang ở" && chk_LocTheoTen.Checked == false)
            {
                printListViewBookings(bookingsBus.getBookingsCurrentDate());

            }
            else if(cbBox_DonViLoc.Text == "Khách đang ở" && chk_LocTheoTen.Checked == true)
            {
                printListViewBookings(bookingsBus.getBookingsCurrentDateByFullNameCustomer(txt_LocTheoTen.Text));
            }else if (cbBox_DonViLoc.Text == "Chưa thanh toán" && chk_LocTheoTen.Checked == false)
            {
                printListViewBookings(bookingsBus.getBookingsByStatus("Unpaid"));

            }
            else if (cbBox_DonViLoc.Text == "Chưa thanh toán" && chk_LocTheoTen.Checked == true)
            {
                printListViewBookings(bookingsBus.getBookingsByStatusAndFullName("Unpaid",txt_LocTheoTen.Text));
            }
            else if (cbBox_DonViLoc.Text == "Đã thanh toán" && chk_LocTheoTen.Checked == false)
            {
                printListViewBookings(bookingsBus.getBookingsByStatus("Paid"));
            }
            else if (cbBox_DonViLoc.Text == "Đã thanh toán" && chk_LocTheoTen.Checked == true)
            {
                printListViewBookings(bookingsBus.getBookingsByStatusAndFullName("Paid", txt_LocTheoTen.Text));
            }
            else if (cbBox_DonViLoc.Text == "Đã đặt trước" && chk_LocTheoTen.Checked == false)
            {
                printListViewBookings(bookingsBus.getBookingsAfterCheckin());

            }
            else if (cbBox_DonViLoc.Text == "Đã đặt trước" && chk_LocTheoTen.Checked == true)
            {
                printListViewBookings(bookingsBus.getBookingsAfterCheckinByFullName(txt_LocTheoTen.Text));

            }


        }

        private void lstView_DanhSachPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_DanhSachPhong.SelectedItems.Count > 0)
            {
                txt_PhongMuonChuyen.Text = lstView_DanhSachPhong.SelectedItems[0].SubItems[1].Text;
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

        private void btn_ChuyenPhong_Click(object sender, EventArgs e)
        {
            if (checkDate(dateTime_checkInChuyenPhong.Value, dateTime_checkOutChuyenPhong.Value) == true)
            {
                if (lstView_Bookings.SelectedItems.Count > 0)
                {
                    try
                    {
                        int idRoomChange = int.Parse(lstView_DanhSachPhong.SelectedItems[0].SubItems[0].Text);
                        int idRoomCurrent = int.Parse(cbo_ListRoom.SelectedValue.ToString().Split('-')[0].ToString());
                        string sdateCheckIn = dateTime_checkInChuyenPhong.Value.ToString("MM/dd/yyyy"), sdateCheckOut = dateTime_checkOutChuyenPhong.Value.ToString("MM/dd/yyyy");
                        DateTime dateCheckIn = DateTime.Parse(sdateCheckIn), dateCheckOut = DateTime.Parse(sdateCheckOut);
                        TimeSpan difference = dateCheckOut.Subtract(dateCheckIn);
                        int numberOfDays = (int)difference.TotalDays;
                        float priceNew = numberOfDays * float.Parse(lstView_DanhSachPhong.SelectedItems[0].SubItems[4].Text);
                        float price = float.Parse(lstView_DanhSachPhong.SelectedItems[0].SubItems[4].Text);
                        float priceOld = float.Parse(cbo_ListRoom.SelectedValue.ToString().Split('-')[1].ToString()) * numberOfDays;
                        booking_DetailsBus.changeRoomByIdBookingAndRoomId(int.Parse(lstView_Bookings.SelectedItems[0].SubItems[0].Text), idRoomCurrent, idRoomChange,price,priceOld,priceNew);
                        MessageBox.Show("Đổi phòng thành công !!", "Thông báo");
                        printListViewBookings(bookingsBus.getDataAll());
                        printListViewRooms();
                    }
                    catch
                    {
                        MessageBox.Show("Đổi phòng không thành công !!", "Thông báo");

                    }

                }
                
            }
            else
            {
                MessageBox.Show("Phòng này đã có khách !!");
            }
           
        }
    }
}
