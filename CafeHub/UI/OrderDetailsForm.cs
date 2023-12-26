using CafeHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeHub.UI
{
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            if (numericUpDownTableNumber != null && numericUpDownWaiterNumber != null && comboBoxPaymentStatus != null && richTextBoxOrderItems != null)
            {
                // Получаем данные о новом заказе из формы
                int _TableNumber = Convert.ToInt32(numericUpDownTableNumber.Value);
                int _CustomerCount = Convert.ToInt32( numericUpDownWaiterNumber.Value);
                string _PaymentStatus = comboBoxPaymentStatus.Text;
                string _OrderItems = richTextBoxOrderItems.Text;
                DateTime timenow = DateTime.Now;
                string _Status = "waiting";

                // Создаем новый объект Order с полученными данными
                Order newOrder = new Order
                {
                    TableNumber = _TableNumber,
                    CustomerCount = _CustomerCount,
                    PaymentStatus = _PaymentStatus,
                    OrderItems = _OrderItems,
                    CreatedAt = timenow,
                    Status = _Status
                };

                // Добавляем нового пользователя в базу данных
                using (var dbContext = new DatabaseContext())
                {
                    dbContext.Orders.Add(newOrder);
                    dbContext.SaveChanges();
                }

                // Обновляем DataGridView с сотрудниками (если он отображается на текущей форме)

                this.Close();
            }
        }
    }
}
