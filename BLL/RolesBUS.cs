using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class RolesBUS
    {
        RolesDAL rolesDal = new RolesDAL();
        public DataTable getDataAll()
        {
            return rolesDal.getDataAll();
        }
        public int InsertData(string role_title, string description)
        {
            return rolesDal.Insertdata(role_title, description);
        }
        public int InsertdataRolesDetails(int role_id, int permission_id)
        {
            return rolesDal.InsertdataRolesDetails(role_id, permission_id);
        }
        public int deleteDataRolesDetails(int role_id, int permission_id)
        {
            return rolesDal.deleteDataRolesDetails(role_id, permission_id);
        }
        public DataTable GetDataTablePermissionByTitle(string title)
        {
            return rolesDal.GetDataTablePermissionByTitle(title);
        }
        public DataTable GetDataTableRoleDetailsById(int id)
        {
            return rolesDal.GetDataTableRoleDetailsById(id);
        }
        public bool checkPermission(int id, string permission_title)
        {
            return rolesDal.checkPermission(id, permission_title);
        }
        public int deleteSoftRole(int id)
        {
            return rolesDal.deleteSoftRole(id);
        }
        public DataTable getDataRolesByTitle(string role_title)
        {
            return rolesDal.getDataRolesByTitle(role_title);
        }
        public DataTable getDataRolesById(int role_id)
        {
            return rolesDal.getDataRolesById(role_id);
        }
        public int updateData(int id, string role_title, string description)
        {
            return rolesDal.updateData(id, role_title, description);
        }

    }
}
