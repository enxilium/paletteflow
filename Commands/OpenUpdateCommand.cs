using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using paletteflow.Models;
using paletteflow.Services;
using paletteflow.Stores;
using paletteflow.ViewModels;
using paletteflow.Views;

namespace paletteflow.Commands
{
    public class OpenUpdateCommand : CommandBase
    {
        private Window _window;
        private UpdatePaletteWindowViewModel _updatePaletteWindowViewModel;
        private Palette _palette;
        private NavigationService _navigationService;

        public OpenUpdateCommand(Palette palette, NavigationService navigationService)
        {
            _palette = palette;
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _window = new UpdatePaletteWindow();

            _updatePaletteWindowViewModel = new UpdatePaletteWindowViewModel(_window, _palette, _navigationService);

            _window.DataContext = _updatePaletteWindowViewModel;

            _window.Show();
        }
    }
}