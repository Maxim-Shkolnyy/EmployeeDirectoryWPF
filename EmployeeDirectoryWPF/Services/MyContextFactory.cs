﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectoryWPF.Services
{
    internal class MyContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MaxDB;Integrated Security=True; TrustServerCertificate=True");

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}