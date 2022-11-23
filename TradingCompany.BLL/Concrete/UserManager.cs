using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserDAL userDAL;

        public UserManager(IUserDAL userDAL)
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

        public bool Login(string username, string password)
        {
            return userDAL.Login(username, password);
        }
    }
}
