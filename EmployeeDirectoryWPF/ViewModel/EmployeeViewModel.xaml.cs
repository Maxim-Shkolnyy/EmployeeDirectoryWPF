using Caliburn.Micro;
using EmployeeDirectoryWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeeDirectoryWPF.ViewModel
{
    /// <summary>
    /// Interaction logic for EmployeeViewModel.xaml
    /// </summary>
    public partial class EmployeeViewModel : Window
    {
        public BindableCollection<Employee> EmployeeModels { get; set; } 
        public EmployeeViewModel()
        {
            InitializeComponent();
        }
    }
}
