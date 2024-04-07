using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    public class ServiceBUS
    {
        ServiceDAL servicesDal = new ServiceDAL();
        public DataTable getDataAll()
        {
            return servicesDal.getDataAll();
        }
        public DataTable getDataById(int id)
        {
                return servicesDal.getDataById(id);
        }
        public int insertData(string service_name, float service_price)
        {

            return servicesDal.insertData(service_name, service_price);
        }
        public int updateData(int id, string service_name, float service_price)
        {

            return servicesDal.updateData(id, service_name, service_price);
        }
        public DataTable selectLike(string service_name)
        {

            return servicesDal.selectLike(service_name);
        }
        public int deleteDataSoft(int id)
        {

            return servicesDal.deleteDataSoft(id);
        }
    }
}

