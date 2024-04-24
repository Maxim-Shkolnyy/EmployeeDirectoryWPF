using EmployeeDirectoryWPF.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectoryWPF.Services
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base (options)
        {      
        }
        public DbSet<Employee> Employees { get; set; }        
    }
}
