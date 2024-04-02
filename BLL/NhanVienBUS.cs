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
    }
}
