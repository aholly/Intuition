using Intuition.Data.Repository;
using Intuition.Domain.Interfaces;
using Intuition.Domain.Models;
using System.Collections.Generic;

namespace Intuition.Domain.Queries
{
    public class EmployeeQueries : IEmployeeQueries
    {
        private readonly IEmployeeQueryRepository _repository;
        public EmployeeQueries(IEmployeeQueryRepository repository)
        {
            _repository = repository;
        }
        public Employee GetEmployee(int employeeId)
        {
            return _repository.GetEmployee(employeeId);

        }

        public SortedDictionary<int, Employee> GetOrderedEmployeeArray()
        {
            return _repository.GetOrderedEmployeeArray();

        }
    }
}
