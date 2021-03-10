using Intuition.Domain.Models;
using System.Collections.Generic;

namespace Intuition.Data.Repository
{
    public class EmployeeCommandsRepository : IEmployeeCommandsRepository
    {

        // The SortedDictionary<TKey, TValue> generic class is a binary search tree with O(log n) retrieval, where n is the number of elements in the dictionary
        public static SortedDictionary<int, Employee> Employees = new SortedDictionary<int, Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.TryAdd(employee.EmployeeId, employee);
            // Persist the employee record in a data store or an event store
        }
    }

}
