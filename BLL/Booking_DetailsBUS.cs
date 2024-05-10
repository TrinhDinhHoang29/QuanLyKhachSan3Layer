using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Booking_DetailsBUS
    {
        private Booking_detailsDAL bookingDetailsDal = new Booking_detailsDAL();
        public DataTable getDataAll()
        {
            return bookingDetailsDal.getDataAll();
        }
        public int insertData(int booking_id, int room_id, float price)
        {
            return bookingDetailsDal.insertData(booking_id, room_id, price);
        }
        public DataTable getDataByBookingId(int booking_id)
        {
            return bookingDetailsDal.getDataByBookingId(booking_id);
        }
        public int updateQuantity(int booking_id, int service_id, int quantity)
        {
            return bookingDetailsDal.updateQuantity(booking_id, service_id, quantity);
        }
        public int changeRoomByIdBookingAndRoomId(int idBooking, int idRoomCurrent, int idRoomChange, float price, float priceOld, float priceNew)
        {
            return bookingDetailsDal.changeRoomByIdBookingAndRoomId(idBooking, idRoomCurrent, idRoomChange,price,priceOld,priceNew);
        }
        public DataTable getDataAllByBookingId(int booking_id)
        {
            return bookingDetailsDal.getDataAllByBookingId(booking_id);
        }


    }
}
