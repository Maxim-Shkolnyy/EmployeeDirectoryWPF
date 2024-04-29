using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using EmployeeDirectoryWPF.View;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeDirectoryWPF.ViewModel
{
    public partial class MainWindow : Window
    {
        private EmployeeViewModel _viewModel;
        private AddWindow _addUserWindow;
        private Employee _selectedEmployee;



        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new EmployeeViewModel();
            _viewModel.LoadEmployees();
            Employees = _viewModel.Employees;
            DataContext = this;
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.4;

            _addUserWindow = new AddWindow();
            _addUserWindow.Owner = this;
            _addUserWindow.Closed += AddWindowClosed;
            _addUserWindow.ShowDialog();
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            if (_selectedEmployee != null)
            {
                int employeeId = _selectedEmployee.Id;
                EditEmployee(employeeId);
            }
            else
            {
            }
        }

        private void EditEmployee(int employeeId)
        {
            // Виконайте редагування співробітника з використанням його ID
            // Тут ви можете викликати відповідний метод для редагування співробітника у вашому ViewModel
        }

        private void DataGridSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Отримуємо вибраний об'єкт Employee
            if (sender is DataGrid dataGrid)
            {
                _selectedEmployee = dataGrid.SelectedItem as Employee;
            }
        }

        private void AddWindowClosed(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}