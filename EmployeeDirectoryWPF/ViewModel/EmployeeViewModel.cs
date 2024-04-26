using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shell;

namespace EmployeeDirectoryWPF.ViewModel;

public class EmployeeViewModel : BindableBase
{
    private ObservableCollection<Employee> _employees;
    private Employee _selectedEmployee;

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>();
        AddCommand = new DelegateCommand(() => AddEmployee(new Employee()));

        UpdateCommand = new DelegateCommand(() => UpdateEmployee(new Employee()));
        DeleteCommand = new DelegateCommand(() => DeleteEmployee(new Employee()));
        GetAllCommand = new DelegateCommand(() => LoadEmployees());
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

    public ICommand AddCommand { get; }
    public ICommand UpdateCommand { get; }
    public ICommand DeleteCommand { get; }
    public ICommand GetAllCommand { get; }

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
            if (db.Employees.FirstOrDefault(el => el.Name == newEmployee.Name) == null)
            {
                db.Employees.Add(newEmployee);
                db.SaveChanges();
                LoadEmployees();
            }
            else 
            {
                MessageBox.Show("Employee with this name already exists!");
                return;
            }
        }
    }

    public void UpdateEmployee(Employee updatedEmployee)
    {
        using (var db = new MyDbContext())
        {
            var existingEmployee = db.Employees.Find(updatedEmployee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = updatedEmployee.Name;
                existingEmployee.Address = updatedEmployee.Address;
                existingEmployee.Salary = updatedEmployee.Salary;
                existingEmployee.Status = updatedEmployee.Status;
                existingEmployee.DateOfBirth = updatedEmployee.DateOfBirth;
                existingEmployee.DateOfHiring = updatedEmployee.DateOfHiring;
                existingEmployee.DateOfRetirement = updatedEmployee.DateOfRetirement;
                db.SaveChanges();
                LoadEmployees();
            }
        }
    }


    public void DeleteEmployee(Employee employeeToDelete)
    {
        using (var db = new MyDbContext())
        {
            if (db.Employees.FirstOrDefault(el => el.Id == employeeToDelete.Id) != null)
            {
                db.Employees.Remove(employeeToDelete);
                db.SaveChanges();
            }
        }
        LoadEmployees(); 
    }    
}
