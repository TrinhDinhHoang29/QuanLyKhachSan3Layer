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

        public int deleteData(int id)
        {
            return bookings.deleteData(id);
        }
        public DataTable selectByIdCustomer(int id_Customers)
        {
            return bookings.selectByIdCustomer(id_Customers);
        }
    }
}
