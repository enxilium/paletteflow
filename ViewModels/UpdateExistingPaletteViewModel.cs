using paletteflow.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using paletteflow.Models;
using paletteflow.Services;
using paletteflow.Stores;
using System.Windows;
using System.Windows.Media;
using Xceed.Wpf.Toolkit;
using Color = System.Windows.Media.Color;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;
using paletteflow.Views;
using ColorConverter = System.Windows.Media.ColorConverter;

namespace paletteflow.ViewModels
{
    public class UpdateExistingPaletteViewModel : ViewModelBase
    {
        public ICommand? BackCommand { get; }

        public ICommand? OpenUpdateDialog { get; }

        public ICommand? DeletePaletteCommand { get; }

        private readonly NavigationStore _navigationStore;

        private String _paletteName;
        public String PaletteName
        {
            get => _paletteName;
            set
            {
                _paletteName = value;
                OnPropertyChanged(nameof(PaletteName));
            }
        }

        private Palette _palette;
        public Palette Palette
        {
            get => _palette;
            set
            {
                _palette = value;
                OnPropertyChanged(nameof(Palette));
            }
        }

        private Color _color1;

        public Color Color1
        {
            get => _color1;
            set
            {
                _color1 = value;
                OnPropertyChanged(nameof(Color1));
                OnColorPicker1Changed();
            }
        }

        private SolidColorBrush _color1Brush;

        public SolidColorBrush Color1Brush
        {
            get => _color1Brush;
            set
            {
                _color1Brush = value;
                OnPropertyChanged(nameof(Color1Brush));
            }
        }

        private String _color1Hex;

        public String Color1Hex
        {
            get => _color1Hex;
            set
            {
                _color1Hex = value;
                OnPropertyChanged(nameof(Color1Hex));
            }
        }

        private void OnColorPicker1Changed()
        {
            Color1Brush = new SolidColorBrush(Color1);
            Color1Hex = Color1.ToString();
            Palette.Colors[0] = Color1;
        }

        // Color 2

        private Color _color2;

        public Color Color2
        {
            get => _color2;
            set
            {
                _color2 = value;
                OnPropertyChanged(nameof(Color2));
                OnColorPicker2Changed();
            }
        }

        private SolidColorBrush _color2Brush;

        public SolidColorBrush Color2Brush
        {
            get => _color2Brush;
            set
            {
                _color2Brush = value;
                OnPropertyChanged(nameof(Color2Brush));
            }
        }

        private String _color2Hex;

        public String Color2Hex
        {
            get => _color2Hex;
            set
            {
                _color2Hex = value;
                OnPropertyChanged(nameof(Color2Hex));
            }
        }

        private void OnColorPicker2Changed()
        {
            Color2Brush = new SolidColorBrush(Color2);
            Color2Hex = Color2.ToString();
            Palette.Colors[1] = Color2;
        }

        // Color 3

        private Color _color3;

        public Color Color3
        {
            get => _color3;
            set
            {
                _color3 = value;
                OnPropertyChanged(nameof(Color3));
                OnColorPicker3Changed();
            }
        }

        private SolidColorBrush _color3Brush;
        public SolidColorBrush Color3Brush
        {
            get => _color3Brush;
            set
            {
                _color3Brush = value;
                OnPropertyChanged(nameof(Color3Brush));
            }
        }

        private String _color3Hex;
        public String Color3Hex
        {
            get => _color3Hex;
            set
            {
                _color3Hex = value;
                OnPropertyChanged(nameof(Color3Hex));
            }
        }

        private void OnColorPicker3Changed()
        {
            Color3Brush = new SolidColorBrush(Color3);
            Color3Hex = Color3.ToString();
            Palette.Colors[2] = Color3;
        }

        // Color 4

        private Color _color4;
        public Color Color4
        {
            get => _color4;
            set
            {
                _color4 = value;
                OnPropertyChanged(nameof(Color4));
                OnColorPicker4Changed();
            }
        }

        private SolidColorBrush _color4Brush;
        public SolidColorBrush Color4Brush
        {
            get => _color4Brush;
            set
            {
                _color4Brush = value;
                OnPropertyChanged(nameof(Color4Brush));
            }
        }

        private String _color4Hex;

        public String Color4Hex
        {
            get => _color4Hex;
            set
            {
                _color4Hex = value;
                OnPropertyChanged(nameof(Color4Hex));
            }
        }

        private void OnColorPicker4Changed()
        {
            Color4Brush = new SolidColorBrush(Color4);
            Color4Hex = Color4.ToString();
            Palette.Colors[3] = Color4;
        }

        // Color 5

        private Color _color5;
        public Color Color5
        {
            get => _color5;
            set
            {
                _color5 = value;
                OnPropertyChanged(nameof(Color5));
                OnColorPicker5Changed();
            }
        }

        private SolidColorBrush _color5Brush;
        public SolidColorBrush Color5Brush
        {
            get => _color5Brush;
            set
            {
                _color5Brush = value;
                OnPropertyChanged(nameof(Color5Brush));
            }
        }

        private String _color5Hex;
        public String Color5Hex
        {
            get => _color5Hex;
            set
            {
                _color5Hex = value;
                OnPropertyChanged(nameof(Color5Hex));
            }
        }

        private void OnColorPicker5Changed()
        {
            Color5Brush = new SolidColorBrush(Color5);
            Color5Hex = Color5.ToString();
            Palette.Colors[4] = Color5;
        }

        // Color 6

        private Color _color6;
        public Color Color6
        {
            get => _color6;
            set
            {
                _color6 = value;
                OnPropertyChanged(nameof(Color6));
                OnColorPicker6Changed();
            }
        }

        private SolidColorBrush _color6Brush;
        public SolidColorBrush Color6Brush
        {
            get => _color6Brush;
            set
            {
                _color6Brush = value;
                OnPropertyChanged(nameof(Color6Brush));
            }
        }

        private String _color6Hex;
        public String Color6Hex
        {
            get => _color6Hex;
            set
            {
                _color6Hex = value;
                OnPropertyChanged(nameof(Color6Hex));
            }
        }

        private void OnColorPicker6Changed()
        {
            Color6Brush = new SolidColorBrush(Color6);
            Color6Hex = Color6.ToString();
            Palette.Colors[5] = Color6;
        }

        public UpdateExistingPaletteViewModel(Palette palette, NavigationStore navigationStore, NavigationService navigationService)
        {
            _navigationStore = navigationStore;
            BackCommand = new NavigateCommand(navigationService);
            _palette = palette;
            PaletteName = palette.Name;

            _color1 = palette.Colors[0];
            _color2 = palette.Colors[1];
            _color3 = palette.Colors[2];
            _color4 = palette.Colors[3];
            _color5 = palette.Colors[4];
            _color6 = palette.Colors[5];

            Color1Brush = new SolidColorBrush(Color1);
            Color2Brush = new SolidColorBrush(Color2);
            Color3Brush = new SolidColorBrush(Color3);
            Color4Brush = new SolidColorBrush(Color4);
            Color5Brush = new SolidColorBrush(Color5);
            Color6Brush = new SolidColorBrush(Color6);

            Color1Hex = Color1.ToString();
            Color2Hex = Color2.ToString();
            Color3Hex = Color3.ToString();
            Color4Hex = Color4.ToString();
            Color5Hex = Color5.ToString();
            Color6Hex = Color6.ToString();

            OpenUpdateDialog = new OpenUpdateCommand(Palette, navigationService);
            DeletePaletteCommand = new DeletePaletteCommand(palette, navigationService);
        }
    }
}
