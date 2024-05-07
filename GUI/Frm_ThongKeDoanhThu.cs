using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class Frm_ThongKeDoanhThu : Form
    {
        BookingsBUS BookingsBUS = new BookingsBUS();

        public Frm_ThongKeDoanhThu()
        {
            InitializeComponent();
            DrawRevenueChartByMonthAllYears();// Biểu đồ doanh thu theo tháng của tất cả các năm 
            DrawRevenueChartByYear();// Biểu đồ doanh thu theo tháng cho từng năm
            DrawTotalRevenueChartByYear();// Biểu đồ tổng doanh thu của các năm
        }

        private void DrawRevenueChartByMonthAllYears()
        {
            DataTable bookingData = BookingsBUS.GetBookingDataForChart();

            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(600, 400);
            chart.ChartAreas.Add("MainArea");
            chart.Series.Add("Revenue");
            chart.Series["Revenue"].ChartType = SeriesChartType.Column;

            foreach (DataRow row in bookingData.Rows)
            {
                string month = DateTimeFormatInfo.CurrentInfo.GetMonthName((int)row["Month"]);
                int revenue = Convert.ToInt32(row["TotalRevenue"]);
                chart.Series["Revenue"].Points.AddXY(month, revenue);
            }

            chart.ChartAreas["MainArea"].AxisX.Title = "Tháng";
            chart.ChartAreas["MainArea"].AxisY.Title = "Doanh thu";
            chart.Dock = DockStyle.Fill;
            tabControlTK.TabPages[0].Controls.Add(chart);
        }

        private void DrawRevenueChartByYear()
        {
            DataTable bookingData = BookingsBUS.GetBookingDataForChartByYear();

            foreach (DataRow row in bookingData.Rows)
            {
                string year = row["Year"].ToString();

                DataTable monthlyData = BookingsBUS.GetMonthlyBookingDataForYear(Convert.ToInt32(year));

                TabPage tabPage = new TabPage();
                tabPage.Name = year;
                tabPage.Text = "Năm " + year;
                tabControl1.TabPages.Add(tabPage);

                Chart chart = new Chart();
                chart.Size = new System.Drawing.Size(600, 400);
                chart.ChartAreas.Add("MainArea");
                chart.Series.Add("Revenue");
                chart.Series["Revenue"].ChartType = SeriesChartType.Column;

                foreach (DataRow monthlyRow in monthlyData.Rows)
                {
                    string month = DateTimeFormatInfo.CurrentInfo.GetMonthName((int)monthlyRow["Month"]);
                    int revenue = Convert.ToInt32(monthlyRow["TotalRevenue"]);
                    chart.Series["Revenue"].Points.AddXY(month, revenue);
                }

                chart.ChartAreas["MainArea"].AxisX.Title = "Tháng";
                chart.ChartAreas["MainArea"].AxisY.Title = "Doanh thu";
                chart.Dock = DockStyle.Fill;
                tabPage.Controls.Add(chart);
            }
        }
        private void DrawTotalRevenueChartByYear()
        {
            DataTable bookingData = BookingsBUS.GetBookingDataForChartByYear();

            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(600, 400);
            chart.ChartAreas.Add("MainArea");
            chart.Series.Add("Revenue");
            chart.Series["Revenue"].ChartType = SeriesChartType.Column;

            foreach (DataRow row in bookingData.Rows)
            {
                string year = row["Year"].ToString();
                int totalRevenue = Convert.ToInt32(row["TotalRevenue"]);

                chart.Series["Revenue"].Points.AddXY(year, totalRevenue);
            }

            chart.ChartAreas["MainArea"].AxisX.Title = "Năm";
            chart.ChartAreas["MainArea"].AxisY.Title = "Doanh thu";
            chart.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(chart);
        }

    }
}
