using CafeHub.Models;
using CafeHub.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CafeHub
{
    public partial class WaiterForm : Form
    {
        private readonly DatabaseContext _dbContext;
        private readonly AuthenticationService _authenticationService;
        public WaiterForm(DatabaseContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            InitializeForm();
            _authenticationService = new AuthenticationService(dbContext);
        }
        private void InitializeForm()
        {
            // Пример загрузки в DataGridView
            LoadOrders();
        }
        private void LoadOrders()
        {
            // Получаем заказы из базы данных
            var orders = _dbContext.Orders.ToList();

            // Привязываем заказы к DataGridView
            dataGridViewOrders.DataSource = orders;
        }
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления нового сотрудника
            OrderDetailsForm orderDetailsForm = new OrderDetailsForm();

            // Открываем форму
            orderDetailsForm.ShowDialog();

            UpdateOrderDataGridView();
        }
        private void UpdateOrderDataGridView()
        {
            // Получаем список сотрудников из базы данных
            List<Order> order = _dbContext.Orders.ToList();

            // Привязываем список сотрудников к DataGridView
            dataGridViewOrders.DataSource = order;

            // Обновляем DataGridView
            dataGridViewOrders.Refresh();
        }

        private void buttonMarkAsPaid_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                // Получаем Id выбранного пользователя
                int userId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["Id"].Value);

                // Вызываем метод изменения статуса пользователя
                _authenticationService.ChangeOrderPayStatus(userId);

                // Обновляем DataGridView после изменения
                UpdateOrderDataGridView();
            }
        }
    }
}
