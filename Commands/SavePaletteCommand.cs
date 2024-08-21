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
    public class SavePaletteCommand : CommandBase
    {
        private Window _window;
        private Palette _palette;
        public SavePaletteCommand(Window window, Palette palette, String paletteName)
        {
            _window = window;
            _palette = new Palette(palette, paletteName);
        }
        public override void Execute(object? parameter)
        {
            if (_palette.Name.Length > 16)
            {
                MessageBox.Show("Palette name must be 16 characters or less. Please re-enter.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var palettes = FileService.LoadPalettes();
                if (palettes.Count < 8)
                {
                    palettes.Add(_palette);
                    FileService.SavePalettes(palettes);
                }
                else
                {
                    MessageBox.Show("You can only store up to 8 palettes.");
                }
                _window.Close();
            }
        }
        public void UpdatePaletteName(string paletteName)
        {
            _palette.Name = paletteName;
        }
    }
}
