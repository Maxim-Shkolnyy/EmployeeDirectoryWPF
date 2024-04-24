using EmployeeDirectoryWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace EmployeeDirectoryWPF.ViewModel
{
    internal class EmployeeViewModel : DependencyObject
    {
        public string Filter
        {
            get { return (string)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterProperty =
            DependencyProperty.Register("FilterProperty", typeof(string), typeof(EmployeeViewModel), new PropertyMetadata(""));



        public ICollectionView Employee
        {
            get { return (ICollectionView)GetValue(EmployeeProrerty); }
            set { SetValue(EmployeeProrerty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeProrerty =
            DependencyProperty.Register("Employee", typeof(ICollectionView), typeof(EmployeeViewModel), new PropertyMetadata(null));

        public EmployeeViewModel()
        {
            List<Employee> employees = new List<Employee>();
            Employee = CollectionViewSource.GetDefaultView(employees);
        }



    }
}
