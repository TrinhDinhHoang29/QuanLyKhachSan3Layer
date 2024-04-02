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
            try
            {
                return db.getData("sp_account_Select_All", null);
            }
            catch
            {
                return null;
            }
        }
        public DataTable getDataById(int id)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                new SqlParameter("@id",id)
                };
                return db.getData("sp_account_Select_Id", para);
            }
            catch
            {
                return null;
            }         
        }
        public int insertData(string username,string password_hash,string role)
        {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@username","dinhHoag"),
                    new SqlParameter("@password_hash","dinhHoag"),
                    new SqlParameter("@role","user")
                };
                return db.ExcuteSQL("sp_acounts_Insert",para);
           
        }
    }
}
