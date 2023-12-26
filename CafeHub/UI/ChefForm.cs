using CafeHub.Models;
using CafeHub.DataAccess; // Добавьте пространство имен для сервиса заказов
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace CafeHub
{
    public partial class ChefForm : Form
    {
        private readonly DatabaseContext _dbContext;
        private readonly AuthenticationService _orderService; // Добавьте поле для сервиса заказов

        public ChefForm(DatabaseContext dbContext, AuthenticationService orderService)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _orderService = orderService; // Инициализируйте поле сервиса заказов
            InitializeForm();
        }
        private void InitializeForm()
        {
            // Пример загрузки в DataGridView
            var orders = _dbContext.Orders.ToList();

            // Привязываем заказы к DataGridView
            dataGridViewOrders.DataSource = orders;
        }
        private void buttonChangeOrderStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                // Получаем Id выбранного заказа
                int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["Id"].Value);

                // Получаем текущий статус заказа
                string currentStatus = dataGridViewOrders.SelectedRows[0].Cells["Status"].Value.ToString();

                // Определяем новый статус в зависимости от текущего статуса
                string newStatus = DetermineNewOrderStatus(currentStatus);

                // Вызываем метод изменения статуса заказа
                _orderService.ChangeOrderStatus(orderId, newStatus);

                // Обновляем DataGridView после изменения

                UpdateOrderDataGridView();
            }
        }
        private string DetermineNewOrderStatus(string currentStatus)
        {
            switch (currentStatus)
            {
                case "waiting":
                    return "accept";
                case "accept":
                    return "ready";
                default:
                    return currentStatus;
            }
        }
        private void UpdateOrderDataGridView()
        {
            List<Order> orders = _dbContext.Orders.ToList();
            dataGridViewOrders.DataSource = orders;
            dataGridViewOrders.Refresh();
        }
    }
}
