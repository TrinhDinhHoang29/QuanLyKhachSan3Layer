using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
     
     public class BookingsBUS
    {
        BookingsDAL bookings = new BookingsDAL();

        public DataTable getDataAll()
        {
            return bookings.getDataAll();
        }
        public DataTable checkDate(int roomId,DateTime check_in_dateNew, DateTime check_out_dateNew)
        {
            return bookings.checkDate(roomId,check_in_dateNew, check_out_dateNew);
        }

        public int deleteData(int id)
        {
            return bookings.deleteData(id);
        }
        public DataTable selectByIdCustomer(int id_Customers)
        {
            return bookings.selectByIdCustomer(id_Customers);
        }
        public int getIdAndInsert(int customer_id, DateTime check_in_date, DateTime check_out_date, int account_id, float total_price)
        {
            return bookings.getIdAndInsert(customer_id, check_in_date, check_out_date, account_id, total_price);
        }
        public int updateStatusById(int booking_id, string booking_status)
        {
            return bookings.updateStatusById(booking_id, booking_status);
        }
        public DataTable getDataById(int id)
        {
            return bookings.getDataById(id);
        }
        public DataTable getDataByIdRoomAndCurrentDate(string room_number)
        {
            return bookings.getDataByIdRoomAndCurrentDate(room_number);
        }
        public DataTable GetBookingDataForChart()
        {
            return bookings.GetBookingDataForChart();
        }
        public DataTable GetBookingDataForChartByYear()
        {
            return bookings.GetBookingDataForChartByYear();
        }
        public DataTable GetMonthlyBookingDataForYear(int year)
        {
            return bookings.GetMonthlyBookingDataForYear(year);
        }
        public DataTable getBookingsByFullNameCustomer(string fullName)
        {
            return bookings.getBookingsByFullNameCustomer(fullName);
        }
        public DataTable getBookingsCurrentDateByFullNameCustomer(string fullName)
        {
            return bookings.getBookingsCurrentDateByFullNameCustomer(fullName);
        }
        public DataTable getBookingsCurrentDate()
        {
            return bookings.getBookingsCurrentDate();
        }
        public DataTable getBookingsByStatus(string status)
        {
            return bookings.getBookingsByStatus(status);
        }
        public DataTable getBookingsByStatusAndFullName(string status, string fullName)
        {
            return bookings.getBookingsByStatusAndFullName(status,fullName);
        }
        public DataTable getBookingsAfterCheckin()
        {
            return bookings.getBookingsAfterCheckin();
        }
        public DataTable getBookingsAfterCheckinByFullName(string fullName)
        {
            return bookings.getBookingsAfterCheckinByFullName(fullName);
        }

    }
}
