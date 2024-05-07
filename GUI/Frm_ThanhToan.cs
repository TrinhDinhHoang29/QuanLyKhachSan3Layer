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
                        DataTable tableCustomer = khachHangBus.getDataById(customerId);
                        foreach (DataRow rowCustomer in tableCustomer.Rows)
                        {
                            item.SubItems.Add($"{rowCustomer[1].ToString()} {rowCustomer[2].ToString()}");
                        }
                    }
                    else if (i == 4)
                    {
                        int accountId = Convert.ToInt32(row[i].ToString());
                        DataTable tableAccount = nhanVienBus.getDataById(accountId);
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
                if(item.SubItems[6].Text=="Cancel")
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
            printListViewBookings();
            printListView();
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
                ListViewItem item = lstView_Bookings.SelectedItems[0];
                int booking_id = int.Parse( item.SubItems[0].Text);
                string status = item.SubItems[6].Text;
                try
                {
                    if (status != "Cancel" && status != "Paid") {
                        bookingsBus.updateStatusById(booking_id, "Cancel");
                        printListViewBookings();
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
    }
}
