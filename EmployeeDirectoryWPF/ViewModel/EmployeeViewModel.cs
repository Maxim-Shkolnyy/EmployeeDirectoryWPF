using EmployeeDirectoryWPF.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace EmployeeDirectoryWPF.ViewModel;

public class EmployeeViewModel : BindableBase
{
    private ObservableCollection<Employee> _employees;
    private Employee _selectedEmployee;

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

    public EmployeeViewModel()
    {
        AddCommand = new DelegateCommand(AddEmployee);
        //UpdateCommand = new DelegateCommand(UpdateEmployee, CanUpdateEmployee);
        //DeleteCommand = new DelegateCommand(DeleteEmployee, CanDeleteEmployee);

        // Отримання списку працівників з бази даних під час створення ViewModel
        LoadEmployees();
    }

    private void LoadEmployees()
    {
        // Логіка для завантаження списку працівників з бази даних
        // Встановлення значення Employees
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
