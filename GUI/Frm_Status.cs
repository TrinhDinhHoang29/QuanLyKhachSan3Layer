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
    public partial class Frm_Status : Form
    {
        private StatusBUS statusBus = new StatusBUS();

        public Frm_Status()
        {
            InitializeComponent();
        }

        private void Frm_Status_Load(object sender, EventArgs e)
        {
            printListView();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void printListView() // Hàm xuất ra trên listView 
        {
            lstView_DanhSachTrangThai.Items.Clear();
            foreach (DataRow row in statusBus.getDataAll().Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < statusBus.getDataAll().Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());

                }
                lstView_DanhSachTrangThai.Items.Add(item);
            }
        }
        private void btn_ThemTT_Click(object sender, EventArgs e)
        {
            string tenTrangThai = txt_TenTrangThai.Text;
            string moTaTrangThai = txt_MoTaTrangThai.Text;
            if (tenTrangThai!=""&&moTaTrangThai!="")
            {
                try {
                    statusBus.insertData(tenTrangThai, moTaTrangThai);
                    MessageBox.Show("Đã thêm thành công !!!", "Thông báo");
                    txt_TenTrangThai.Text = "";
                    txt_MoTaTrangThai.Text = "";
                    printListView();
                }
                catch {
                    MessageBox.Show("Thêm không thành công !!!", "Thông báo");

                }
            
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!", "Thông báo");
            }

        }

        private void btn_SuaTT_Click(object sender, EventArgs e)
        {
            string tenTrangThai = txt_TenTrangThai.Text;
            string moTaTrangThai = txt_MoTaTrangThai.Text;
            try
            {
                ListViewItem item = lstView_DanhSachTrangThai.SelectedItems[0];
                int idRoom = Convert.ToInt32(item.SubItems[0].Text);
                if (tenTrangThai != "" && moTaTrangThai != "")
                {
                    if (statusBus.updateData(idRoom, tenTrangThai, moTaTrangThai) != 0)
                        MessageBox.Show("Update thành công", "Thông báo");
                    else
                        MessageBox.Show("Update không thành công", "Thông báo");
                    printListView();
                    txt_TenTrangThai.Text = "";
                    txt_MoTaTrangThai.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Update không thành công", "Thông báo");

            }
        }

        private void btn_XoaTT_Click(object sender, EventArgs e)
        {
            if (lstView_DanhSachTrangThai.SelectedItems.Count > 0)
            {
                ListViewItem Item = lstView_DanhSachTrangThai.SelectedItems[0];
                int idPhong = Convert.ToInt32(Item.SubItems[0].Text);
                if (statusBus.deleteDataSoft(idPhong) != 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    printListView();
                    txt_TenTrangThai.Text = "";
                    txt_MoTaTrangThai.Text = "";
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

        private void lstView_DanhSachTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_DanhSachTrangThai.SelectedItems.Count > 0)
            {
                ListViewItem item = lstView_DanhSachTrangThai.SelectedItems[0];
                txt_TenTrangThai.Text = item.SubItems[1].Text;
                txt_MoTaTrangThai.Text = item.SubItems[2].Text;
            }
        }

        private void btn_TimKiemTrangThai_Click(object sender, EventArgs e)
        {
            string timKiemTrangThai = txt_TimKiemTrangThai.Text;

            DataTable data = new DataTable();
            data = statusBus.selectLike(timKiemTrangThai);
            if (data.Rows.Count > 0)
            {
                lstView_DanhSachTrangThai.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < statusBus.getDataAll().Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());

                    }
                    lstView_DanhSachTrangThai.Items.Add(item);
                }
            }
        }
    }
}
