using AutoMapper;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TradingCompany.DTO;

namespace DAL.Concrete
{
    public class UserDAL : IUserDAL
    {
        private readonly IMapper _mapper;

        public UserDAL(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<UserDTO> GetAllUsers()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var users = entities.Users.ToList();
                return _mapper.Map<List<UserDTO>>(users);
            }
        }

        public UserDTO CreateUser(string email, string login, string password)
        {
            using (var entities = new TradingCompanyEntities())
            {
                if (entities.Users.Any(u => u.Login == login))
                    throw new Exception("User already exists");

                Guid salt = Guid.NewGuid();
                var user = new User
                {
                    Email = email,
                    Login = login,
                    Password = hash(password, salt.ToString()),
                    Salt = salt,
                    RowInsertTime = DateTime.UtcNow,
                    RowUpdateTime = DateTime.UtcNow
                };

                entities.Users.Add(user);
                entities.SaveChanges();

                return _mapper.Map<UserDTO>(user);
            }
        }

        public UserDTO GetUserByID(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var existUser = entities.Users.Any(u => u.UserID == id);
                User userInDB;
                if (existUser)
                {
                    userInDB = entities.Users.SingleOrDefault(u => u.UserID == id);
                    return _mapper.Map<UserDTO>(userInDB);
                }
                else
                {
                    return null;
                }
            }
        }

        public UserDTO GetUserByLogin(string login)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var existUser = entities.Users.Any(u => u.Login == login);
                User userInDB;
                if (existUser)
                {
                    userInDB = entities.Users.SingleOrDefault(u => u.Login == login);
                    return _mapper.Map<UserDTO>(userInDB);
                }
                else
                {
                    return null;
                }
            }
        }

        public bool Login(string login, string password)
        {
            using (var entities = new TradingCompanyEntities())
            {
                User user = entities.Users.SingleOrDefault(u => u.Login == login);
                return user != null && user.Password.SequenceEqual(hash(password, user.Salt.ToString()));
            }
        }

        private byte[] hash(string password, string salt)
        {
            var alg = SHA512.Create();
            return alg.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        }
    }
}
