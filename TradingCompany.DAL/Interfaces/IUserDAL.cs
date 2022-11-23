using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DTO;

namespace DAL.Interfaces
{
    public interface IUserDAL
    {
        bool Login(string username, string password);

        UserDTO CreateUser(string email, string login, string password);

        List<UserDTO> GetAllUsers();

        UserDTO GetUserByID(int id);

        UserDTO GetUserByLogin(string login);
    }
}
