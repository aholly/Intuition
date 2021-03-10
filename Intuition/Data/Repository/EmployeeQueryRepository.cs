using Intuition.Domain.Models;
using System.Collections.Generic;

namespace Intuition.Data.Repository
{
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {


        Employee IEmployeeQueryRepository.GetEmployee(int employeeId)
        {
            // This should be taken from a event store or repository or bus
            EmployeeCommandsRepository.Employees.TryGetValue(employeeId, out var employee);
            return employee;
        }



        SortedDictionary<int, Employee> IEmployeeQueryRepository.GetOrderedEmployeeArray()
        {
            return EmployeeCommandsRepository.Employees;
        }
    }
}