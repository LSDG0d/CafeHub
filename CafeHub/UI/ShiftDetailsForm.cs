using System;
using System.Windows.Forms;
using CafeHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeHub
{
    public partial class ShiftDetailsForm : Form
    {
        private readonly DatabaseContext _dbContext;
        public ShiftDetailsForm(DatabaseContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string shiftName = textBoxShiftInfo.Text;
            DateTime startTime = dateTimePickerStartDate.Value;
            DateTime endTime = dateTimePickerEndDate.Value;

            // Создаем новую смену
            Shift newShift = new Shift
            {
                Name = shiftName,
                StartTime = startTime,
                EndTime = endTime
            };

            // Добавляем смену в базу данных
            _dbContext.Shifts.Add(newShift);
            _dbContext.SaveChanges();

            // Оповещаем пользователя об успешном добавлении
            MessageBox.Show("Смена успешно добавлена в базу данных.");

            // Опционально: закрываем форму после добавления
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
