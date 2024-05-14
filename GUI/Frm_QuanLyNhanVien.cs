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
    public partial class Frm_QuanLyNhanVien : Form
    {
        NhanVienBUS nv = new NhanVienBUS();
        RolesBUS roleBus = new RolesBUS();
        NhanVienDTO nhanVienDTO = new NhanVienDTO();
        private string userName;
        public Frm_QuanLyNhanVien(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void printListView() // Hàm xuất ra trên listView 
        {
            lstView_DanhSachNV.Items.Clear();
            
            foreach (DataRow row in nv.getDataAll().Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < nv.getDataAll().Columns.Count; i++)
                {
                    if (i == 3)
                    {
                        foreach(DataRow rowRole in roleBus.getDataRolesById(int.Parse(row[i].ToString())).Rows){
                            item.SubItems.Add(rowRole[1].ToString());
                        }
                    }else
                        item.SubItems.Add(row[i].ToString());
                }
                lstView_DanhSachNV.Items.Add(item);
            }
        }
        private void Frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            
            cbBox_Roles.DataSource = roleBus.getDataAll();
            cbBox_Roles.DisplayMember = "role_title";
            cbBox_Roles.ValueMember = "role_id";
            cbBox_Roles.SelectedIndex = 0;
            printListView();
        }

        private void btn_ThemAccount_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_TenDangNhap.Text;
            string matKhau = txt_MatKhau.Text;
            int idLoaiTaiKhoan = 0;
            foreach (DataRow row in roleBus.getDataRolesByTitle(cbBox_Roles.Text).Rows)
            {
                idLoaiTaiKhoan = int.Parse(row[0].ToString());
            }

            if (tenDangNhap != "" && matKhau != "" && idLoaiTaiKhoan>0)
            {
                if (nv.insertData(tenDangNhap, matKhau, idLoaiTaiKhoan) != 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công !!", "Thông báo");
                    printListView();

                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại !!", "Thông báo");
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "Thông báo");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_XoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (lstView_DanhSachNV.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá !!", "Thông báo",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    ListViewItem Item = lstView_DanhSachNV.SelectedItems[0];
                    int idKhachHang = Convert.ToInt32(Item.SubItems[0].Text);
                    if (Item.SubItems[1].Text != userName)
                    {
                        nv.deleteDataSoft(idKhachHang);
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        printListView();
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

        private void lstView_DanhSachNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_DanhSachNV.SelectedItems.Count > 0)
            {
                ListViewItem item = lstView_DanhSachNV.SelectedItems[0];
                txt_TenDangNhap.Text = item.SubItems[1].Text;
                txt_MatKhau.Text = item.SubItems[2].Text;
                cbBox_Roles.Text = item.SubItems[3].Text;
                
            }
        }

        private void btn_XoaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiemNhanVien_Click(object sender, EventArgs e)
        {
            string timKiemKhachNV = txt_TimKiemNV.Text;

            DataTable data = new DataTable();
            data = nv.selectLike(timKiemKhachNV);
            if (data.Rows.Count > 0)
            {
                lstView_DanhSachNV.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < nv.getDataAll().Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());

                    }
                    lstView_DanhSachNV.Items.Add(item);
                }
            }
        }

        private void btn_SuaNhanVien_Click(object sender, EventArgs e)
        {
            if (lstView_DanhSachNV.SelectedItems.Count > 0)
            {
                if (txt_TenDangNhap.Text != "" && txt_MatKhau.Text != "" && cbBox_Roles.Text != "")
                {
                    try
                    {
                        if(nv.updateData(int.Parse(lstView_DanhSachNV.SelectedItems[0].SubItems[0].Text), txt_TenDangNhap.Text, txt_MatKhau.Text, int.Parse(cbBox_Roles.SelectedValue.ToString())) != 0)
                        {
                            MessageBox.Show("Sửa thông tin thành công !!");
                            printListView();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin không thành công !!");

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thông tin không thành công !!");

                    }


                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công !!");

                }
            }


        }
    }
}
