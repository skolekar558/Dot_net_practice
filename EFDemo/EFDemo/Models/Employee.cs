namespace EFDemo.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string? Name { get; set; }//? to allow null

        public string? City { get; set; }

        public decimal Salary { get; set; }
    }
}
