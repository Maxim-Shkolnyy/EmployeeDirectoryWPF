using EmployeeDirectoryWPF.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectoryWPF.Services
{
    public class EmployeeContextService
    {
        private readonly MyDbContext _dbContext;
        public EmployeeContextService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }
        

        //public async Task AddEmployeeAsync(Employee employee)
        //{
        //    var newEmployee = new Employee
        //    {
        //        Name = Name,
        //        Address = NewEmployeeAddress,
        //    };

        //    var isSuccess = await _employeeService.AddEmployeeAsync(newEmployee);

        //    if (isSuccess)
        //    {
        //        // Якщо додавання успішне, оновлення списку працівників
        //        LoadEmployees();
        //    }
        //}

        // Цей метод можна використовувати для оновлення інформації про працівника
        public async Task UpdateEmployeeAsync(Employee employee)
        {
            
            await Task.CompletedTask;
        }

        public async Task DeleteEmployeeAsync(Employee employee)
        {
            
            await Task.CompletedTask;
        }
    }
}
