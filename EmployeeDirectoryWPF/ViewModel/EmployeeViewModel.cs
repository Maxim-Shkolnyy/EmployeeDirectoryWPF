using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows.Shell;

namespace EmployeeDirectoryWPF.ViewModel;

public class EmployeeViewModel : BindableBase
{
    private ObservableCollection<Employee> _employees;
    private Employee _selectedEmployee;

    public EmployeeViewModel()
    {
        using (var db = new MyDbContext())
        {
            Employees = new ObservableCollection<Employee>(db.Employees.ToList());
        }
        LoadEmployees(); 
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

    public void LoadEmployees()
    {
        using (var db = new MyDbContext())
        {
            Employees.Clear();
            Employees.AddRange(db.Employees.ToList());
        }
    }

    public void AddEmployee(Employee newEmployee)
    {
        using (var db = new MyDbContext())
        {
            bool checkIsExist = db.Employees.Any(el => el.Name == newEmployee.Name);
            if (!checkIsExist)
            {
                Employee emp = new Employee
                {
                    Name = newEmployee.Name,
                    Address = newEmployee.Address,
                    DateOfBirth = newEmployee.DateOfBirth,
                    Phone = newEmployee.Phone,
                    JobTitle = newEmployee.JobTitle,
                    Status = newEmployee.Status,
                    Salary = newEmployee.Salary,
                    DateOfHiring = newEmployee.DateOfHiring,
                    DateOfRetirement = newEmployee.DateOfRetirement,
                };
                db.Employees.Add(emp);
                db.SaveChanges();
            }
        }
        LoadEmployees();
    }

    public void UpdateEmployee(Employee updatedEmployee)
    {
        using (var db = new MyDbContext())
        {
            db.Employees.Update(updatedEmployee);
            db.SaveChanges();
        }
        LoadEmployees(); 
    }

    public void DeleteEmployee(Employee employeeToDelete)
    {
        using (var db = new MyDbContext())
        {
            db.Employees.Remove(employeeToDelete);
            db.SaveChanges();
        }
        LoadEmployees(); 
    }

    public Employee FindByName(string name)
    {
        using (var db = new MyDbContext())
        {
            return db.Employees.FirstOrDefault(e => e.Name == name);
        }
    }
}
