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
        private StatusBUS statusBus = new StatusBUS();
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
                    if (i ==5)
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

        private void Frm_QuanLyPhong_Load(object sender, EventArgs e)
        {
            printListView();
            printCBBoxStatus();
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            string soPhong = txt_SoPhong.Text;
            string kieuPhong = cbBox_KieuPhong.Text;
            string kieuGiuong = cbBox_KieuGiuong.Text;
            string gia = txt_Gia.Text;
            string trangThai = cbBox_TrangThai.Text;
            int statusId = statusBus.findIdByTitle(trangThai);
            if (soPhong != "" && kieuGiuong != "" && kieuGiuong != "" && gia != "")
            {
                if (statusId != 2)
                {
                    if (roomBus.insertData(soPhong, kieuPhong, kieuGiuong, float.Parse(gia), statusId) != 0)
                        MessageBox.Show("Đã thêm thành công  !!!", "Thông báo");
                    else
                        MessageBox.Show("Thêm không thành công  !!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công  !!!", "Thông báo");

                }

                    txt_SoPhong.Text = "";
                    txt_Gia.Text = "";
                    cbBox_KieuGiuong.Text = "";
                    cbBox_KieuPhong.Text = "";
                    printListView();
                
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

                DialogResult result = MessageBox.Show("Bạn có chất muốn xoá ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
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
            string gia = txt_Gia.Text;
            string trangThai = cbBox_TrangThai.Text;
            int statusId = statusBus.findIdByTitle(trangThai);
            try
            {
                ListViewItem item = lstView_DanhSachPhong.SelectedItems[0];
                int idRoom = Convert.ToInt32(item.SubItems[0].Text);
                if (soPhong != "" && kieuPhong != "" && kieuGiuong != "" && gia != "")
                {
                    if (roomBus.updateData(idRoom, soPhong, kieuPhong, kieuGiuong, float.Parse(gia),statusId) != 0)
                        MessageBox.Show("Update thành công", "Thông báo");
                    else
                        MessageBox.Show("Update không thành công !", "Thông báo");
                    printListView();
                    txt_SoPhong.Text = "";
                    txt_Gia.Text = "";
                    cbBox_KieuGiuong.Text = "";
                    cbBox_KieuPhong.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Update không thành công", "Thông báo");

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
                cbBox_TrangThai.Text = item.SubItems[5].Text;
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

        private void printCBBoxStatus()
        {
            foreach (DataRow row in statusBus.getDataAll().Rows)
            {
             
                cbBox_TrangThai.Items.Add(row[1].ToString());
            }
        }

        private void txt_Gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
