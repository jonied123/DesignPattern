using _01_MVVM.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MVVM.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            this.ClearCommand = new DelegateCommand(
                (o) => !String.IsNullOrEmpty(Firstname) || !String.IsNullOrEmpty(Lastname),
                (o) => { this.Firstname = ""; this.Lastname = ""; }
            );
            Firstname = "Dave";
            Lastname = "Dev";
        }

        public DelegateCommand ClearCommand { get; set; }
        private string firstname;
        private string lastname;

        public string Firstname
        {
            get => firstname;
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Firstname)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Fullname)));
                    this.ClearCommand.RaisCanExecuteChanged();
                }
            }
        }
        public string Lastname
        {
            get => lastname;
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Lastname)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Fullname)));
                    this.ClearCommand.RaisCanExecuteChanged();
                }
            }
        }
        public string Fullname => $"{Firstname} {Lastname}";

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
