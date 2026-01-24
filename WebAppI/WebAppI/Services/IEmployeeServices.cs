using WebAppI.Models;

namespace WebAppI.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int EditEmployee(Employee employee);
        int DeleteEmployee(int id);
    }
}
