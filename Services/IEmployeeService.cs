using az_204_test.Models;

namespace az_204_test.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}