using az_204_test.Models;
using az_204_test.Repositories;
using System.Runtime.InteropServices;

namespace az_204_test.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employeeRepository.GetEmployees();
        }
    }
}
