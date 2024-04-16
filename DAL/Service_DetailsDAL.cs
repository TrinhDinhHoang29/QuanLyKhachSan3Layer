using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Service_DetailsDAL
    {
        dbConnect db = new dbConnect();

        public int deleteData(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@service_detail_id",id),
        };
            return db.ExcuteSQL("sp_serviceDetails_Delete_id", para);
        }
        public DataTable getDataById(int id)
        {

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@service_detail_id",id)
            };
            return db.getData("sp_serviceDetails_Select_Id", para);

        }
        public DataTable getDataByIdBookings(int id)
        {

            return db.getDataTable($"SELECT * FROM Service_Details WHERE booking_id = {id}");
        }
        public int insertData(int booking_id , int service_id,int quantity)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@booking_id",booking_id),
                    new SqlParameter("@service_id",service_id),
                    new SqlParameter("@quantity",quantity),
                 
            };
            return db.ExcuteSQL("sp_service_details_Insert", para);
        }
    }
}
