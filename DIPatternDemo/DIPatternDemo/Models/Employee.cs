using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPatternDemo.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }//? to allow null
        [Required]
        public string? City { get; set; }
        [Required]
        public double Salary { get; set; }
        [ScaffoldColumn(false)]
        public int IsActive {  get; set; }
        
    }
}
