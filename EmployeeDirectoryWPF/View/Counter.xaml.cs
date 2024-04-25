using EmployeeDirectoryWPF.ViewModel;
using System.Windows;

namespace EmployeeDirectoryWPF.View
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
