using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace EmployeeDirectoryWPF.ViewModel;

public class AddUserViewModel : INotifyPropertyChanged
{
    private Employee _newEmployee;
    private ObservableCollection<Employee> _employees;
    private IDbCommand _addUserCommand;
    private MyDbContext _db;

    public AddUserViewModel(ObservableCollection<Employee> Employees, IDbCommand addUserCommand, MyDbContext db)
    {
        _employees = Employees;
        _addUserCommand = addUserCommand;
        _newEmployee = new Employee();
        _db = db;
    }

    public Employee NewEmployee
    {
        get { return _newEmployee; }
        set
        {
            _newEmployee = value;
            OnPropertyChanged("NewEmployee");
        }
    }

    public ICommand AddUserCommand
    {
        get
        {
            return new DelegateCommand(() =>
            {
                try
                {
                    _db.Add(_newEmployee);
                    _db.SaveChanges();

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

                    NewEmployee = new Employee();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });

        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
