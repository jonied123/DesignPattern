using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _01_MVVM.ViewModel.Commands
{
    //Kann auch RelayCommand in anderen Libarys genannt werden
    public class DelegateCommand : ICommand
    {
        public Action<object> execute;
        public Predicate<object> canExecute;

        public DelegateCommand(Predicate<object> canExecute, Action<object> execute)
        {
            this.execute += execute;
            this.canExecute += canExecute;
        }

        public DelegateCommand(Action<object> execute) : this(null, execute) { }

        //Wird aufgerufen, wenn sich CanExecute ändern kann.
        public event EventHandler? CanExecuteChanged;

        public void RaisCanExecuteChanged() => this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);


        public bool CanExecute(object? parameter) => canExecute?.Invoke(parameter) ?? true;

        public void Execute(object? parameter) => execute?.Invoke(parameter);
        
    }
}
