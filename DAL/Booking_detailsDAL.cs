﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Booking_detailsDAL
    {
        dbConnect db = new dbConnect();
        public DataTable getDataAll()
        {

            return db.getDataTable("SELECT * FROM Booking_Details");
        }
        public DataTable getDataByBookingId(int booking_id)
        {
            return db.getDataTable($"select Booking_Details_id,Booking_Details.booking_id,Booking_Details.room_id,total_price,Booking_Details.room_id,Rooms.room_number,Rooms.room_type,Rooms.bed_type,price_per_night from Booking_Details,Rooms,Bookings where Booking_Details.booking_id=Bookings.booking_id and Booking_Details.room_id = Rooms.room_id and  Booking_Details.Booking_id = {booking_id}");
        }
        public DataTable getDataAllByBookingId(int booking_id)
        {
            return db.getDataTable($"select Booking_Details_id,Booking_Details.booking_id,Booking_Details.room_id,total_price,Booking_Details.room_id,Rooms.room_number,Rooms.room_type,Rooms.bed_type,price_per_night,Booking_details.price from Booking_Details,Rooms,Bookings where Booking_Details.booking_id=Bookings.booking_id and Booking_Details.room_id = Rooms.room_id and  Booking_Details.Booking_id = {booking_id}");
        }
        public int insertData(int booking_id,int room_id,float price)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@booking_id",booking_id),
                    new SqlParameter("@room_id",room_id),
                    new SqlParameter("@price",price),
                   
            };
            return db.ExcuteSQL("sp_booking_details_Insert", para);
        }
        public int updateQuantity(int booking_id,int service_id,int quantity)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                    new SqlParameter("@booking_id",booking_id),
                    new SqlParameter("@service_id",service_id),
                    new SqlParameter("@quantity",quantity),

           };
            return db.ExcuteSQL("sp_service_details_update_quantity", para);

        }
        public int changeRoomByIdBookingAndRoomId(int idBooking,int idRoomCurrent,int idRoomChange,float price,float priceOld,float priceNew)
        {
            SqlParameter[] para = new SqlParameter[]
          {
                    new SqlParameter("@booking_id",idBooking),
                    new SqlParameter("@room_idCurrent",idRoomCurrent),
                     new SqlParameter("@room_idChange",idRoomChange),
                     new SqlParameter("@price",price),
                     new SqlParameter("@priceOld",priceOld),
                    new SqlParameter("@priceNew",priceNew),





          };

            return db.ExcuteSQL("sp_Booking_details_Update_Room", para);
        }

    }
}
