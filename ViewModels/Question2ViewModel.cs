using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using paletteflow.Commands;
using paletteflow.Models;
using paletteflow.Services;
using paletteflow.Stores;

namespace paletteflow.ViewModels
{
    public class Question2ViewModel : ViewModelBase
    {
        private readonly List<int> _responses;
        private readonly NavigationService _homeNavigationService;
        private readonly NavigationStore _navigationStore;

        public ICommand? SubmitCommand1 { get; }
        public ICommand? SubmitCommand2 { get; }
        public ICommand? SubmitCommand3 { get; }
        public ICommand? SubmitCommand4 { get; }
        public ICommand? BackCommand { get; }

        public String Response1Header { get; }
        public String Response2Header { get; }
        public String Response3Header { get; }
        public String Response4Header { get; }
        public String Response1Description { get; }
        public String Response2Description { get; }
        public String Response3Description { get; }
        public String Response4Description { get; }

        public String Response1Color { get; }
        public String Response2Color { get; }
        public String Response3Color { get; }
        public String Response4Color { get; }

        public Question2ViewModel(List<int> responses, NavigationStore navigationStore, NavigationService navigationService)
        {
            _navigationStore = navigationStore;

            _responses = responses;

            _homeNavigationService = navigationService;

            BackCommand = new NavigateCommand(navigationService);

            var toNextQuestionResponse1 = new NavigationService(navigationStore, CreateQuestion3ViewModelResponse1);
            var toNextQuestionResponse2 = new NavigationService(navigationStore, CreateQuestion3ViewModelResponse2);
            var toNextQuestionResponse3 = new NavigationService(navigationStore, CreateQuestion3ViewModelResponse3);
            var toNextQuestionResponse4 = new NavigationService(navigationStore, CreateQuestion3ViewModelResponse4);

            SubmitCommand1 = new NavigateCommand(toNextQuestionResponse1);
            SubmitCommand2 = new NavigateCommand(toNextQuestionResponse2);
            SubmitCommand3 = new NavigateCommand(toNextQuestionResponse3);
            SubmitCommand4 = new NavigateCommand(toNextQuestionResponse4);

            if (_responses[0] == 1)
            {
                Response1Color = "#5447E1";
                Response1Header = "Endless Storm";
                Response1Description = "maze of fog and water";

                Response2Color = "#E04ACC";
                Response2Header = "candy shop";
                Response2Description = "bursts of sweet and vibrance";

                Response3Color = "#E14777"; 
                Response3Header = "Sunset Beach";
                Response3Description = "dawn and dusk intertwined";

                Response4Color = "#A251E1";
                Response4Header = "Midnight City";
                Response4Description = "neon lights and rainy nights";
            }

            if (_responses[0] == 2)
            {
                Response1Color = "#49E0DF";
                Response1Header = "Tropical Islands";
                Response1Description = "sun-blessed paradise";

                Response2Color = "#5CE093";
                Response2Header = "Springtime Meadows";
                Response2Description = "where nature meets";

                Response3Color = "#59ADE1";
                Response3Header = "Tidal Waves";
                Response3Description = "ebb and flow";

                Response4Color = "#2746E0";
                Response4Header = "Underwater Grove";
                Response4Description = "drown in serenity";
            }

            if (_responses[0] == 3)
            {
                Response1Color = "#E0BC35";
                Response1Header = "Autumn Woods";
                Response1Description = "falling leaves and petals";

                Response2Color = "#E06930";
                Response2Header = "Blazing Sun";
                Response2Description = "radiance and power";

                Response3Color = "#71DC33";
                Response3Header = "Citrus Garden";
                Response3Description = "limes and lemons";

                Response4Color = "#E04B25";
                Response4Header = "Red Desert";
                Response4Description = "Scarlet sands and skies";
            }

            if (_responses[0] == 4)
            {
                Response1Color = "#555B57";
                Response1Header = "Ashen Forest";
                Response1Description = "Decayed woods shrouded in fog";

                Response2Color = "#404549";
                Response2Header = "Gloomy Days";
                Response2Description = "Dark clouds cast a shadow upon the world";

                Response3Color = "#4F4B3F";
                Response3Header = "Camo Fields";
                Response3Description = "The rigid will of soldiers";

                Response4Color = "#EEEEEE";
                Response4Header = "Blank Space";
                Response4Description = "nothingness, again and again";
            }
        }

        private Question3ViewModel CreateQuestion3ViewModelResponse4()
        {
            _responses.Add(4);
            return new Question3ViewModel(_responses, _navigationStore, _homeNavigationService);
        }

        private Question3ViewModel CreateQuestion3ViewModelResponse3()
        {
            _responses.Add(3);
            return new Question3ViewModel(_responses, _navigationStore, _homeNavigationService);
        }

        private Question3ViewModel CreateQuestion3ViewModelResponse2()
        {
            _responses.Add(2);
            return new Question3ViewModel(_responses, _navigationStore, _homeNavigationService);
        }

        private Question3ViewModel CreateQuestion3ViewModelResponse1()
        {
            _responses.Add(1);
            return new Question3ViewModel(_responses, _navigationStore, _homeNavigationService);
        }
    }
}
