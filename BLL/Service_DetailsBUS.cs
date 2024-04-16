using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class Service_DetailsBUS
    {
        Service_DetailsDAL service = new Service_DetailsDAL();

        public int deleteData(int id)
        {
            return service.deleteData(id);
        }
        public DataTable getDataById(int id)
        {
            return service.getDataById(id);
        }
        public DataTable getDataByIdBookings(int id)
        {

            return service.getDataByIdBookings(id);
        }
        public int insertData(int booking_id, int service_id, int quantity)
        {
            return service.insertData(booking_id, service_id, quantity);
        }
    }
}
