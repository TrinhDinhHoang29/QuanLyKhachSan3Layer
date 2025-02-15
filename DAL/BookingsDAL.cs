﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class BookingsDAL
    {
        dbConnect db = new dbConnect();

        public DataTable getDataAll()
        {
            return db.getDataTable("SELECT * FROM bookings ORDER BY Booking_id DESC");
        }
        public DataTable checkDate(int roomId, DateTime check_in_dateNew,DateTime check_out_dateNew)
        {
            string fomatDateCheckIn = check_in_dateNew.ToString("yyyy-MM-dd");
            string fomatDateCheckOut = check_out_dateNew.ToString("yyyy-MM-dd");

            return db.getDataTable($"select * from bookings,Booking_Details where bookings.Booking_status!='Cancel' and Bookings.booking_id=Booking_Details.booking_id AND Booking_Details.room_id={roomId}  AND ( check_in_date <= '{check_in_dateNew}' and '{check_in_dateNew}' < check_out_date OR check_in_date<'{check_out_dateNew}' and '{check_out_dateNew}'<=check_out_date)");
        }
        public int deleteData(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@booking_id",id),
        };
            return db.ExcuteSQL("sp_bookings_Delete_id", para);
        }
        public DataTable selectByIdCustomer(int id_Customer)
        {
            return db.getDataTable($"SELECT * FROM Bookings WHERE customer_id={id_Customer}");
        }
        public int getIdAndInsert(int customer_id,DateTime check_in_date,DateTime check_out_date,int account_id,float total_price)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                    new SqlParameter("@customer_id",customer_id),
                    new SqlParameter("@check_in_date",check_in_date),
                    new SqlParameter("@check_out_date",check_out_date),
                    new SqlParameter("@account_id",account_id),
                    new SqlParameter("@total_price",total_price),
           };
            return db.GetParamsExcuteSQL("sp_bookings_getIdAndInsert", para);
        }
        public int updateStatusById(int booking_id,string booking_status)
        {
            SqlParameter[] para = new SqlParameter[]
          {
                    new SqlParameter("@booking_id",booking_id),
                    new SqlParameter("@booking_status",booking_status),    
          };
            return db.ExcuteSQL("sp_bookings_UpdateStatusById", para);
        }
        public DataTable getDataById(int id)
        {
            return db.getDataTable($"SELECT * FROM Bookings WHERE booking_id = {id}");
        }

        public DataTable getDataByIdRoomAndCurrentDate(string room_number)
        {
            SqlParameter[] para = new SqlParameter[]
          {
                    new SqlParameter("@room_number",room_number),
          };
            return db.getData("getDataByRoomNumberAndCurrentDate", para);
        }
        public DataTable GetBookingDataForChart()
        {
            string query = "SELECT MONTH(check_in_date) AS [Month], SUM(total_price) AS [TotalRevenue] " +
                              "FROM Bookings " +
                              "GROUP BY MONTH(check_in_date)";
            return db.getDataTable(query);
        }
        public DataTable GetBookingDataForChartByYear()
        {
            string query = "SELECT YEAR(check_in_date) AS [Year], SUM(total_price) AS [TotalRevenue] " +
                               "FROM Bookings " +
                               "GROUP BY YEAR(check_in_date)";

            return db.getDataTable(query);
        }
        public DataTable GetMonthlyBookingDataForYear(int year)
        {
            string query = "SELECT MONTH(check_in_date) AS [Month], SUM(total_price) AS [TotalRevenue] " +
                              "FROM Bookings " +
                              "Where " + year + " = Year(check_in_date)" +
                              "GROUP BY MONTH(check_in_date) ";
            return db.getDataTable(query);
        }
        public DataTable getBookingsByFullNameCustomer(string fullName)
        {
            string query = "select Bookings.booking_id,Bookings.customer_id,Bookings.check_in_date,Bookings.check_out_date,Bookings.account_id,Bookings.total_price,Bookings.Booking_status" +
                             " from Bookings,Customers" +
                             $" where Customers.customer_id = Bookings.customer_id and Customers.first_name+' '+Customers.last_name like '%{fullName}%'";
            return db.getDataTable(query);
        }
        public DataTable getBookingsCurrentDateByFullNameCustomer(string fullName)
        {
            string query = "select Bookings.booking_id,Bookings.customer_id,Bookings.check_in_date,Bookings.check_out_date,Bookings.account_id,Bookings.total_price,Bookings.Booking_status" +
                          " from Bookings,Customers" +
                          $" where Customers.customer_id = Bookings.customer_id and Bookings.check_in_date<=GETDATE() AND Bookings.check_out_date>GETDATE() and Customers.first_name+' '+Customers.last_name like '%{fullName}%' AND Booking_status !='Cancel'";
            return db.getDataTable(query);
        }
        public DataTable getBookingsCurrentDate()
        {
            string query = "select Bookings.booking_id,Bookings.customer_id,Bookings.check_in_date,Bookings.check_out_date,Bookings.account_id,Bookings.total_price,Bookings.Booking_status" +
                          " from Bookings,Customers" +
                          $" where Customers.customer_id = Bookings.customer_id and Bookings.check_in_date<=GETDATE() AND Bookings.check_out_date>GETDATE() AND Booking_status !='Cancel'";
            return db.getDataTable(query);
        }
        public DataTable getBookingsByStatus(string status)
        {
            string query = "select Bookings.booking_id,Bookings.customer_id,Bookings.check_in_date,Bookings.check_out_date,Bookings.account_id,Bookings.total_price,Bookings.Booking_status" +
                            $" from Bookings WHERE Booking_status = '{status}'";
            

            return db.getDataTable(query);
        }
        public DataTable getBookingsByStatusAndFullName(string status,string fullName)
        {
            string query = "select Bookings.booking_id,Bookings.customer_id,Bookings.check_in_date,Bookings.check_out_date,Bookings.account_id,Bookings.total_price,Bookings.Booking_status" +
                            $" from Bookings,Customers WHERE Bookings.Customer_id = Customers.Customer_id AND Booking_status = '{status}' and Customers.first_name+' '+Customers.last_name like '%{fullName}%' ";


            return db.getDataTable(query);
        }
        public DataTable getBookingsAfterCheckin()
        {
            string query = "select Bookings.booking_id,Bookings.customer_id,Bookings.check_in_date,Bookings.check_out_date,Bookings.account_id,Bookings.total_price,Bookings.Booking_status" +
                        $" FROM Bookings WHERE check_in_date > GETDATE() AND Booking_status != 'Cancel'";
            return db.getDataTable(query);

        }
        public DataTable getBookingsAfterCheckinByFullName(string fullName)
        {
            string query = "select Bookings.booking_id,Bookings.customer_id,Bookings.check_in_date,Bookings.check_out_date,Bookings.account_id,Bookings.total_price,Bookings.Booking_status" +
                        $" FROM Bookings,Customers WHERE check_in_date > GETDATE() AND Booking_status != 'Cancel' AND Bookings.Customer_id = Customers.Customer_id AND Customers.first_name+' '+Customers.last_name like '%{fullName}%' ";
            return db.getDataTable(query);

        }

    }
}
