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
    public class RolesDAL
    {
        dbConnect db = new dbConnect();

        public DataTable getDataAll()
        {
            return db.getDataTable("SELECT * FROM Roles WHERE deleted=0");
        }
        public int Insertdata(string role_title, string description)
        {

            SqlParameter[] para = new SqlParameter[]
                            {
                new SqlParameter("@role_title",role_title),
                new SqlParameter("@description",description)
                            };
            return db.ExcuteSQL("sp_roles_Insert", para);
        }
        public int updateData(int id,string role_title,string description)
        {
            return db.ExcuteSQl($"UPDATE roles SET role_title = '{role_title}',description='{description}' WHERE role_id = {id}");
        }
        public DataTable getDataRolesByTitle (string role_title)
        {
            return db.getDataTable($"SELECT * FROM roles where role_title = '{role_title}'");
        }
        public DataTable getDataRolesById(int role_id)
        {
            return db.getDataTable($"SELECT * FROM roles where role_id = {role_id}");
        }
        public DataTable GetDataTablePermissionByTitle(string title)
        {
            return db.getDataTable($"SELECT * FROM Permission WHERE permission_title='{title}'");
        }
        public DataTable GetDataTableRoleDetailsById(int id)
        {
            return db.getDataTable($"SELECT * FROM role_details,permission WHERE role_id={id} AND role_details.permission_id = permission.permission_id");
        }
        public bool checkPermission(int id,string permission_title)
        {
            if( db.getDataTable($"SELECT * FROM role_details,permission WHERE role_id={id} AND role_details.permission_id = permission.permission_id AND permission_title = '{permission_title}'").Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public int deleteSoftRole(int id)
        {
            SqlParameter[] para = new SqlParameter[]
                              {
                new SqlParameter("@role_id",id)
                              };
            return db.ExcuteSQL("proc_roles_delete_soft", para);
        }
        public int InsertdataRolesDetails(int role_id, int permission_id)
        {

            SqlParameter[] para = new SqlParameter[]
                            {
                new SqlParameter("@role_id",role_id),
                new SqlParameter("@permission_id",permission_id)
                            };
            return db.ExcuteSQL("sp_role_details_Insert", para);
        }
        public int deleteDataRolesDetails(int role_id, int permission_id)
        {

            SqlParameter[] para = new SqlParameter[]
                            {
                new SqlParameter("@role_id",role_id),
                new SqlParameter("@permission_id",permission_id)
                            };
            return db.ExcuteSQL("sp_role_details_Delete", para);
        }

    }
}
