using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface IAuthenticationManager
    {
        bool Login(string login, string password);

        UserDTO GetUserByLogin(string login);
    }
}
