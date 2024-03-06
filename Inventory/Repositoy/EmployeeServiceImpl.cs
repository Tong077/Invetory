using Microsoft.EntityFrameworkCore;
using Inventory.Data;
using Inventory.Models;

namespace Inventory.Repository
{
    public class EmployeeServiceImpl : IEmployeeService
    {
        private readonly EntityDbContext context;

        public EmployeeServiceImpl(EntityDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Create(Employee employee)
        {
            context.Employees.Add(employee);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Employee employee)
        {
            context.Employees.Remove(employee);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<List<Employee>> GetAll()
        {
            var result = context.Employees;
            return await result.ToListAsync();
        }

        public Task<Employee> GetById(int EmployeeId)
        {
            var employee = context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == EmployeeId);
            return employee;
        }

        public async Task<bool> Update(Employee employee)
        {
            context.Employees.Update(employee);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
