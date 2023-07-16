using az_204_test.Services;
using Microsoft.AspNetCore.Mvc;

namespace az_204_test.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        public IActionResult Index()
        {
            var employees = employeeService.GetEmployees();
            return View(employees);
        }
    }
}
