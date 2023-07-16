using az_204_test.Models;
using System.Data.SqlClient;
using System.Numerics;

namespace az_204_test.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration configuration;
        public EmployeeRepository(IConfiguration configuraiton)
        {
            this.configuration = configuraiton;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            using (var sqlConnection = new SqlConnection(configuration.GetConnectionString("az204db")))
            {
                var command = new SqlCommand("Select * from dbo.Employee", sqlConnection);
                var employees = new List<Employee>();
                try
                {
                    sqlConnection.Open();
                    var sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        employees.Add(
                            new Employee()
                            {
                                Id = Convert.ToInt32(sqlDataReader["Id"]),
                                DateOfBirth = Convert.ToDateTime(sqlDataReader["DateOfBirth"]),
                                FirstName = Convert.ToString(sqlDataReader["FirseName"]),
                                MiddleName = Convert.ToString(sqlDataReader["MiddleName"]),
                                LastName = Convert.ToString(sqlDataReader["LastName"]),
                                Designation = Convert.ToString(sqlDataReader["Designation"]),
                                YearsExperienced = Convert.ToInt32(sqlDataReader["YearsExperienced"])
                            }
                        );
                    }
                    sqlDataReader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return employees;
            }


        }
    }
}
