using paletteflow.Commands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using paletteflow.Models;
using paletteflow.Services;
using Color = System.Windows.Media.Color;
using System.Windows.Media;
using paletteflow.Stores;

namespace paletteflow.ViewModels
{
    public class SavedPaletteViewModel : ViewModelBase
    {
        public ICommand? BackCommand { get; }
        public ICommand? OpenPalette1 { get; }
        public ICommand? OpenPalette2 { get; }
        public ICommand? OpenPalette3 { get; }
        public ICommand? OpenPalette4 { get; }
        public ICommand? OpenPalette5 { get; }
        public ICommand? OpenPalette6 { get; }
        public ICommand? OpenPalette7 { get; }
        public ICommand? OpenPalette8 { get; }
        private NavigationStore _navigationStore;

        private NavigationService _navigationService;

        private List<Palette> _savedPalettes;
        public string PaletteName1 { get; }
        public Color Palette1Color1 { get; }
        public Color Palette1Color2 { get; }
        public Color Palette1Color3 { get; }
        public Color Palette1Color4 { get; }
        public Color Palette1Color5 { get; }
        public Color Palette1Color6 { get; }

        public string PaletteName2 { get; }
        public Color Palette2Color1 { get; }
        public Color Palette2Color2 { get; }
        public Color Palette2Color3 { get; }
        public Color Palette2Color4 { get; }
        public Color Palette2Color5 { get; }
        public Color Palette2Color6 { get; }

        public string PaletteName3 { get; }
        public Color Palette3Color1 { get; }
        public Color Palette3Color2 { get; }
        public Color Palette3Color3 { get; }
        public Color Palette3Color4 { get; }
        public Color Palette3Color5 { get; }
        public Color Palette3Color6 { get; }

        public string PaletteName4 { get; }
        public Color Palette4Color1 { get; }
        public Color Palette4Color2 { get; }
        public Color Palette4Color3 { get; }
        public Color Palette4Color4 { get; }
        public Color Palette4Color5 { get; }
        public Color Palette4Color6 { get; }

        public string PaletteName5 { get; }
        public Color Palette5Color1 { get; }
        public Color Palette5Color2 { get; }
        public Color Palette5Color3 { get; }
        public Color Palette5Color4 { get; }
        public Color Palette5Color5 { get; }
        public Color Palette5Color6 { get; }

        public string PaletteName6 { get; }
        public Color Palette6Color1 { get; }
        public Color Palette6Color2 { get; }
        public Color Palette6Color3 { get; }
        public Color Palette6Color4 { get; }
        public Color Palette6Color5 { get; }
        public Color Palette6Color6 { get; }

        public string PaletteName7 { get; }
        public Color Palette7Color1 { get; }
        public Color Palette7Color2 { get; }
        public Color Palette7Color3 { get; }
        public Color Palette7Color4 { get; }
        public Color Palette7Color5 { get; }
        public Color Palette7Color6 { get; }

        public string PaletteName8 { get; }
        public Color Palette8Color1 { get; }
        public Color Palette8Color2 { get; }
        public Color Palette8Color3 { get; }
        public Color Palette8Color4 { get; }
        public Color Palette8Color5 { get; }
        public Color Palette8Color6 { get; }

        public SolidColorBrush Palette1Color1Brush => new SolidColorBrush(Palette1Color1);
        public SolidColorBrush Palette1Color2Brush => new SolidColorBrush(Palette1Color2);
        public SolidColorBrush Palette1Color3Brush => new SolidColorBrush(Palette1Color3);
        public SolidColorBrush Palette1Color4Brush => new SolidColorBrush(Palette1Color4);
        public SolidColorBrush Palette1Color5Brush => new SolidColorBrush(Palette1Color5);
        public SolidColorBrush Palette1Color6Brush => new SolidColorBrush(Palette1Color6);

        public SolidColorBrush Palette2Color1Brush => new SolidColorBrush(Palette2Color1);
        public SolidColorBrush Palette2Color2Brush => new SolidColorBrush(Palette2Color2);
        public SolidColorBrush Palette2Color3Brush => new SolidColorBrush(Palette2Color3);
        public SolidColorBrush Palette2Color4Brush => new SolidColorBrush(Palette2Color4);
        public SolidColorBrush Palette2Color5Brush => new SolidColorBrush(Palette2Color5);
        public SolidColorBrush Palette2Color6Brush => new SolidColorBrush(Palette2Color6);

        public SolidColorBrush Palette3Color1Brush => new SolidColorBrush(Palette3Color1);
        public SolidColorBrush Palette3Color2Brush => new SolidColorBrush(Palette3Color2);
        public SolidColorBrush Palette3Color3Brush => new SolidColorBrush(Palette3Color3);
        public SolidColorBrush Palette3Color4Brush => new SolidColorBrush(Palette3Color4);
        public SolidColorBrush Palette3Color5Brush => new SolidColorBrush(Palette3Color5);
        public SolidColorBrush Palette3Color6Brush => new SolidColorBrush(Palette3Color6);

        public SolidColorBrush Palette4Color1Brush => new SolidColorBrush(Palette4Color1);
        public SolidColorBrush Palette4Color2Brush => new SolidColorBrush(Palette4Color2);
        public SolidColorBrush Palette4Color3Brush => new SolidColorBrush(Palette4Color3);
        public SolidColorBrush Palette4Color4Brush => new SolidColorBrush(Palette4Color4);
        public SolidColorBrush Palette4Color5Brush => new SolidColorBrush(Palette4Color5);
        public SolidColorBrush Palette4Color6Brush => new SolidColorBrush(Palette4Color6);

        public SolidColorBrush Palette5Color1Brush => new SolidColorBrush(Palette5Color1);
        public SolidColorBrush Palette5Color2Brush => new SolidColorBrush(Palette5Color2);
        public SolidColorBrush Palette5Color3Brush => new SolidColorBrush(Palette5Color3);
        public SolidColorBrush Palette5Color4Brush => new SolidColorBrush(Palette5Color4);
        public SolidColorBrush Palette5Color5Brush => new SolidColorBrush(Palette5Color5);
        public SolidColorBrush Palette5Color6Brush => new SolidColorBrush(Palette5Color6);

        public SolidColorBrush Palette6Color1Brush => new SolidColorBrush(Palette6Color1);
        public SolidColorBrush Palette6Color2Brush => new SolidColorBrush(Palette6Color2);
        public SolidColorBrush Palette6Color3Brush => new SolidColorBrush(Palette6Color3);
        public SolidColorBrush Palette6Color4Brush => new SolidColorBrush(Palette6Color4);
        public SolidColorBrush Palette6Color5Brush => new SolidColorBrush(Palette6Color5);
        public SolidColorBrush Palette6Color6Brush => new SolidColorBrush(Palette6Color6);

        public SolidColorBrush Palette7Color1Brush => new SolidColorBrush(Palette7Color1);
        public SolidColorBrush Palette7Color2Brush => new SolidColorBrush(Palette7Color2);
        public SolidColorBrush Palette7Color3Brush => new SolidColorBrush(Palette7Color3);
        public SolidColorBrush Palette7Color4Brush => new SolidColorBrush(Palette7Color4);
        public SolidColorBrush Palette7Color5Brush => new SolidColorBrush(Palette7Color5);
        public SolidColorBrush Palette7Color6Brush => new SolidColorBrush(Palette7Color6);

        public SolidColorBrush Palette8Color1Brush => new SolidColorBrush(Palette8Color1);
        public SolidColorBrush Palette8Color2Brush => new SolidColorBrush(Palette8Color2);
        public SolidColorBrush Palette8Color3Brush => new SolidColorBrush(Palette8Color3);
        public SolidColorBrush Palette8Color4Brush => new SolidColorBrush(Palette8Color4);
        public SolidColorBrush Palette8Color5Brush => new SolidColorBrush(Palette8Color5);
        public SolidColorBrush Palette8Color6Brush => new SolidColorBrush(Palette8Color6);


        public SavedPaletteViewModel(NavigationStore navigationStore, NavigationService navigationService, List<Palette> savedPalettes)
        {
            BackCommand = new NavigateCommand(navigationService);

            _navigationStore = navigationStore;

            _navigationService = navigationService;

            OpenPalette1 = savedPalettes.Count > 0 && savedPalettes[0].Colors.Any() ? new NavigateCommand(new NavigationService(_navigationStore, CreateUpdateExistingPalette1ViewModel)) : null;
            OpenPalette2 = savedPalettes.Count > 1 && savedPalettes[1].Colors.Any() ? new NavigateCommand(new NavigationService(_navigationStore, CreateUpdateExistingPalette2ViewModel)) : null;
            OpenPalette3 = savedPalettes.Count > 2 && savedPalettes[2].Colors.Any() ? new NavigateCommand(new NavigationService(_navigationStore, CreateUpdateExistingPalette3ViewModel)) : null;
            OpenPalette4 = savedPalettes.Count > 3 && savedPalettes[3].Colors.Any() ? new NavigateCommand(new NavigationService(_navigationStore, CreateUpdateExistingPalette4ViewModel)) : null;
            OpenPalette5 = savedPalettes.Count > 4 && savedPalettes[4].Colors.Any() ? new NavigateCommand(new NavigationService(_navigationStore, CreateUpdateExistingPalette5ViewModel)) : null;
            OpenPalette6 = savedPalettes.Count > 5 && savedPalettes[5].Colors.Any() ? new NavigateCommand(new NavigationService(_navigationStore, CreateUpdateExistingPalette6ViewModel)) : null;
            OpenPalette7 = savedPalettes.Count > 6 && savedPalettes[6].Colors.Any() ? new NavigateCommand(new NavigationService(_navigationStore, CreateUpdateExistingPalette7ViewModel)) : null;
            OpenPalette8 = savedPalettes.Count > 7 && savedPalettes[7].Colors.Any() ? new NavigateCommand(new NavigationService(_navigationStore, CreateUpdateExistingPalette8ViewModel)) : null;

            _savedPalettes = savedPalettes;

            PaletteName1 = savedPalettes.Count > 0 ? savedPalettes[0].Name : "Empty!";
            Palette1Color1 = savedPalettes.Count > 0 ? savedPalettes[0].Colors[0] : default;
            Palette1Color2 = savedPalettes.Count > 0 ? savedPalettes[0].Colors[1] : default;
            Palette1Color3 = savedPalettes.Count > 0 ? savedPalettes[0].Colors[2] : default;
            Palette1Color4 = savedPalettes.Count > 0 ? savedPalettes[0].Colors[3] : default;
            Palette1Color5 = savedPalettes.Count > 0 ? savedPalettes[0].Colors[4] : default;
            Palette1Color6 = savedPalettes.Count > 0 ? savedPalettes[0].Colors[5] : default;

            PaletteName2 = savedPalettes.Count > 1 ? savedPalettes[1].Name : "Empty!";
            Palette2Color1 = savedPalettes.Count > 1 ? savedPalettes[1].Colors[0] : default;
            Palette2Color2 = savedPalettes.Count > 1 ? savedPalettes[1].Colors[1] : default;
            Palette2Color3 = savedPalettes.Count > 1 ? savedPalettes[1].Colors[2] : default;
            Palette2Color4 = savedPalettes.Count > 1 ? savedPalettes[1].Colors[3] : default;
            Palette2Color5 = savedPalettes.Count > 1 ? savedPalettes[1].Colors[4] : default;
            Palette2Color6 = savedPalettes.Count > 1 ? savedPalettes[1].Colors[5] : default;

            PaletteName3 = savedPalettes.Count > 2 ? savedPalettes[2].Name : "Empty!";
            Palette3Color1 = savedPalettes.Count > 2 ? savedPalettes[2].Colors[0] : default;
            Palette3Color2 = savedPalettes.Count > 2 ? savedPalettes[2].Colors[1] : default;
            Palette3Color3 = savedPalettes.Count > 2 ? savedPalettes[2].Colors[2] : default;
            Palette3Color4 = savedPalettes.Count > 2 ? savedPalettes[2].Colors[3] : default;
            Palette3Color5 = savedPalettes.Count > 2 ? savedPalettes[2].Colors[4] : default;
            Palette3Color6 = savedPalettes.Count > 2 ? savedPalettes[2].Colors[5] : default;

            PaletteName4 = savedPalettes.Count > 3 ? savedPalettes[3].Name : "Empty!";
            Palette4Color1 = savedPalettes.Count > 3 ? savedPalettes[3].Colors[0] : default;
            Palette4Color2 = savedPalettes.Count > 3 ? savedPalettes[3].Colors[1] : default;
            Palette4Color3 = savedPalettes.Count > 3 ? savedPalettes[3].Colors[2] : default;
            Palette4Color4 = savedPalettes.Count > 3 ? savedPalettes[3].Colors[3] : default;
            Palette4Color5 = savedPalettes.Count > 3 ? savedPalettes[3].Colors[4] : default;
            Palette4Color6 = savedPalettes.Count > 3 ? savedPalettes[3].Colors[5] : default;

            PaletteName5 = savedPalettes.Count > 4 ? savedPalettes[4].Name : "Empty!";
            Palette5Color1 = savedPalettes.Count > 4 ? savedPalettes[4].Colors[0] : default;
            Palette5Color2 = savedPalettes.Count > 4 ? savedPalettes[4].Colors[1] : default;
            Palette5Color3 = savedPalettes.Count > 4 ? savedPalettes[4].Colors[2] : default;
            Palette5Color4 = savedPalettes.Count > 4 ? savedPalettes[4].Colors[3] : default;
            Palette5Color5 = savedPalettes.Count > 4 ? savedPalettes[4].Colors[4] : default;
            Palette5Color6 = savedPalettes.Count > 4 ? savedPalettes[4].Colors[5] : default;

            PaletteName6 = savedPalettes.Count > 5 ? savedPalettes[5].Name : "Empty!";
            Palette6Color1 = savedPalettes.Count > 5 ? savedPalettes[5].Colors[0] : default;
            Palette6Color2 = savedPalettes.Count > 5 ? savedPalettes[5].Colors[1] : default;
            Palette6Color3 = savedPalettes.Count > 5 ? savedPalettes[5].Colors[2] : default;
            Palette6Color4 = savedPalettes.Count > 5 ? savedPalettes[5].Colors[3] : default;
            Palette6Color5 = savedPalettes.Count > 5 ? savedPalettes[5].Colors[4] : default;
            Palette6Color6 = savedPalettes.Count > 5 ? savedPalettes[5].Colors[5] : default;

            PaletteName7 = savedPalettes.Count > 6 ? savedPalettes[6].Name : "Empty!";
            Palette7Color1 = savedPalettes.Count > 6 ? savedPalettes[6].Colors[0] : default;
            Palette7Color2 = savedPalettes.Count > 6 ? savedPalettes[6].Colors[1] : default;
            Palette7Color3 = savedPalettes.Count > 6 ? savedPalettes[6].Colors[2] : default;
            Palette7Color4 = savedPalettes.Count > 6 ? savedPalettes[6].Colors[3] : default;
            Palette7Color5 = savedPalettes.Count > 6 ? savedPalettes[6].Colors[4] : default;
            Palette7Color6 = savedPalettes.Count > 6 ? savedPalettes[6].Colors[5] : default;

            PaletteName8 = savedPalettes.Count > 7 ? savedPalettes[7].Name : "Empty!";
            Palette8Color1 = savedPalettes.Count > 7 ? savedPalettes[7].Colors[0] : default;
            Palette8Color2 = savedPalettes.Count > 7 ? savedPalettes[7].Colors[1] : default;
            Palette8Color3 = savedPalettes.Count > 7 ? savedPalettes[7].Colors[2] : default;
            Palette8Color4 = savedPalettes.Count > 7 ? savedPalettes[7].Colors[3] : default;
            Palette8Color5 = savedPalettes.Count > 7 ? savedPalettes[7].Colors[4] : default;
            Palette8Color6 = savedPalettes.Count > 7 ? savedPalettes[7].Colors[5] : default;
        }

        private ViewModelBase CreateUpdateExistingPalette1ViewModel()
        {
            return new UpdateExistingPaletteViewModel(_savedPalettes[0], _navigationStore, new NavigationService(_navigationStore, CreateSavedPaletteViewModel));
        }

        private ViewModelBase CreateUpdateExistingPalette2ViewModel()
        {
            return new UpdateExistingPaletteViewModel(_savedPalettes[1], _navigationStore, new NavigationService(_navigationStore, CreateSavedPaletteViewModel));
        }

        private ViewModelBase CreateUpdateExistingPalette3ViewModel()
        {
            return new UpdateExistingPaletteViewModel(_savedPalettes[2], _navigationStore, new NavigationService(_navigationStore, CreateSavedPaletteViewModel));
        }

        private ViewModelBase CreateUpdateExistingPalette4ViewModel()
        {
            return new UpdateExistingPaletteViewModel(_savedPalettes[3], _navigationStore, new NavigationService(_navigationStore, CreateSavedPaletteViewModel));
        }

        private ViewModelBase CreateUpdateExistingPalette5ViewModel()
        {
            return new UpdateExistingPaletteViewModel(_savedPalettes[4], _navigationStore, new NavigationService(_navigationStore, CreateSavedPaletteViewModel));
        }

        private ViewModelBase CreateUpdateExistingPalette6ViewModel()
        {
            return new UpdateExistingPaletteViewModel(_savedPalettes[5], _navigationStore, new NavigationService(_navigationStore, CreateSavedPaletteViewModel));
        }

        private ViewModelBase CreateUpdateExistingPalette7ViewModel()
        {
            return new UpdateExistingPaletteViewModel(_savedPalettes[6], _navigationStore, new NavigationService(_navigationStore, CreateSavedPaletteViewModel));
        }

        private ViewModelBase CreateUpdateExistingPalette8ViewModel()
        {
            return new UpdateExistingPaletteViewModel(_savedPalettes[7], _navigationStore, new NavigationService(_navigationStore, CreateSavedPaletteViewModel));
        }

        private ViewModelBase CreateSavedPaletteViewModel()
        {
            _savedPalettes = FileService.LoadPalettes();
            return new SavedPaletteViewModel(_navigationStore, _navigationService, _savedPalettes);
        }
    }
}
