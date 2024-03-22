using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class Frm_ThongKeDanhThu : Form
    {
        public Frm_ThongKeDanhThu()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ThongKeDanhThu_Load(object sender, EventArgs e)
        {
            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Title = "Doanh thu";
        }
    }
}
