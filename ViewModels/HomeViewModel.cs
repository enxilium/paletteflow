using paletteflow.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using paletteflow.Services;

namespace paletteflow.ViewModels
{
    public class HomeViewModel(
        NavigationService navigationService1,
        NavigationService navigationService2,
        NavigationService navigationService3,
        NavigationService navigationService4,
        NavigationService navigationService5)
        : ViewModelBase
    {
        public ICommand? SavedPalettesNavigateCommand { get; } = new NavigateCommand(navigationService1);
        public ICommand? NewPaletteNavigateCommand { get; } = new NavigateCommand(navigationService2);
        public ICommand? InformationNavigateCommand { get; } = new NavigateCommand(navigationService3);
        public ICommand? AboutNavigateCommand { get; } = new NavigateCommand(navigationService4);
        public ICommand? ContactNavigateCommand { get; } = new NavigateCommand(navigationService5);
    }
}
