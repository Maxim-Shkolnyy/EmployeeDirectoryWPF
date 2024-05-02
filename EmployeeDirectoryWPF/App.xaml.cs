using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using EmployeeDirectoryWPF.ViewModels;
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
       
    }
}
