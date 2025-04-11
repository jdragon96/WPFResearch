using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Research.Control
{
    public interface IResultCommand<T> : ICommand
    {
        new bool Execute(T parameter);
    }

    public class ValidationCommand<T> : IResultCommand<T>
    {
        private readonly Func<T, bool> _Execute;

        public ValidationCommand(Func<T, bool> canExecute = null)
        {
            _Execute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _Execute == null || _Execute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _Execute((T)parameter);
        }

        public bool Execute(T parameter)
        {
            return _Execute((T)parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
