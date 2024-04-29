using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using EmployeeDirectoryWPF.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeeDirectoryWPF.ViewModel
{
    public partial class MainWindow : Window
    {
        private EmployeeViewModel _viewModel;
        private AddWindow _addUserWindow;


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
            _addUserWindow = new AddWindow();
            _addUserWindow.Owner = this;
            //this.DialogResult = true;
            _addUserWindow.Show();
        }
    }
}