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
            Firstname = "Hans";
            Lastname = "Wurst";
        }
        private string firstname;
        public string Firstname
        {
            get => firstname;
            set 
            {
                if(firstname != value)
                {
                    firstname = value;
                    this.PropertyChanged?.Invoke(PropertyChanged)
                }
            }
        }
        public string Lastname { get; set; }  
        public string Fullname => $"{Firstname} {Lastname}";

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
