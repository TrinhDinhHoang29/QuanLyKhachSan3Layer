using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BLL;
namespace GUI
{
    public partial class Frm_Roles : Form
    {
        RolesBUS rolesBus = new RolesBUS();



        List<String> listOn = new List<string>();
        List<String> listOff = new List<string>();
        public Frm_Roles()
        {
            InitializeComponent();
        }

        private void Frm_Roles_Load(object sender, EventArgs e)
        {
            printListView();
        }
        private void printListView() // Hàm xuất ra trên listView 
        {
            lstView_DanhSachRole.Items.Clear();
            foreach (DataRow row in rolesBus.getDataAll().Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());

                for (int i = 1; i < rolesBus.getDataAll().Columns.Count; i++)
                {
                  
                        item.SubItems.Add(row[i].ToString());

                }
                lstView_DanhSachRole.Items.Add(item);
            }
        }

        private void btn_ThemTT_Click(object sender, EventArgs e)
        {
            string tenVaiTro = txt_TenVaiTro.Text;
            string moTaVaiTro = txt_MoTaVaiTro.Text;
            if (tenVaiTro != "" && moTaVaiTro != "")
            {
                if(rolesBus.InsertData(tenVaiTro, moTaVaiTro) == 1)
                {
                    MessageBox.Show("Thêm thành công !!", "Thông báo");
                    printListView();

                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !!", "Thông báo");
            }
        }
        private void resetChecked()
        {
            chkBox_Accounts_Permission.Checked = false;
            chkBox_Customers_Permission.Checked = false;
            chkBox_Management_Permission.Checked = false;
            chkBox_Rooms_Permission.Checked = false;
            chkBox_Services_Permission.Checked = false;
        }
        private void lstView_DanhSachRole_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            if (lstView_DanhSachRole.SelectedItems.Count > 0)
            {
                resetChecked();
                ListViewItem item = lstView_DanhSachRole.SelectedItems[0];
                txt_TenVaiTro.Text = item.SubItems[1].Text;
                txt_MoTaVaiTro.Text = item.SubItems[2].Text;
                int id = int.Parse(item.SubItems[0].Text);      
                
                foreach(DataRow row in rolesBus.GetDataTableRoleDetailsById(id).Rows)
                {
                    if (row[3].ToString()== "Accounts permission")
                    {
                        chkBox_Accounts_Permission.Checked = true;
                    }else if (row[3].ToString() == "Customers permission")
                    {
                        chkBox_Customers_Permission.Checked = true;
                    }else if (row[3].ToString() == "Services permission")
                    {
                        chkBox_Services_Permission.Checked = true;
                    }else if (row[3].ToString() == "Rooms permission")
                    {
                        chkBox_Rooms_Permission.Checked = true;
                    }else if (row[3].ToString() == "Management permission")
                    {
                        chkBox_Management_Permission.Checked = true;
                    }

                }
                listOff.Clear();
                listOn.Clear();
            }
        }
      
        private void btn_SuaTT_Click(object sender, EventArgs e)
        {

            if (lstView_DanhSachRole.SelectedItems.Count > 0)
            {
                string tenVaiTro = txt_TenVaiTro.Text;
                string moTaVaiTro = txt_MoTaVaiTro.Text;
                if (tenVaiTro.Trim() != "" && moTaVaiTro.Trim() != "")
                {

                    ListViewItem item = lstView_DanhSachRole.SelectedItems[0];
                    int id = int.Parse(item.SubItems[0].Text);
                    string idCustomersPermission = rolesBus.GetDataTablePermissionByTitle("Customers permission").Rows[0][0].ToString();
                    string idRoomsPermission = rolesBus.GetDataTablePermissionByTitle("Rooms permission").Rows[0][0].ToString();
                    string idServicesPermission = rolesBus.GetDataTablePermissionByTitle("Services permission").Rows[0][0].ToString();
                    string idManagementPermission = rolesBus.GetDataTablePermissionByTitle("Management permission").Rows[0][0].ToString();
                    foreach (string on in listOn)
                    {
                        if (rolesBus.checkPermission(id, on))
                            continue;
                        else
                        {
                            string idPermission = rolesBus.GetDataTablePermissionByTitle(on).Rows[0][0].ToString();
                            rolesBus.InsertdataRolesDetails(id, int.Parse(idPermission));
                        }
                    }
                    foreach (string off in listOff)
                    {
                        if (rolesBus.checkPermission(id, off))
                        {
                            string idPermission = rolesBus.GetDataTablePermissionByTitle(off).Rows[0][0].ToString();
                            rolesBus.deleteDataRolesDetails(id, int.Parse(idPermission));
                        }
                        else
                            continue;
                    }
                    rolesBus.updateData(id,tenVaiTro,moTaVaiTro);
                    MessageBox.Show("Sửa quyền thành công !!", "Thông báo");
                }
               

            }

        }

        private void chkBox_Accounts_Permission_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            string name = chk.Text;
            if (chk.Checked)
            {
                if(listOff.Count>0 && listOff.FindIndex(perName => perName.Equals(name)) != -1 )
                {
                    listOff.RemoveAt(listOff.FindIndex(perName => perName.Equals(name)));
                    
                }
                listOn.Add(name);

            }
            else
            {
                if (listOn.Count > 0 && listOn.FindIndex(perName => perName.Equals(name)) != -1)
                {
                    listOn.RemoveAt(listOn.FindIndex(perName => perName.Equals(name)));

                }
                listOff.Add(name);
            }
        }

        private void btn_XoaTT_Click(object sender, EventArgs e)
        {
            if (lstView_DanhSachRole.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chất muốn xoá !!", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    ListViewItem item = lstView_DanhSachRole.SelectedItems[0];
                    rolesBus.deleteSoftRole(int.Parse(item.SubItems[0].Text));
                    printListView();
                    MessageBox.Show("Xóa thành công !!", "Thông báo");
                }
                
            }
        }
    }
}
