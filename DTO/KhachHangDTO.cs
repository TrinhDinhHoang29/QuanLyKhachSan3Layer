using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class KhachHangDTO
    {
        public int room_id { get; set; }
        public string room_number { get; set; }

        public string room_type { get; set; }

        public string bed_type { get; set; }

        public float price_per_night { get; set; }


    }
}
