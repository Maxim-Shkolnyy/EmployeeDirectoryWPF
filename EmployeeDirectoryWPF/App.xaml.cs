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

        //using (var dbContext = new MyDbContext())
        //{
        //    _viewModel = new EmployeeViewModel(); 
        //    Employees = _viewModel.Employees;
        //}

        //dbContext.Employees.Load();
        //Employee = dbContext.Employees.ToObservableCollection();

        //var db = new MyDbContext();
        //_viewModel = new EmployeeViewModel();
        //_viewModel.LoadEmployees();

        //Employees = _viewModel.Employees;        
    }
}
