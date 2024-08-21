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
    public class OpenWindowCommand : CommandBase
    {
        Window _window;
        SavePaletteWindowViewModel _savePaletteWindowViewModel;
        private Palette _palette;

        public OpenWindowCommand(Palette palette)
        {
            _palette = palette;
        }

        public override void Execute(object? parameter)
        {
            _window = new SavePaletteWindow();

            _savePaletteWindowViewModel = new SavePaletteWindowViewModel(_window, _palette);

            _window.DataContext = _savePaletteWindowViewModel;

            _window.Show();
        }
    }
}