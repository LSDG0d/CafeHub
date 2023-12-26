using System;
using System.Windows.Forms;

namespace CafeHub
{
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService _authenticationService;
        private readonly DatabaseContext _dbContext;
        public LoginForm(AuthenticationService authenticationService)
        {
            InitializeComponent();
            _authenticationService = authenticationService;
            _dbContext = new DatabaseContext();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // Вызываем метод аутентификации из вашего сервиса аутентификации
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите имя пользователя и пароль");
                return;
            }
            var user = _authenticationService.Authenticate(username, password);

            if (user != null)
            {
                // Успешная аутентификация
                MessageBox.Show($"Добро пожаловать, {user.Username}!");

                // В зависимости от роли пользователя открываем соответствующее окно
                OpenUserSpecificForm(user.Role);
            }
            else
            {
                // Неудачная аутентификация
                MessageBox.Show("Неверные учетные данные. Попробуйте еще раз.");
            }
        }
        private void OpenUserSpecificForm(string userRole)
        {
            // В зависимости от роли пользователя открываем соответствующее окно
            switch (userRole)
            {
                case "Administrator":
                    // Открываем окно администратора
                    AdminForm adminForm = new AdminForm(_dbContext);
                    adminForm.Show();
                    break;

                case "Waiter":
                    // Открываем окно официанта
                    WaiterForm waiterForm = new WaiterForm(_dbContext);
                    waiterForm.Show();
                    break;

                case "Chef":
                    // Открываем окно повара
                    AuthenticationService orderService = new AuthenticationService(_dbContext);
                    ChefForm chefForm = new ChefForm(_dbContext, orderService);
                    chefForm.Show(); // или другой метод отображения формы

                    break;

                default:
                    // Обработка для других ролей, если необходимо
                    break;
            }

            // Закрываем текущее окно аутентификации
            this.Hide();
        }
    }
}
