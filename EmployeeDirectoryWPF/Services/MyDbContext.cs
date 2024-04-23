using EmployeeDirectoryWPF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectoryWPF.Services
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base (options)
        {      
        }
        public DbSet<EmployeeModel> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\Local;Database=MaxDB;Integrated Security=True\" providerName=\"System.Data.SqlClient;");
        }
    }
}
