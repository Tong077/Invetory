using Microsoft.EntityFrameworkCore;
using Inventory.Data;
using Inventory.Models;


namespace Inventory.Repository
{
    public interface IEmployeeService
    {
        Task<bool> Create(Employee employee);
        Task<bool> Update(Employee employee);
        Task<bool> Delete(Employee employee);
        Task<Employee> GetById(int EmployeeId);
        Task<List<Employee>> GetAll();
    }
}
