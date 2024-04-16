using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StatusDAL
    {
        dbConnect db = new dbConnect();
        public DataTable getDataAll()
        {

            return db.getDataTable("SELECT * FROM Status WHERE deleted = 0");
        }
        public DataTable getDataById(int id)
        {


            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@status_id",id)
            };
            return db.getData("sp_status_Select_Id", para);

        }
        public int insertData(string status_title,string description)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@status_title",status_title),
                    new SqlParameter("@status_description",description),


            };
            return db.ExcuteSQL("sp_status_Insert", para);
        }
        public int updateData(int id,string status_title,string status_description)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@status_id",id),
                    new SqlParameter("@status_title",status_title),
                    new SqlParameter("@status_description",status_description),


            };
            return db.ExcuteSQL("sp_status_Update_Id", para);
        }
        public DataTable selectLike(string status_title)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@status_title",status_title)
            };
            return db.getData("sp_status_Like_status_title", para);
        }
        public int deleteDataSoft(int id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@status_id",id)
            };
            return db.ExcuteSQL("sp_status_DeleteSoft_Id", para);
        }
        public int findIdByTitle(string status_title)
        {
            DataTable tableStatusId = db.getDataTable($"SELECT status_id FROM Status WHERE deleted = 0 AND status_title = N'{status_title}'");
            foreach(DataRow row in tableStatusId.Rows)
            {
 
                return Convert.ToInt32(row[0].ToString());
            }
            return -1;
        }
    }
}
