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
    public partial class UC_BaoCaoThongKe : UserControl
    {
        public UC_BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void btn_ThongKeDanhThu_Click(object sender, EventArgs e)
        {
            Frm_ThongKeDanhThu item = new Frm_ThongKeDanhThu();
            item.Show();
        }
    }
}
