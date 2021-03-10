using Intuition.Domain.Models;
using System.Collections.Generic;

namespace Intuition.Data.Repository
{
    public interface IEmployeeQueryRepository
    {
        Employee GetEmployee(int employeeId);

        SortedDictionary<int, Employee> GetOrderedEmployeeArray();
    }
}

