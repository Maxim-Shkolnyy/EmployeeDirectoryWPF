using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;
using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeeDirectoryWPF.ViewModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeViewModel _viewModel;

        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindow()
        {
            InitializeComponent();            
        }
    }
}