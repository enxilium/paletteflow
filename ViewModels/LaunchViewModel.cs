using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using paletteflow.Commands;
using paletteflow.Services;
using paletteflow.Stores;

namespace paletteflow.ViewModels
{
    public class LaunchViewModel : ViewModelBase 
    {
        public ICommand? EnterCommand { get; }

        public LaunchViewModel(NavigationService navigationService)
        {
            EnterCommand = new NavigateCommand(navigationService);
        }
    }
}
