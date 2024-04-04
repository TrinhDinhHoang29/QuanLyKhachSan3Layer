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
    }
}
