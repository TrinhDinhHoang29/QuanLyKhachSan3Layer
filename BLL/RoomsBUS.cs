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
    class RoomsBUS
    {
        private RoomsDAL room = new RoomsDAL();

        public DataTable getDataAll()
        {
            return room.getDataAll();
        }
        public int insertData(string room_number, string room_type, string bed_type, float price_per_night)
        {
            return room.insertData( room_number,  room_type,  bed_type,  price_per_night);
        }
        public int updateData(int id,string room_number, string room_type, string bed_type, float price_per_night)
        {
            return room.updateData(id, room_number, room_type, bed_type, price_per_night);
        }
        public DataTable getDataById(int id)
        {
            return room.getDataById(id);
        }
        public DataTable selectLike(string numberRoom)
        {
            return room.selectLike(numberRoom);
        }
    }
}
