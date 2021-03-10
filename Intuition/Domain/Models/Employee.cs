namespace Intuition.Domain.Models
{
    public class Employee
    {
        public readonly int EmployeeId;
        public readonly string FirstName;
        public readonly string LastName;

        public Employee(int employeeId, string firstName, string lastName)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
