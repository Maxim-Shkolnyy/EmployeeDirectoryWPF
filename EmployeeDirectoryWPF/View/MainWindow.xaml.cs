using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeeDirectoryWPF.ViewModel
{
    public partial class MainWindow : Window
    {
        private EmployeeViewModel _viewModel;

        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new EmployeeViewModel();
            _viewModel.LoadEmployees();
            Employees = _viewModel.Employees;
            DataContext = this;
        }
    }
}