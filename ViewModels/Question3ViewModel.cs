using paletteflow.Models;
using paletteflow.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using paletteflow.Services;
using paletteflow.Commands;
using System.Windows.Input;

namespace paletteflow.ViewModels
{
    public class Question3ViewModel : ViewModelBase
    {
        private readonly List<int> _responses;
        private readonly NavigationService _homeNavigationService;
        private readonly NavigationStore _navigationStore;

        public ICommand? SubmitCommand1 { get; }
        public ICommand? SubmitCommand2 { get; }
        public ICommand? SubmitCommand3 { get; }
        public ICommand? SubmitCommand4 { get; }
        public ICommand? BackCommand { get; }

        public Question3ViewModel(List<int> responses, NavigationStore navigationStore, NavigationService navigationService)
        {
            _navigationStore = navigationStore;
            
            _responses = responses;

            _homeNavigationService = navigationService;

            BackCommand = new NavigateCommand(navigationService);

            var toNextQuestionResponse1 = new NavigationService(navigationStore, CreateDisplayNewPaletteViewModelResponse1);
            var toNextQuestionResponse2 = new NavigationService(navigationStore, CreateDisplayNewPaletteViewModelResponse2);
            var toNextQuestionResponse3 = new NavigationService(navigationStore, CreateDisplayNewPaletteViewModelResponse3);
            var toNextQuestionResponse4 = new NavigationService(navigationStore, CreateDisplayNewPaletteViewModelResponse4);

            SubmitCommand1 = new NavigateCommand(toNextQuestionResponse1);
            SubmitCommand2 = new NavigateCommand(toNextQuestionResponse2);
            SubmitCommand3 = new NavigateCommand(toNextQuestionResponse3);
            SubmitCommand4 = new NavigateCommand(toNextQuestionResponse4);
        }

        private DisplayNewPaletteViewModel CreateDisplayNewPaletteViewModelResponse1()
        {
            _responses.Add(1);
            return new DisplayNewPaletteViewModel(_responses, _navigationStore, _homeNavigationService);
        }

        private DisplayNewPaletteViewModel CreateDisplayNewPaletteViewModelResponse2()
        {
            _responses.Add(2);
            return new DisplayNewPaletteViewModel(_responses, _navigationStore, _homeNavigationService);
        }

        private DisplayNewPaletteViewModel CreateDisplayNewPaletteViewModelResponse3()
        {
            _responses.Add(3);
            return new DisplayNewPaletteViewModel(_responses, _navigationStore, _homeNavigationService);
        }

        private DisplayNewPaletteViewModel CreateDisplayNewPaletteViewModelResponse4()
        {
            _responses.Add(4);
            return new DisplayNewPaletteViewModel(_responses, _navigationStore, _homeNavigationService);
        }
    }
}
