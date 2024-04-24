using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectoryWPF.ViewModel
{
    internal class CounterViewModel : BindableBase
    {
        private int _counter;

        public int Counter
        {
            get => _counter;
            set => SetProperty(ref _counter, value);
        }

        public DelegateCommand IncrementCommand { get; }

        public CounterViewModel()
        {
            IncrementCommand = new DelegateCommand(Increment);
        }

        private void Increment()
        {
            Counter++;
        }
    }
}
