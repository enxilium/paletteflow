using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using paletteflow.ViewModels;

namespace paletteflow.Stores
{
    public class NavigationStore
    {
        private ViewModelBase? _currentViewModel;
        public ViewModelBase? CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        // When setter is called, the method OnCurrentViewModelChanged() invokes the CurrentViewModelChanged action, which MainViewModel then receives and sends a signal to the GUI
        // using OnPropertyChanged(CurrentViewModel). In this way, the backend NavigationStore is able to communicate with the front-end GUI, using the view model as an intermediary.

        public event Action? CurrentViewModelChanged;
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
