using paletteflow.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using paletteflow.Services;

namespace paletteflow.ViewModels
{
    public class AboutViewModel(NavigationService navigationService) : ViewModelBase
    {
        public ICommand? BackCommand { get; } = new NavigateCommand(navigationService);
    }
}
