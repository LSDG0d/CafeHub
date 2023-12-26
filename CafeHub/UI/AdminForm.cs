using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CafeHub.Models;

namespace CafeHub
{
    public partial class AdminForm : Form
    {
        private readonly DatabaseContext _dbContext;

        public AdminForm(DatabaseContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            InitializeForm(); 
            _authenticationService = new AuthenticationService(dbContext);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        private void InitializeForm()
        {
            // Пример загрузки сотрудников в DataGridView
            LoadEmployees();
            LoadOrders();
            LoadShifts();
        }
        private void LoadEmployees()
        {
            // Получаем список всех сотрудников из базы данных
            var employees = _dbContext.Users.Where(u => u.Role != "Admin").ToList();

            // Привязываем список сотрудников к DataGridView
            dataGridViewEmployees.DataSource = employees;
        }
        private void LoadOrders()
        {
            // Получаем заказы из базы данных
            var orders = _dbContext.Orders.ToList();

            // Привязываем заказы к DataGridView
            dataGridViewOrders.DataSource = orders;
        }

        private void LoadShifts()
        {
            // Получаем смены из базы данных
            var shifts = _dbContext.Shifts.ToList();

            // Привязываем смены к DataGridView
            dataGridViewShifts.DataSource = shifts;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления нового сотрудника
            EmployeeDetailsForm employeeDetailsForm = new EmployeeDetailsForm();

            // Открываем форму
            employeeDetailsForm.ShowDialog();

            UpdateEmployeesDataGridView();
        }
        private void UpdateEmployeesDataGridView()
        {
            // Получаем список сотрудников из базы данных
            List<User> employees = _dbContext.Users.ToList();

            // Привязываем список сотрудников к DataGridView
            dataGridViewEmployees.DataSource = employees;

            // Обновляем DataGridView
            dataGridViewEmployees.Refresh();
        }
        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли выбранный сотрудник
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                // Получаем Id выбранного сотрудника из выделенной строки
                int selectedEmployeeId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["Id"].Value);

                // Здесь должен быть код удаления сотрудника с использованием вашего DbContext
                // Например:
                using (var dbContext = new DatabaseContext())
                {
                    var employeeToRemove = dbContext.Users.Find(selectedEmployeeId);

                    if (employeeToRemove != null)
                    {
                        dbContext.Users.Remove(employeeToRemove);
                        dbContext.SaveChanges();

                        // Обновляем DataGridView после удаления

                        UpdateEmployeesDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Выбранный сотрудник не найден.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления.");
            }

        }
        private readonly AuthenticationService _authenticationService;

        private void buttonDismissed_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                // Получаем Id выбранного пользователя
                int userId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["Id"].Value);

                // Вызываем метод изменения статуса пользователя
                _authenticationService.ChangeUserStatus(userId);

                // Обновляем DataGridView после изменения
                UpdateEmployeesDataGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления нового графика
            ShiftDetailsForm shiftDetailsForm = new ShiftDetailsForm(_dbContext);

            // Открываем форму
            shiftDetailsForm.ShowDialog();

            UpdateShiftDataGridView();
        }
        private void UpdateShiftDataGridView()
        {
            // Получаем список сотрудников из базы данных
            List<Shift> shifts = _dbContext.Shifts.ToList();

            // Привязываем список сотрудников к DataGridView
            dataGridViewShifts.DataSource = shifts;

            // Обновляем DataGridView
            dataGridViewShifts.Refresh();
        }
    }
}
