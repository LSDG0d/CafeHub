using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeHub
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var dbContext = new DatabaseContext(); // Вам, возможно, нужно создать ваш контекст базы данных
            var authenticationService = new AuthenticationService(dbContext);
            var loginForm = new LoginForm(authenticationService);
            Application.Run(loginForm);
        }
    }
}
