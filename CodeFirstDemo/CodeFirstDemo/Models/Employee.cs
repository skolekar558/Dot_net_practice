using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Salary{ get; set; }
    }
}
