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
    public class StatusBUS
    {
        private StatusDAL statusBus = new StatusDAL();

        public DataTable getDataAll()
        {
            return statusBus.getDataAll();
        }
        public int insertData(string status_title,string status_description)
        {
            return statusBus.insertData(status_title,status_description);
        }
        public int updateData(int status_id,string status_title,string status_description)
        {
            return statusBus.updateData(status_id,status_title,status_description);
        }
        public DataTable getDataById(int id)
        {
            return statusBus.getDataById(id);
        }
        public DataTable selectLike(string status_title)
        {
            return statusBus.selectLike(status_title);
        }
        public int deleteDataSoft(int status_id)
        {
            return statusBus.deleteDataSoft(status_id);
        }
        public int findIdByTitle(string status_title)
        {
            return statusBus.findIdByTitle(status_title);
        }
    }
}
