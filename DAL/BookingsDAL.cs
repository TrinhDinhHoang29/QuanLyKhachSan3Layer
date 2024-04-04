using System;
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

    }
}
