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
    private readonly EmployeeService _empService;

    public EmployeeViewModel(MyDbContext db, EmployeeService empService)
    {
        _db = db;
        _empService = empService;
        Employees = new ObservableCollection<Employee>();
        GetAllCommand = new DelegateCommand(async () => await LoadEmployees());
    }

   

    public ObservableCollection<Employee> Employees
    {
        get { return _employees; }
        set { SetProperty(ref _employees, value); }        
    }

    public Employee SelectedEmployee
    {
        get { return _selectedEmployee; }
        set { SetProperty(ref _selectedEmployee, value); }
    }

    public DelegateCommand AddCommand { get; }
    public DelegateCommand UpdateCommand { get; }
    public DelegateCommand DeleteCommand { get; }
    public DelegateCommand GetAllCommand { get; }

    //public EmployeeViewModel()
    //{
    //    GetAllCommand = new DelegateCommand(async () => await LoadEmployees());

    //    //UpdateCommand = new DelegateCommand(UpdateEmployee, CanUpdateEmployee);
    //    // DeleteCommand = new DelegateCommand(DeleteEmployee, CanDeleteEmployee);



    //}

    public async Task LoadEmployees()
    {
        var empList = await _empService.GetEmployeesAsync();
        Employees.Clear();
        foreach (var emp in empList)
        {
            Employees.Add(emp);
        }
    }

    //private async Task LoadEmployees()
    //{
    //    var empList = await _empService.GetEmployeesAsync();
    //    Employees = new ObservableCollection<Employee>(empList);
    //}

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
