using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Shell;

namespace EmployeeDirectoryWPF.ViewModel;

public class EmployeeViewModel : BindableBase
{
    private ObservableCollection<Employee> _employees;
    private Employee _selectedEmployee;
    private readonly MyDbContext _db;
    private readonly EmployeeContextService _empService;

    public EmployeeViewModel(MyDbContext db, EmployeeContextService empService)
    {
        _db = db;
        _empService = empService;
        Employees = new ObservableCollection<Employee>();
    } 

    public ObservableCollection<Employee> Employees
    {
        get { return _employees; }
        set { SetProperty(ref _employees, value); }        
    }   

    public DelegateCommand AddCommand { get; }
    public DelegateCommand UpdateCommand { get; }
    public DelegateCommand DeleteCommand { get; }
    public DelegateCommand GetAllCommand { get; }
    

    public async Task LoadEmployees()
    {
        Employees.Clear();
        var empList = await _empService.GetEmployeesAsync();

        Employees.AddRange(empList);
    }
    

    private async void AddEmployee()
    {
        // Логіка для додавання нового працівника в базу даних
        // Оновлення списку працівників після додавання
    }

    //private bool CanUpdateEmployee()
    //{
    //    // Перевірка, чи можна оновити вибраного працівника
    //}

    private void UpdateEmployee()
    {
        // Логіка для оновлення вибраного працівника в базі даних
        // Оновлення списку працівників після оновлення
    }

    //private bool CanDeleteEmployee()
    //{
    //    // Перевірка, чи можна видалити вибраного працівника
    //}

    private async void DeleteEmployee()
    {
        // Логіка для видалення вибраного працівника з бази даних
        // Оновлення списку працівників після видалення
    }
}
