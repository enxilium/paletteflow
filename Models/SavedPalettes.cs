using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paletteflow.Models
{
    internal class SavedPalettes
    {
        private List<Palette> _palettes;

        public required List<Palette> Palettes { get; set; }

        public SavedPalettes(List<Palette> palettes)
        {
            _palettes = palettes;
        }
    }
}
