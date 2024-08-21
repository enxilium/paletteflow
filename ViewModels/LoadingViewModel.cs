using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.Input;
using paletteflow.Commands;
using paletteflow.Models;
using paletteflow.Services;
using paletteflow.Stores;
using NavigationService = paletteflow.Services.NavigationService;

namespace paletteflow.ViewModels
{
    public class LoadingViewModel : ViewModelBase
    {
        private DispatcherTimer _timer;
        private readonly NavigationService _navigationService;

        public String SelectedMessage { get; set; }

        public LoadingViewModel(NavigationService navigationService)
        {
            List<string> messages = [
                "color is the language of the world.",
                "in every shade, a story unfolds.",
                "art is the harmony of form and hue.",
                "a single palette can ignite a world of inspiration."
            ];

            var random = new Random();

            var index = random.Next(messages.Count);

            SelectedMessage = messages[index];

            _navigationService = navigationService;

            LoadingTimer();
        }

        public void LoadingTimer()
        {
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(3) // Set delay to 5 seconds
            };
            _timer.Tick += OnTimerTick;
            _timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _timer.Stop();
            _navigationService.Navigate();
        }
    }
}
