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
using BLL;

namespace GUI
{
    public partial class Frm_ThongKePhong : Form
    {
        private RoomsBUS roomBus = new RoomsBUS();
        int totalRoomCount = 0;
        public Frm_ThongKePhong()
        {
            InitializeComponent();
        }

        private void Frm_ThongKePhong_Load(object sender, EventArgs e)
        {
            loadChartTKTrangThaiPhong();
            loadChartTKDanhSachPhong();
        }
        private void loadChartTKTrangThaiPhong()
        {
            Chart chart = new Chart();
            chart.MouseMove += chart_MouseMove;
            chart.Size = new System.Drawing.Size(400, 300);
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add(new ChartArea());
            DataTable dt = roomBus.GetNumberOfRoomsOfEachRoomStatus();
            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            // Thêm dữ liệu từ DataTable vào Series
            Legend legend = new Legend();
            legend.Docking = Docking.Right;
            chart.Legends.Add(legend);
            Legend totalLegend = new Legend();
            totalLegend.Docking = Docking.Bottom;
            chart.Legends.Add(totalLegend);
            foreach (DataRow row in dt.Rows)
            {
                int roomCount = Convert.ToInt32(row["RoomCount"]);
                totalRoomCount += roomCount;
                DataPoint point = series.Points.Add(roomCount);
                point.LegendText = row["StatusTitle"].ToString();
                point.Label = row["RoomCount"].ToString();
            }
            totalLegend.CustomItems.Add(Color.Gray, "Tổng số phòng: " + totalRoomCount);
            // Thêm Series vào biểu đồ
            chart.Series.Add(series);
            tabPage_TKTheoTrangThai.Controls.Add(chart);
        }
        private void loadChartTKDanhSachPhong()
        {
            // Tạo biểu đồ
            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(400, 300);
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add(new ChartArea());

            // Gọi stored procedure để lấy dữ liệu
            DataTable dt = roomBus.GetRoomTypeBedTypeCounts();

            // Tạo Series cho biểu đồ
            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            Legend legend = new Legend();
            legend.Docking = Docking.Right;
            chart.Legends.Add(legend);
            Legend totalLegend = new Legend();
            totalLegend.Docking = Docking.Bottom;
            chart.Legends.Add(totalLegend);

            // Thêm dữ liệu từ DataTable vào Series
            foreach (DataRow row in dt.Rows)
            {
                int roomCount = Convert.ToInt32(row["total_count"]);
                DataPoint point = series.Points.Add(roomCount);
                point.LegendText = row["room_bed_type"].ToString();
                point.Label = roomCount.ToString();
            }
            totalLegend.CustomItems.Add(Color.Gray, "Tổng số phòng: " + totalRoomCount);

            // Thêm Series vào biểu đồ
            chart.Series.Add(series);

            // Thêm sự kiện MouseMove cho biểu đồ
            chart.MouseMove += chart_MouseMove;

            // Thêm biểu đồ vào tabPage
            tabPage_TKTheoDanhSachPhong.Controls.Add(chart);
        }

        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem chuột có nằm trên biểu đồ không
            if (e.Button == MouseButtons.None)
            {
                Chart chart_Show = (Chart)sender;

                // Lấy thông tin về điểm mà chuột đang đến gần nhất trên biểu đồ
                HitTestResult hit = chart_Show.HitTest(e.X, e.Y);

                // Kiểm tra xem điểm đó có phải là một điểm trên Series của biểu đồ không
                if (hit.ChartElementType == ChartElementType.DataPoint)
                {
                    // Lấy đối tượng DataPoint tương ứng với điểm được di chuột
                    DataPoint point = hit.Series.Points[hit.PointIndex];

                    // Hiển thị thông tin về tỉ lệ phần trăm
                    double percentage = (point.YValues[0] / totalRoomCount) * 100; // Tính toán tỷ lệ phần trăm
                    chart_Show.Series[0].ToolTip = string.Format("{0} ({1:0.00}%)", point.LegendText, percentage); // Hiển thị thông tin
                }
                else
                {
                    chart_Show.Series[0].ToolTip = ""; // Nếu chuột không nằm trên DataPoint, xóa tooltip
                }
            }
        }
    }
}