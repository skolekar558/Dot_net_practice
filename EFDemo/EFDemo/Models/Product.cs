using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models
{
    public class Product
    {
        [Key]
        public int PID { get; set; } // Primary key
        public string PName { get; set; }
        public decimal Price { get; set; }
    }
}
