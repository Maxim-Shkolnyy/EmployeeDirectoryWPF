using EmployeeDirectoryWPF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
