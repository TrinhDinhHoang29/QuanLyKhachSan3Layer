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
    public partial class Frm_QuanLyTienIch : Form
    {
        ServiceBUS serviceBus = new ServiceBUS();
        public Frm_QuanLyTienIch()
        {
            InitializeComponent();
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
        private void Frm_QuanLyTienIch_Load(object sender, EventArgs e)
        {
            printListView();
        }

        private void btn_ThemDichVu_Click(object sender, EventArgs e)
        {
            string tenDichVu = txt_TenDichVu.Text;
            float giaDichVu = float.Parse(txt_GiaDichVu.Text);
        
            if (tenDichVu != "")
            {
                if (serviceBus.insertData(tenDichVu, giaDichVu) != 0)
                {
                    MessageBox.Show("Đã thêm thành công dịch vụ !!!", "Thông báo");
                    txt_TenDichVu.Text = "";
                    txt_GiaDichVu.Text = "";
                    printListView();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công dịch vụ !!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!", "Thông báo");
            }
        }

        private void btn_XoaDichVu_Click(object sender, EventArgs e)
        {
            if (lstView_DanhSachDichVu.SelectedItems.Count > 0)
            {
                ListViewItem Item = lstView_DanhSachDichVu.SelectedItems[0];
                int idPhong = Convert.ToInt32(Item.SubItems[0].Text);
                if (serviceBus.deleteDataSoft(idPhong) != 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    printListView();
                    txt_TenDichVu.Text = "";
                    txt_GiaDichVu.Text = "";
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

        private void btn_SuaDichVu_Click(object sender, EventArgs e)
        {
            string tenDichVu = txt_TenDichVu.Text;
            float giaDichVu = float.Parse(txt_GiaDichVu.Text);
            ListViewItem item = lstView_DanhSachDichVu.SelectedItems[0];
            int idService = Convert.ToInt32(item.SubItems[0].Text);
            if (tenDichVu != "")
            {
                if (serviceBus.updateData(idService, tenDichVu, giaDichVu) != 0)
                    MessageBox.Show("Update thành công", "Thông báo");
                else
                    MessageBox.Show("Update không thành công", "Thông báo");
                printListView();
                txt_TenDichVu.Text = "";
                txt_GiaDichVu.Text = "";

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

        private void btn_TimKiemDichVu_Click(object sender, EventArgs e)
        {
            string timKiemDV = txt_TimKiemDV.Text;

            DataTable data = new DataTable();
            data = serviceBus.selectLike(timKiemDV);
            if (data.Rows.Count > 0)
            {
                lstView_DanhSachDichVu.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < serviceBus.getDataAll().Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());

                    }
                    lstView_DanhSachDichVu.Items.Add(item);
                }
            }
        }
    }
}
