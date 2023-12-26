using System.Linq;
using CafeHub.Models;
using CafeHub.DataAccess;

namespace CafeHub
{
    public class AuthenticationService
    {
        private readonly DatabaseContext _dbContext;

        public AuthenticationService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Authenticate(string username, string password)
        {
            // Провести аутентификацию на основе имени пользователя и пароля
            User user = _dbContext.Users .FirstOrDefault(u => u.Username == username && u.Password == password);
            return user;
        }
        public void ChangeUserStatus(int userId)
        {
            User user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);

            if (user != null)
            {
                // Изменяем статус в зависимости от текущего статуса
                if (user.Status == "Working")
                {
                    user.Status = "Dismissed";
                }
                else if (user.Status == "Dismissed")
                {
                    user.Status = "Working";
                }

                _dbContext.SaveChanges();
            }
        }
        public User RegisterUser(string username, string password, string role)
        {
            // Проверить, что пользователь с таким именем не существует
            if (_dbContext.Users.Any(u => u.Username == username))
            {
                // Пользователь с таким именем уже существует
                return null;
            }

            // Создать нового пользователя и добавить его в базу данных
            User newUser = new User
            {
                Username = username,
                Password = password,
                Role = role
            };

            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();

            return newUser;
        }
        public void ChangeOrderPayStatus(int userId)
        {
            var order = _dbContext.Orders.Find(userId);

            if (order != null)
            {
                // Меняем статус на "Paid"
                order.PaymentStatus = "Paid";

                // Сохраняем изменения в базе данных
                _dbContext.SaveChanges();
            }
        }
        public void ChangeOrderStatus(int orderId, string newStatus)
        {
            Order order = _dbContext.Orders.Find(orderId);

            if (order != null)
            {
                order.Status = newStatus;
                _dbContext.SaveChanges();
            }
        }
    }
}
