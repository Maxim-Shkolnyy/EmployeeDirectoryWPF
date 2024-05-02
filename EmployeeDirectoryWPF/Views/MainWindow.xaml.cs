using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using EmployeeDirectoryWPF.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeDirectoryWPF.ViewModels
{
    public partial class MainWindow : Window
    {
        private EmployeeViewModel _viewModel;
        private AddWindow _addUserWindow;
        private EditWindow _editUserWindow;
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
            _addUserWindow.Closed += WindowClosed;
            _addUserWindow.ShowDialog();

        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            if (_selectedEmployee != null)
            {
                int employeeId = _selectedEmployee.Id;
                EditEmployee(employeeId);
            }            
        }

        private void EditEmployee(int employeeId)
        {
            this.Opacity = 0.4;

            _editUserWindow = new EditWindow();
            _editUserWindow.Owner = this;
            _editUserWindow.Closed += WindowClosed;
            _editUserWindow.ShowDialog(); 
        }

        private void DataGridSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is DataGrid dataGrid)
            {
                _selectedEmployee = dataGrid.SelectedItem as Employee;
            }
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }        
    }
}