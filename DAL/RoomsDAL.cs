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

            return db.getDataTable("SELECT * FROM Rooms WHERE deleted = 0");
        }
        public DataTable getDataById(int id)
        {

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@room_id",id)
            };
            return db.getData("sp_room_Select_Id", para);

        }
        public int insertData(string room_number,string room_type,string bed_type,float price_per_night)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@room_number",room_number),
                    new SqlParameter("@room_type",room_type),
                    new SqlParameter("@bed_type",bed_type),
                    new SqlParameter("@price_per_night",price_per_night)
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
        public int updateData(int id,string room_number, string room_type, string bed_type, float price_per_night)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@room_id",id),
                    new SqlParameter("@room_number",room_number),
                    new SqlParameter("@room_type",room_type),
                    new SqlParameter("@bed_type",bed_type),
                    new SqlParameter("@price_per_night",price_per_night)
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
