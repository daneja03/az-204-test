namespace az_204_test.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int YearsExperienced { get; set; }

        public string FullName 
        { 
            get { return $"{FirstName} {MiddleName} {LastName}"; } 
        }
    }
}
