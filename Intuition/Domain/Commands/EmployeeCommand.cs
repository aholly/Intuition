using Intuition.Data.Repository;
using Intuition.Domain.Interfaces;
using Intuition.Domain.Models;

namespace Intuition.Domain.Commands
{
    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _repository;
        public EmployeeCommands(IEmployeeCommandsRepository repository)
        {
            _repository = repository;
        }
        public void AddEmployee(Employee employee)
        {
            _repository.AddEmployee(employee);
        }
    }
}
