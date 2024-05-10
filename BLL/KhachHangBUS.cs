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
   public class KhachHangBUS
    {
        private KhachHangDAL kh = new KhachHangDAL();
        public DataTable getDataAll()
        {
            return kh.getDataAll();
        }
        public int insertData(string first_name, string last_name, string email, string phone, string address)
        {
            return kh.insertData( first_name,  last_name,  email,  phone,  address);
        }
        public int updateData(int id ,string first_name, string last_name, string email, string phone, string address)
        {
            return kh.updateData(id,first_name, last_name, email, phone, address);
        }
        public DataTable getDataById(int id)
        {
            return kh.getDataById(id);
        }
        public DataTable selectLike(string fullName)
        {
            return kh.selectLike(fullName);
        }
        public int deleteData(int id)
        {
            return kh.deleteData(id);
        }
        public int deleteDataSoft(int id)
        {
            return kh.deleteDataSoft(id);
        }
        public int getIdAndInsert(string first_name, string last_name, string email, string phone, string address)
        {
            return kh.getIdAndInsert( first_name,  last_name,  email,  phone,  address);
        }
        public DataTable getDataByIdDeleted(int id)
        {
            return kh.getDataByIdDeleted(id);
        }

    }
}
