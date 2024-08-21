using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Windows.Media;

namespace paletteflow.Models
{
    public class Palette
    {
        private List<Color> _colors;
        private string _name;

        public Guid Id { get; set; } // Add Id property

        public List<Color> Colors
        {
            get => _colors;
            set
            {
                _colors = value;
            }
        }

        public Palette(List<Color> colors)
        {
            Id = Guid.NewGuid(); // Initialize Id
            _colors = colors;
        }

        public Palette(Palette palette, string name)
        {
            Id = Guid.NewGuid(); // Initialize Id
            _colors = palette.Colors;
            _name = name;
        }

        [JsonConstructor]
        public Palette(List<Color> colors, string name, Guid id)
        {
            _colors = colors;
            _name = name;
            Id = id; // Initialize Id from JSON
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public static List<Color> GenerateNewPaletteColors(List<int> responses)
        {
            var color1 = Color.FromRgb(255, 0, 0);
            var color2 = Color.FromRgb(255, 255, 0);
            var color3 = Color.FromRgb(255, 0, 255);
            var color4 = Color.FromRgb(255, 100, 0);
            var color5 = Color.FromRgb(55, 50, 250);
            var color6 = Color.FromRgb(50, 200, 10);
            return new List<Color> { color1, color2, color3, color4, color5, color6 };
        }
    }
}