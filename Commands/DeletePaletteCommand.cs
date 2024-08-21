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
    public class DeletePaletteCommand : CommandBase
    {
        private Palette _palette;
        private NavigationService _navigationService;
        public DeletePaletteCommand(Palette palette, NavigationService navigationService)
        {
            _palette = palette;
            _navigationService = navigationService;
        }
        public override void Execute(object? parameter)
        {
            FileService.RemovePalette(_palette);

            MessageBox.Show("Palette deleted!");

            _navigationService.Navigate();
        }
    }
}
