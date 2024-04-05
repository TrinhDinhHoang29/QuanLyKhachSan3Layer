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
   public class NhanVienDAL
    {
         dbConnect db = new dbConnect();
        public DataTable getDataAll()
        {
                return db.getData("sp_account_Select_All", null);
        }
        public DataTable getDataById(int id)
        {
    
                SqlParameter[] para = new SqlParameter[]
                {
                new SqlParameter("@id",id)
                };
                return db.getData("sp_account_Select_Id", para);
                   
        }
        public int insertData(string username,string password_hash,string role)
        {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@username",username),
                    new SqlParameter("@password_hash",password_hash),
                    new SqlParameter("@role",role)
                };
                return db.ExcuteSQL("sp_acounts_Insert",para);   
        }
        public int deleteData(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@id",id)   
            };
            return db.ExcuteSQL("sp_acounts_Delete_Id", para);
        }
        public int updateData(int id,string username,string password,string role)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@id",id),
                new SqlParameter("@username",username),
                new SqlParameter("@password",password),
                new SqlParameter("@role",role)
            };
            return db.ExcuteSQL("sp_accounts_Update_Id", para); 
        }
        public DataTable selectLike(string userName)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@username",userName)
            };
            return db.getData("sp_acounts_Like_Username", para);
        }
        public DataTable getDataByUsername(string username)
        {
            SqlParameter[] para = new SqlParameter[]
            {
            new SqlParameter("@username", username)
            };
            return db.getData("sp_account_Select_Username", para);
        }
        public int deleteDataSoft(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@account_id",id)
            };
            return db.ExcuteSQL("sp_accounts_DeleteSoft_Id", para);
        }
    }
}
