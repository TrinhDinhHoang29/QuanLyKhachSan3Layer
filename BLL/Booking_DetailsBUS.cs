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
    }
}
