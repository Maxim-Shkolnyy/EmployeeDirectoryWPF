using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace EmployeeDirectoryWPF.ViewModel;

public class AddViewModel : BindableBase
{
    private readonly IDbCommand _addUserCommand;
    private readonly MyDbContext _db;
    private Employee _newEmployee;
    private ObservableCollection<Employee> _employees;

    public AddViewModel(ObservableCollection<Employee> employees, IDbCommand addUserCommand, MyDbContext db)
    {
        _employees = employees;
        _addUserCommand = addUserCommand;
        _newEmployee = new Employee();
        _db = db;

        AddUserCommand = new DelegateCommand(AddNewEmployee, CanAddNewEmployee)
            .ObservesCanExecute(() => CanAdd);
    }

    public Employee NewEmployee
    {
        get => _newEmployee;
        set => SetProperty(ref _newEmployee, value);
    }

    private bool _canAdd;

    public bool CanAdd
    {
        get => _canAdd;
        set => SetProperty(ref _canAdd, value);
    }

    public DelegateCommand AddUserCommand { get; }

    private void AddNewEmployee()
    {
        try
        {
            if (!CanAddNewEmployee())
            {
                return;
            }

            _employees.Add(new Employee
            {
                Name = _newEmployee.Name,
                Address = _newEmployee.Address,
                DateOfBirth = _newEmployee.DateOfBirth,
                Phone = _newEmployee.Phone,
                JobTitle = _newEmployee.JobTitle,
                Status = _newEmployee.Status,
                Salary = _newEmployee.Salary,
                DateOfHiring = _newEmployee.DateOfHiring,
                DateOfRetirement = _newEmployee.DateOfRetirement
            });

            _db.SaveChanges();

            NewEmployee = new Employee();
        }
        catch (DbUpdateException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }


    private bool CanAddNewEmployee()
    {
        if (_newEmployee != null && !string.IsNullOrEmpty(_newEmployee.Error))
        {
            MessageBox.Show("Не всі дані коректні.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        return true;
    }
}
