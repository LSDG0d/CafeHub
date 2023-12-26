using System;
using System.Windows.Forms;
using CafeHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeHub
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (textBoxName != null && comboBoxPosition != null && comboBoxStatus != null && textBoxPassword != null)
            {
                // Получаем данные о новом сотруднике из формы
                string name = textBoxName.Text;
                string position = comboBoxPosition.Text;
                string status = comboBoxStatus.Text;
                string password = textBoxPassword.Text;

                // Создаем новый объект User с полученными данными
                User newUser = new User
                {
                    Username = name,
                    Role = position,
                    Status = status,
                    Password = password
                };

                // Добавляем нового пользователя в базу данных
                using (var dbContext = new DatabaseContext())
                {
                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();
                }

                // Обновляем DataGridView с сотрудниками (если он отображается на текущей форме)
                
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
