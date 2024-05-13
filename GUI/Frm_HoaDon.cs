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
using BLL;
namespace GUI
{
    public partial class Frm_HoaDon : Form
    {
        Booking_DetailsBUS bookingDetailsBus = new Booking_DetailsBUS();
        BookingsBUS bookingsBus = new BookingsBUS();
        private Service_DetailsBUS serviceDetailBus = new Service_DetailsBUS();
        private NhanVienBUS nhanVienBus = new NhanVienBUS();
        private KhachHangBUS khachHangBus = new KhachHangBUS();
        private string maHoaDon;
        private bool checkPaid=false;
        public Frm_HoaDon(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            print();
        }
        private void print1()
        {
            DataRow bookingsRow = bookingsBus.getDataById(int.Parse(maHoaDon)).Rows[0];
            string ngayO = $"{bookingsRow[2].ToString()} - {bookingsRow[3].ToString()}";
            lb_NgayO.Text = ngayO;

            lb_TenNhanVien.Text = nhanVienBus.getDataFullById(int.Parse(bookingsRow[4].ToString())).Rows[0][1].ToString();
            DataTable khachHang = khachHangBus.getDataByIdDeleted(int.Parse(bookingsRow[1].ToString()));
            lb_TenKhachHang.Text = khachHang.Rows[0][1].ToString()+" "+khachHang.Rows[0][2].ToString();
            if (bookingsRow[6].ToString() == "Paid")
                this.checkPaid = true;


        }
        private void print()
        {
            print1();
            if (checkPaid == true)
            {
                txt_quantity.Visible = false;
                btn_Sua.Visible = false;
                btn_XacNhan.Visible = false;
            }
            else
            {
                lb_mes.Visible = false;
            }
            lstView_DanhSachBooking.Items.Clear();
            lstView_TienIch.Items.Clear();
            lb_SoHoaDon.Text = maHoaDon;
            string tongTienPhong = "0";
            foreach (DataRow rowBookingDetail in bookingDetailsBus.getDataByBookingId(int.Parse(maHoaDon)).Rows)
            {
                ListViewItem item = new ListViewItem(rowBookingDetail[5].ToString());
                item.SubItems.Add(rowBookingDetail[6].ToString());
                item.SubItems.Add(rowBookingDetail[7].ToString());
                item.SubItems.Add(rowBookingDetail[8].ToString());
                lstView_DanhSachBooking.Items.Add(item);
                tongTienPhong = rowBookingDetail[3].ToString();

            }
            lb_TongTienPhong.Text = float.Parse(tongTienPhong).ToString("#,##0.00 VND");
            float tongTienDichVu = 0;
            foreach (DataRow rowServiceDetail in serviceDetailBus.getDataByBookingId(int.Parse(maHoaDon)).Rows)
            {
                ListViewItem item = new ListViewItem(rowServiceDetail[5].ToString());
                item.SubItems.Add(rowServiceDetail[3].ToString());
                item.SubItems.Add(rowServiceDetail[6].ToString());
                float thanhTienDV = float.Parse(rowServiceDetail[6].ToString()) * float.Parse(rowServiceDetail[3].ToString());
                tongTienDichVu += thanhTienDV;
                item.SubItems.Add(thanhTienDV.ToString("#,##0.00 VND"));
                item.SubItems.Add(rowServiceDetail[2].ToString());

                lstView_TienIch.Items.Add(item);
            }
            lb_TongTienTienIch.Text = tongTienDichVu.ToString("#,##0.00 VND");
            lb_TongTien.Text = (float.Parse(tongTienPhong) + tongTienDichVu).ToString("#,##0.00 VND");
        }

        private void lstView_DanhSachBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lstView_TienIch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_TienIch.SelectedItems.Count > 0)
            {
                ListViewItem item = lstView_TienIch.SelectedItems[0];
                txt_quantity.Text = item.SubItems[1].Text;
            }
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lstView_TienIch.SelectedItems.Count > 0&&txt_quantity.Text!="")
            {
                ListViewItem item = lstView_TienIch.SelectedItems[0];
                int soLuong = int.Parse(txt_quantity.Text);
                int maTienIch = int.Parse(item.SubItems[4].Text);
                bookingDetailsBus.updateQuantity(int.Parse(maHoaDon), maTienIch, soLuong);
                MessageBox.Show("Update thành công !!", "Thông báo");
                print();
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            bookingsBus.updateStatusById(int.Parse(maHoaDon), "Paid");
            MessageBox.Show("Thanh toán thành công !!", "Thông báo");
            this.Close();


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
