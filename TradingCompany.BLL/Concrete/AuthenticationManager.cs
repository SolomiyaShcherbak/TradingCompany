using DAL.Interfaces;
using System.Collections.Generic;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Concrete
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IUserDAL userDAL;

        public AuthenticationManager(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public List<UserDTO> GetAllUsers()
        {
            return userDAL.GetAllUsers();
        }

        public UserDTO GetUserByID(int id)
        {
            return userDAL.GetUserByID(id);
        }

        public UserDTO GetUserByLogin(string login)
        {
            return userDAL.GetUserByLogin(login);
        }

        public bool Login(string login, string password)
        {
            return userDAL.Login(login, password);
        }
    }
}
