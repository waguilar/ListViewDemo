using ListViewDemo.Model;
using ListViewDemo.Service;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListViewDemo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            
        }

        public Task Initialize()
        {
            BookList = RepositoryService.GetBooks();
            return Task.CompletedTask;
        }

        private ObservableCollection<Book> bookList;
        public ObservableCollection<Book> BookList
        {
            get => bookList;
            set
            {
                bookList = value;
                OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
