﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AllUserControls
{
    public partial class UC_DanhMucQuanLy : UserControl
    {
        public UC_DanhMucQuanLy()
        {
            InitializeComponent();
        }


        private void btn_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            Frm_QuanLyKhachHang item = new Frm_QuanLyKhachHang();
            item.Show();
            
        }
    }
}
