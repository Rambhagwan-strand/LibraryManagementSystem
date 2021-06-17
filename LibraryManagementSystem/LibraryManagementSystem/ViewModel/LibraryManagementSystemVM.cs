using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.ViewModel
{
    class LibraryManagementSystemVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Book> Books { get; set; }

        


        private string _sarchedText;

        public string SarchedText
        {
            get { return _sarchedText; }
            set { 
                _sarchedText = value;
                OnPropertyChanged();
            }
        }

        public LibraryManagementSystemVM()
        {
            Books = new ObservableCollection<Book>();
            Books.Add(new Book("A!", "SS", "VV"));
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
