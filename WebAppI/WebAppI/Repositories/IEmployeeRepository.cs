

using WebAppI.Models;

namespace WebAppI.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee employee);
        int EditEmployee(Employee employee);
        int DeleteEmployee(int id);

    }
}
