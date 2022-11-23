using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface IUserManager
    {
        List<UserDTO> GetAllUsers();

        UserDTO GetUserByID(int id);

        bool Login(string username, string password);
    }
}
