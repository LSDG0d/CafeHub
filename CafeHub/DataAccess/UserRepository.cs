using CafeHub.Models;
using System.Collections.Generic;
using System.Linq;

namespace CafeHub.DataAccess
{
    public class UserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            // Здесь вы можете инициализировать список пользователей из базы данных или другого источника данных
            _users = new List<User>
            {
                new User { Id = 1, Username = "admin", Password = "admin123", Role = "Administrator" },
                new User { Id = 2, Username = "waiter", Password = "waiter123", Role = "Waiter" },
                new User { Id = 3, Username = "chef", Password = "chef123", Role = "Chef" }
            };
        }

        public User GetUserById(int userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }

        public List<User> GetAllUsers()
        {
            return _users.ToList();
        }
    }
}
