using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ServiceDAL
    {
        dbConnect db = new dbConnect();
        public DataTable getDataAll()
        {
            return db.getData("sp_services_Select_All", null);
        }
        public DataTable getDataById(int id)
        {

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            return db.getData("sp_services_Select_Id", para);

        }
        public int insertData(string service_name,float service_price)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@service_name",service_name),
                    new SqlParameter("@service_price",service_price),
            };
            return db.ExcuteSQL("sp_services_Insert", para);
        }
        public int updateData(int id,string service_name, float service_price)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@id",id),
                new SqlParameter("@service_name",service_name),
                new SqlParameter("@service_price",service_price),
            };
            return db.ExcuteSQL("sp_services_Update_Id", para);
        }
        public DataTable selectLike(string service_name)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@service_name",service_name)
            };
            return db.getData("sp_services_Like_ServiceName", para);
        }
        public int deleteDataSoft(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            return db.ExcuteSQL("sp_service_DeleteSoft_Id", para);
        }
    }

}

