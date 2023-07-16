using az_204_test.Models;

namespace az_204_test.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
    }
}