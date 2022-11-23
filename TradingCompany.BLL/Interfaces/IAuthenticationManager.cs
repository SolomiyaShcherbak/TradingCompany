using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface IAuthenticationManager
    {
        bool Login(string login, string password);

        UserDTO GetUserByLogin(string login);
    }
}
