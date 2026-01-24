using System.ComponentModel.DataAnnotations;

namespace DIPatternDemo.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }//? to allow null
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? ContactNo {  get; set; }
        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
