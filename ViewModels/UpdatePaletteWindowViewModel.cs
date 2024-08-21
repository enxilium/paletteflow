using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using paletteflow.Commands;
using paletteflow.Models;
using paletteflow.Services;
using Color = System.Windows.Media.Color;

namespace paletteflow.ViewModels
{
    public class UpdatePaletteWindowViewModel : ViewModelBase
    {
        public UpdatePaletteCommand UpdateCommand { get; }
        private String _paletteName;
        public String PaletteName
        {
            get => _paletteName;
            set
            {
                _paletteName = value;
                OnPropertyChanged(nameof(PaletteName));
                UpdateCommand.UpdatePaletteName(_paletteName);
            }
        }
        public UpdatePaletteWindowViewModel(Window window, Palette palette, NavigationService navigationService)
        {
            UpdateCommand = new UpdatePaletteCommand(window, palette, navigationService, _paletteName);
        }
    }
}
