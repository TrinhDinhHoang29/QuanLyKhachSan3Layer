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
   public class RoomsBUS
    {
        private RoomsDAL room = new RoomsDAL();

        public DataTable getDataAll()
        {
            return room.getDataAll();
        }
        public DataTable getDataTrong()
        {
            return room.getDataTrong();
        }
        public DataTable getDataCoKhach()
        {
            return room.getDataCoKhach();
        }
        public DataTable getDataBaoTri()
        {
            return room.getDataBaoTri();
        }
        public DataTable getDataKhacBaoTri()
        {
            return room.getDataKhacBaoTri();
        }
        public DataTable updateStatus()
        {
            return room.updateStatus();
        }
        public int insertData(string room_number, string room_type, string bed_type, float price_per_night,int status_id)
        {
            return room.insertData( room_number,  room_type,  bed_type,  price_per_night,status_id);
        }
        public int updateData(int id,string room_number, string room_type, string bed_type, float price_per_night,int status_id)
        {
            return room.updateData(id, room_number, room_type, bed_type, price_per_night,status_id);
        }
        public DataTable getDataById(int id)
        {
            return room.getDataById(id);
        }
        public DataTable selectLike(string numberRoom)
        {
            return room.selectLike(numberRoom);
        }
        public int deleteDataSoft(int id)
        {
            return room.deleteDataSoft(id);
        }
        public int updateDataNew(int id, string room_number, string room_type, string bed_type, float price_per_night, int status_id)
        {
            return room.updateDataNew(id, room_number, room_type, bed_type, price_per_night, status_id);
        }
    }
}
