using OOO_debili.Models;
using ReactiveUI;
using System.Collections.ObjectModel;

namespace OOO_debili.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Flight> _flights;
        public ObservableCollection<Flight> Flights
        {
            get => _flights;
            set => this.RaiseAndSetIfChanged(ref _flights, value);
        }
        private User user { get; set; }
        public MainWindowViewModel() { }
        public MainWindowViewModel(User user)
        {
            this.user = user;
        }
    }
}