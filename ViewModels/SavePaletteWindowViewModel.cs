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
using Color = System.Windows.Media.Color;

namespace paletteflow.ViewModels
{
    public class SavePaletteWindowViewModel : ViewModelBase
    {
        public SavePaletteCommand SaveCommand { get; }
        private String _paletteName;
        public String PaletteName
        {
            get => _paletteName;
            set
            {
                _paletteName = value;
                OnPropertyChanged(nameof(PaletteName));
                SaveCommand.UpdatePaletteName(_paletteName);
            }
        }
        public SavePaletteWindowViewModel(Window window, Palette palette)
        {
            SaveCommand = new SavePaletteCommand(window, palette, _paletteName);
        }
    }
}
