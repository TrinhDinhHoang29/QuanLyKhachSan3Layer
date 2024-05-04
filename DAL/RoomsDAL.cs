using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RoomsDAL
    {
        dbConnect db = new dbConnect();
        public DataTable getDataAll()
        {

            return db.getDataTable("SELECT room_id,room_number,room_type,bed_type,price_per_night,status_id FROM Rooms WHERE deleted = 0");
        }
        public DataTable getDataTrong()
        {
            return db.getDataTable("SELECT room_id,room_number,room_type,bed_type,price_per_night,status_id FROM Rooms WHERE deleted = 0 and status_id=1");
        }
        public DataTable getDataCoKhach()
        {
            return db.getDataTable("SELECT room_id,room_number,room_type,bed_type,price_per_night,status_id FROM Rooms WHERE deleted = 0 and status_id=2");
        }
        public DataTable getDataBaoTri()
        {
            return db.getDataTable("SELECT room_id,room_number,room_type,bed_type,price_per_night,status_id FROM Rooms WHERE deleted = 0 and status_id=6");
        }
        public DataTable getDataKhacBaoTri()
        {
            return db.getDataTable("SELECT room_id,room_number,room_type,bed_type,price_per_night,status_id FROM Rooms WHERE deleted = 0 and status_id != 6");
        }
        public DataTable updateStatus()
        {
            DateTime currentDate = DateTime.Now;
            string curentDateFomat = currentDate.ToString("yyyy-MM-dd");
            string sql = $" select Rooms.room_id,Rooms.room_number,Rooms.room_type,Rooms.bed_type,price_per_night,status_id from Bookings , Booking_Details,Rooms where bookings.Booking_status!='Cancel' and Rooms.room_id = Booking_Details.room_id and Booking_Details.booking_id=Bookings.booking_id AND  check_in_date >= '{curentDateFomat}' and '{curentDateFomat}' < check_out_date";
            return db.getDataTable(sql);
        }
        public DataTable getDataById(int id)
        {

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@room_id",id)
            };
            return db.getData("sp_room_Select_Id", para);

        }
        public int insertData(string room_number,string room_type,string bed_type,float price_per_night,int status_id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@room_number",room_number),
                    new SqlParameter("@room_type",room_type),
                    new SqlParameter("@bed_type",bed_type),
                    new SqlParameter("@price_per_night",price_per_night),
                    new SqlParameter("@status_id",status_id)

            };
            return db.ExcuteSQL("sp_room_Insert", para);
        }
        public int deleteData(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@room_id",id)
            };
            return db.ExcuteSQL("sp_room_Delete_Id", para);
        }
        public int updateData(int id,string room_number, string room_type, string bed_type, float price_per_night,int status_id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@room_id",id),
                    new SqlParameter("@room_number",room_number),
                    new SqlParameter("@room_type",room_type),
                    new SqlParameter("@bed_type",bed_type),
                    new SqlParameter("@price_per_night",price_per_night),
                    new SqlParameter("@status_id",status_id)

            };
            return db.ExcuteSQL("sp_room_Update_Id", para);
        }
        public DataTable selectLike(string numberRoom)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@room_number",numberRoom)
            };
            return db.getData("sp_room_Like_roomNumber", para);
        }
        public int deleteDataSoft(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@room_id",id)
            };
            return db.ExcuteSQL("sp_rooms_DeleteSoft_Id", para);
        }
    }
}
