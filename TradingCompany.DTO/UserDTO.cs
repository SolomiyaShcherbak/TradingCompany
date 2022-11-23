using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; } //??

        public string Salt { get; set; }

        public DateTime RowInsertTime { get; set; }

        public DateTime RowUpdateTime { get; set; }
    }
}
