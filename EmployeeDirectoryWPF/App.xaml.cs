using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using EmployeeDirectoryWPF.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeeDirectoryWPF;


public partial class App : Application
{
    private EmployeeViewModel _viewModel;
    private readonly MyDbContext _dbContext;
    public ObservableCollection<Employee> Employees { get; set; }  

    protected override async void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
        ////optionsBuilder.UseSqlServer("Server=(localdb)\\Local;Database=MaxDB;Integrated Security=True\" providerName=\"System.Data.SqlClient"); //Home PC
        ////optionsBuilder.UseSqlServer("Server=85.194.243.247,10433;Initial Catalog=MaxDB;Uid=MaxDBUser;Password=vgdrf96DFD4U;MultipleActiveResultSets=True;Connection Timeout=30"); //notebook
        //optionsBuilder.UseSqlServer("Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MaxDB;Integrated Security=True; TrustServerCertificate=True\""); // work PC

        //var dbContext = new MyDbContext(optionsBuilder.Options);

        //dbContext.Employees.Load();
        //Employee = dbContext.Employees.ToObservableCollection();

        var db = new MyDbContext();
        var empService = new EmployeeService(db);
        _viewModel = new EmployeeViewModel(db, empService);
        await _viewModel.LoadEmployees();



        Employees = _viewModel.Employees;

        //DataContext = this;

    }
}
