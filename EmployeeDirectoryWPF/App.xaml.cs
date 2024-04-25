using EmployeeDirectoryWPF.Services;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace EmployeeDirectoryWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            //optionsBuilder.UseSqlServer("Server=(localdb)\\Local;Database=MaxDB;Integrated Security=True\" providerName=\"System.Data.SqlClient"); //Home PC
            //optionsBuilder.UseSqlServer("Server=85.194.243.247,10433;Initial Catalog=MaxDB;Uid=MaxDBUser;Password=vgdrf96DFD4U;MultipleActiveResultSets=True;Connection Timeout=30"); //notebook
            optionsBuilder.UseSqlServer("Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MaxDB;Integrated Security=True; TrustServerCertificate=True\""); // work PC

            //var dbContext = new MyDbContext(optionsBuilder.Options);

            //dbContext.Employees.Load();
            //Employee = dbContext.Employees.ToObservableCollection();

        }       
    }
}
