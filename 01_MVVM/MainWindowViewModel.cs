using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MVVM
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
                if(firstname != value)
                {
                    firstname = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Firstname)));
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Fullname)));
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
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Lastname)));
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Fullname)));
                }
            }
        }
        public string Fullname => $"{Firstname} {Lastname}";

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
