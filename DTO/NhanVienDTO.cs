using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int account_id { get; set; }
        public string username { get; set; }
        public string password_hash { get; set; }
        public string role { get; set; }


    }
}
