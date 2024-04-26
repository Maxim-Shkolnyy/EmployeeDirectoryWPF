using EmployeeDirectoryWPF.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectoryWPF.Services
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);           

            optionsBuilder.UseSqlServer("Server=MAX\\SQLEXPRESS;Database=MaxDB;Integrated Security=True; TrustServerCertificate=True;"); //Home PC
            //optionsBuilder.UseSqlServer("Server=85.194.243.247,10433;Initial Catalog=MaxDB;Uid=MaxDBUser;Password=vgdrf96DFD4U;MultipleActiveResultSets=True;Connection Timeout=30"); //notebook
            //optionsBuilder.UseSqlServer("Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MaxDB;Integrated Security=True; TrustServerCertificate=True;"); // work PC
        }
    }   
}
