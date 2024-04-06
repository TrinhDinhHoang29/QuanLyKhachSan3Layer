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

namespace GUI
{
    public partial class Frm_QuanLyPhong : Form
    {
        private RoomsBUS roomBus = new RoomsBUS();
        public Frm_QuanLyPhong()
        {
            InitializeComponent();
        }
        private void printListView() // Hàm xuất ra trên listView 
        {
            lstView_DanhSachPhong.Items.Clear();
            foreach (DataRow row in roomBus.getDataAll().Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < roomBus.getDataAll().Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());

                }
                lstView_DanhSachPhong.Items.Add(item);
            }
        }

        private void Frm_QuanLyPhong_Load(object sender, EventArgs e)
        {
            printListView();
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            string soPhong = txt_SoPhong.Text;
            string kieuPhong = cbBox_KieuPhong.Text;
            string kieuGiuong = cbBox_KieuGiuong.Text;
            float gia = float.Parse(txt_Gia.Text);
            if(soPhong != "" && kieuGiuong != "" && kieuGiuong != "" && gia != 0)
            {
                if (roomBus.insertData(soPhong, kieuPhong, kieuGiuong, gia) != 0)
                {
                    MessageBox.Show("Đã thêm thành công khách hàng !!!", "Thông báo");
                    txt_SoPhong.Text = "";
                    txt_Gia.Text = "";
                    cbBox_KieuGiuong.Text = "";
                    cbBox_KieuPhong.Text = "";
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

        private void btn_XoaPhong_Click(object sender, EventArgs e)
        {
            if (lstView_DanhSachPhong.SelectedItems.Count > 0)
            {
                ListViewItem Item = lstView_DanhSachPhong.SelectedItems[0];
                int idPhong = Convert.ToInt32(Item.SubItems[0].Text);
                if (roomBus.deleteDataSoft(idPhong) != 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    printListView();
                    txt_SoPhong.Text = "";
                    txt_Gia.Text = "";
                    cbBox_KieuGiuong.Text = "";
                    cbBox_KieuPhong.Text = "";
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




        private void btn_SuaPhong_Click(object sender, EventArgs e)
        {
            string soPhong = txt_SoPhong.Text;
            string kieuPhong = cbBox_KieuPhong.Text;
            string kieuGiuong = cbBox_KieuGiuong.Text;
            float gia = float.Parse(txt_Gia.Text);
            ListViewItem item = lstView_DanhSachPhong.SelectedItems[0];
            int idRoom = Convert.ToInt32(item.SubItems[0].Text);
            if (soPhong != "" && kieuPhong != "" && kieuGiuong != "" && gia != 0)
            {
                if (roomBus.updateData(idRoom, soPhong, kieuPhong, kieuGiuong, gia) != 0)
                    MessageBox.Show("Update thành công", "Thông báo");
                else
                    MessageBox.Show("Update không thành công", "Thông báo");
                printListView();
                txt_SoPhong.Text = "";
                txt_Gia.Text = "";
                cbBox_KieuGiuong.Text = "";
                cbBox_KieuPhong.Text = "";
            }
        }

        private void lstView_DanhSachPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_DanhSachPhong.SelectedItems.Count > 0)
            {
                ListViewItem item = lstView_DanhSachPhong.SelectedItems[0];
                txt_SoPhong.Text = item.SubItems[1].Text;
                cbBox_KieuPhong.Text = item.SubItems[2].Text;
                cbBox_KieuGiuong.Text = item.SubItems[3].Text;
                txt_Gia.Text = item.SubItems[4].Text;

            }
        }

        private void btn_TimKiemRooms_Click(object sender, EventArgs e)
        {
            string timKiemRooms = txt_TimKiemRooms.Text;

            DataTable data = new DataTable();
            data = roomBus.selectLike(timKiemRooms);
            if (data.Rows.Count > 0)
            {
                lstView_DanhSachPhong.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < roomBus.getDataAll().Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());

                    }
                    lstView_DanhSachPhong.Items.Add(item);
                }
            }
        }
    }
}
