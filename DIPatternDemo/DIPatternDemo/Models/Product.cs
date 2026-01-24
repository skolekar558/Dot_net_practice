using System.ComponentModel.DataAnnotations;

namespace DIPatternDemo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } // Product name
        [Required]
        public string Description { get; set; } // Product description
        [Required]
        public double Price { get; set; } // Product price
        [Required]
        public int StockQuantity { get; set; } // Quantity in stock
        [Required]
        public bool IsAvailable { get; set; } // Availability status
    }
}
