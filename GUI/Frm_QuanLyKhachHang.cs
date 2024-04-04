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
    public partial class Frm_QuanLyKhachHang : Form
    {
        private KhachHangBUS khachHangBus = new KhachHangBUS();
        private KhachHangDTO khachHangDto = new KhachHangDTO();
        private BookingsBUS bookingsBus = new BookingsBUS();
        private Service_DetailsBUS service = new Service_DetailsBUS();
        public Frm_QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void printListView() // Hàm xuất ra trên listView 
        {
            lstView_DanhSachKhachHang.Items.Clear();
            foreach (DataRow row in khachHangBus.getDataAll().Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < khachHangBus.getDataAll().Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());

                }
                lstView_DanhSachKhachHang.Items.Add(item);
            }
        }
        private void Frm_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            printListView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txt_TenKhachHang.Text;
            string hoKhachHang = txt_HoKhachHang.Text;
            string diaChi = txt_DiaChi.Text;
            string soDienThoai = txt_SoDienThoai.Text;
            string email = txt_Email.Text;
            if (tenKhachHang != "" && hoKhachHang != "" && diaChi != "" && soDienThoai != "" && email != "")
            {
                if (khachHangBus.insertData(hoKhachHang, tenKhachHang, email, soDienThoai, diaChi) != 0)
                {
                    MessageBox.Show("Đã thêm thành công khách hàng !!!", "Thông báo");
                    printListView();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công khách hàng !!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!", "Thông báo");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_XoaKhachHang_Click(object sender, EventArgs e)
        {
            if (lstView_DanhSachKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem Item = lstView_DanhSachKhachHang.SelectedItems[0];
                int idKhachHang = Convert.ToInt32(Item.SubItems[0].Text);
                if (khachHangBus.deleteDataSoft(idKhachHang) != 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    printListView();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn", "Thông báo");
            }
        }

        private void lstView_DanhSachKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstView_DanhSachKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem item = lstView_DanhSachKhachHang.SelectedItems[0];
                txt_TenKhachHang.Text = item.SubItems[2].Text;
                txt_HoKhachHang.Text = item.SubItems[1].Text;
                txt_DiaChi.Text = item.SubItems[3].Text;
                txt_SoDienThoai.Text = item.SubItems[4].Text;
                txt_Email.Text = item.SubItems[5].Text;

            }
        }

        private void btn_SuaKhachHang_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txt_TenKhachHang.Text;
            string hoKhachHang = txt_HoKhachHang.Text;
            string diaChi = txt_DiaChi.Text;
            string soDienThoai = txt_SoDienThoai.Text;
            string email = txt_Email.Text;
            ListViewItem item = lstView_DanhSachKhachHang.SelectedItems[0];
            int idKhachHang = Convert.ToInt32(item.SubItems[0].Text);
            if (tenKhachHang != "" && hoKhachHang != "" && diaChi != "" && soDienThoai != "" && email != "")
            {
                if (khachHangBus.updateData(idKhachHang, hoKhachHang, tenKhachHang, diaChi, soDienThoai, email) != 0)
                    MessageBox.Show("Update thành công", "Thông báo");
                else
                    MessageBox.Show("Update không thành công", "Thông báo");
                printListView();
                 txt_TenKhachHang.Text="";
                txt_HoKhachHang.Text="";
                txt_DiaChi.Text="";
                txt_SoDienThoai.Text="";
                txt_Email.Text="";
            }
        }

        private void btn_TimKiemKhachHang_Click(object sender, EventArgs e)
        {
            string timKiemKhachKh = txt_TimKiemKh.Text;
      
                DataTable data = new DataTable();
                data = khachHangBus.selectLike(timKiemKhachKh);
                if (data.Rows.Count > 0)
                {
                    lstView_DanhSachKhachHang.Items.Clear();
                    foreach (DataRow row in data.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        for (int i = 1; i < khachHangBus.getDataAll().Columns.Count; i++)
                        {
                            item.SubItems.Add(row[i].ToString());

                        }
                        lstView_DanhSachKhachHang.Items.Add(item);
                    }
                }
        }
    }
}
