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

        //dbContext.Employees.Load();
        //Employee = dbContext.Employees.ToObservableCollection();

        var db = new MyDbContext();
        var empService = new EmployeeContextService(db);
        _viewModel = new EmployeeViewModel(db, empService);
        await _viewModel.LoadEmployees();



        Employees = _viewModel.Employees;

        //DataContext = this;

    }
}
