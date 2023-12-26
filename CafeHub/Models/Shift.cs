using System;
using System.ComponentModel.DataAnnotations;

namespace CafeHub.Models
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
