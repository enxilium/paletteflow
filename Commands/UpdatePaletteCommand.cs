using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using paletteflow.Models;
using paletteflow.Services;

namespace paletteflow.Commands
{
    public class UpdatePaletteCommand : CommandBase
    {
        private NavigationService _navigationService;
        private Palette _palette;
        private Window _window;
        public UpdatePaletteCommand(Window window, Palette palette, NavigationService navigationService, String paletteName)
        {
            _palette = palette;
            _navigationService = navigationService;
            _window = window;
        }
        public override void Execute(object? parameter)
        {
            FileService.UpdatePalette(_palette);
            MessageBox.Show("Palette saved!");

            _window.Close();
            _navigationService.Navigate();
        }

        public void UpdatePaletteName(string paletteName)
        {
            _palette.Name = paletteName;
        }
    }
}
