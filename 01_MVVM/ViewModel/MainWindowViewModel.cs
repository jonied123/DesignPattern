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
            Firstname = "Dave";
            Lastname = "Dev";
        }

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
                }
            }
        }
        public string Fullname => $"{Firstname} {Lastname}";

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
