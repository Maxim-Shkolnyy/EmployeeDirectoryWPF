using EmployeeDirectoryWPF.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectoryWPF.Services
{
    internal class CRUD
    {
        private readonly MyDbContext _dbContext;
        public CRUD(MyDbContext dbContext)
        {
               _dbContext = dbContext;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }

    }
}
