using EmployeeDirectoryWPF.ViewModels;
using System.Windows;

namespace EmployeeDirectoryWPF.Views
{
    /// <summary>
    /// Interaction logic for Counter.xaml
    /// </summary>
    public partial class Counter : Window
    {
        public Counter()
        {
            InitializeComponent();
            DataContext = new CounterViewModel();
        }
    }
}
