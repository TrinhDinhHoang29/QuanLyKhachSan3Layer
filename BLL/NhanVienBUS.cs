using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;


namespace BLL
{
   public class NhanVienBUS
    {
        private NhanVienDAL nv = new NhanVienDAL();
        public DataTable getDataAll ()
        {
            return nv.getDataAll();
        }
        public int insertData(string username,string password,string role)
        {
            return nv.insertData(username, password, role);
        }
        public int updateData(string id,string username,string password,string role)
        {
            return nv.updateData(id, username, password, role);
        }
        public DataTable getDataById(int id)
        {
            return nv.getDataById(id);
        }
        public DataTable selectLike(string username)
        {
            return nv.selectLike(username);
        }
    }
}
