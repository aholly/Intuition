using Intuition.Domain.Models;

namespace Intuition.Data.Repository
{
    public interface IEmployeeCommandsRepository
    {
        void AddEmployee(Employee employee);
    }
}

