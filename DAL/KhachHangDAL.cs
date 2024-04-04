using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class KhachHangDAL
    {
        dbConnect db = new dbConnect();
        public DataTable getDataAll()
        {
         
                return db.getData("sp_customer_Select_All", null);     
        }
        public DataTable getDataById(int id)
        {

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@customer_id",id)
            };
            return db.getData("sp_customer_Select_Id", para);

        }
        public int insertData(string first_name ,string last_name ,string email,string phone,string address)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@first_name",first_name),
                    new SqlParameter("@last_name",last_name),
                    new SqlParameter("@email",email),
                    new SqlParameter("@phone",phone),
                    new SqlParameter("@address",address),
            };
            return db.ExcuteSQL("sp_customer_Insert", para);
        }
        public int deleteData(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@customer_id",id)
            };
            return db.ExcuteSQL("sp_customer_Delete_Id", para);
        }
        public int updateData(int id,string first_name, string last_name, string email, string phone, string address)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@customer_id",id),
                    new SqlParameter("@first_name",first_name),
                    new SqlParameter("@last_name",last_name),
                    new SqlParameter("@email",email),
                    new SqlParameter("@phone",phone),
                    new SqlParameter("@address",address),
            };
            return db.ExcuteSQL("sp_customer_Update_Id", para);
        }
        public DataTable selectLike(string fullName)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@fullName",fullName)
            };
            return db.getData("sp_customer_Like_FullName", para);
        }
        public int deleteDataSoft(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@customer_id",id)
            };
            return db.ExcuteSQL("sp_customer_DeleteSoft_Id", para);
        }
    }
}
