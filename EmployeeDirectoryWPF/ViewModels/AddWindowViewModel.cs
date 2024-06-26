﻿using EmployeeDirectoryWPF.Model;
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

namespace EmployeeDirectoryWPF.ViewModels;

public class AddWindowViewModel : BindableBase
{
    //private readonly IDbCommand _addUserCommand;
    private readonly MyDbContext _db;
    private Employee _newEmployee;
    private ObservableCollection<Employee> _employees;    

    public Employee NewEmployee
    {
        get => _newEmployee;
        set => SetProperty(ref _newEmployee, value);
    }

    private bool _isEnabled;
    public bool IsEnabled
    {
        get { return true; }
        set { SetProperty(ref _isEnabled, value); }
    }

    public DelegateCommand AddUserCommand { get; private set; }

    public AddWindowViewModel()
    {
        using (MyDbContext db = new MyDbContext())
        {
            _db = db;
            _newEmployee = new Employee();
            _isEnabled = true;
            _employees = new ObservableCollection<Employee>();
            _employees.AddRange(db.Employees);

        }


        AddUserCommand = new DelegateCommand(AddNewEmployee)
            .ObservesCanExecute(() => IsEnabled);
    }

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
