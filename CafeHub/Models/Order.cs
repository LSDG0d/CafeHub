using System;
using System.ComponentModel.DataAnnotations;

namespace CafeHub.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public int CustomerCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public string OrderItems { get; set; }
    }
}
