using Intuition.Domain.Models;
using System.Collections.Generic;

namespace Intuition.Domain.Interfaces
{
    public interface IEmployeeQueries
    {
        Employee GetEmployee(int employeeId);



        public SortedDictionary<int, Employee> GetOrderedEmployeeArray();
    }
}
