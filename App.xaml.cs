using System.Configuration;
using System.Data;
using System.Windows;
using paletteflow.ViewModels;
using paletteflow.Models;
using System;
using paletteflow.Services;
using paletteflow.Stores;

namespace paletteflow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private List<Palette> savedPalettes;

        public App()
        {
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateLaunchViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private LaunchViewModel CreateLaunchViewModel()
        {
            return new LaunchViewModel(new NavigationService(_navigationStore, CreateLoadingViewModel));
        }

        private LoadingViewModel CreateLoadingViewModel()
        {
            return new LoadingViewModel(new NavigationService(_navigationStore, CreateHomeViewModel));
        }

        private HomeViewModel CreateHomeViewModel()
        {
            return new HomeViewModel(
                new NavigationService(_navigationStore, CreateNewSavedPaletteViewModel),
                new NavigationService(_navigationStore, CreateNewNewPaletteViewModel),
                new NavigationService(_navigationStore, CreateNewInformationViewModel),
                new NavigationService(_navigationStore, CreateNewAboutViewModel),
                new NavigationService(_navigationStore, CreateNewContactViewModel)
            );
        }

        private ContactViewModel CreateNewContactViewModel()
        {
            return new ContactViewModel(new NavigationService(_navigationStore, CreateHomeViewModel));
        }

        private AboutViewModel CreateNewAboutViewModel()
        {
            return new AboutViewModel(new NavigationService(_navigationStore, CreateHomeViewModel));
        }

        private InformationViewModel CreateNewInformationViewModel()
        {
            return new InformationViewModel(new NavigationService(_navigationStore, CreateHomeViewModel));
        }

        private SavedPaletteViewModel CreateNewSavedPaletteViewModel()
        {
            savedPalettes = FileService.LoadPalettes();
            return new SavedPaletteViewModel(_navigationStore, new NavigationService(_navigationStore, CreateHomeViewModel), savedPalettes);
        }

        private NewPaletteViewModel CreateNewNewPaletteViewModel()
        {
            return new NewPaletteViewModel(_navigationStore, new NavigationService(_navigationStore, CreateHomeViewModel));
        }
    }

}
