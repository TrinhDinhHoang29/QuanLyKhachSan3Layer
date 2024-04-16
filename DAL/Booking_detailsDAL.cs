using System;
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


    }
}
