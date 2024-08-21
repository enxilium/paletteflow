using paletteflow.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using paletteflow.Models;
using paletteflow.Services;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using paletteflow.Stores;

namespace paletteflow.ViewModels
{
    public class NewPaletteViewModel : ViewModelBase
    {
        private readonly NavigationService _homeNavigationService;
        private readonly NavigationStore _navigationStore;

        public ICommand? SubmitCommand1 { get; }
        public ICommand? SubmitCommand2 { get; }
        public ICommand? SubmitCommand3 { get; }
        public ICommand? SubmitCommand4 { get; }
        public ICommand? BackCommand { get; }

        //-------------------------------------------------------------------//

        public NewPaletteViewModel(NavigationStore navigationStore, NavigationService navigationService)
        {
            _navigationStore = navigationStore;

            _homeNavigationService = navigationService;

            BackCommand = new NavigateCommand(navigationService);

            var toNextQuestionResponse1 = new NavigationService(navigationStore, CreateQuestion2ViewModelResponse1);
            var toNextQuestionResponse2 = new NavigationService(navigationStore, CreateQuestion2ViewModelResponse2);
            var toNextQuestionResponse3 = new NavigationService(navigationStore, CreateQuestion2ViewModelResponse3);
            var toNextQuestionResponse4 = new NavigationService(navigationStore, CreateQuestion2ViewModelResponse4);

            SubmitCommand1 = new NavigateCommand(toNextQuestionResponse1);
            SubmitCommand2 = new NavigateCommand(toNextQuestionResponse2);
            SubmitCommand3 = new NavigateCommand(toNextQuestionResponse3);
            SubmitCommand4 = new NavigateCommand(toNextQuestionResponse4);
        }

        private Question2ViewModel CreateQuestion2ViewModelResponse4()
        {
            return new Question2ViewModel([4], _navigationStore, _homeNavigationService);
        }

        private Question2ViewModel CreateQuestion2ViewModelResponse3()
        {
            return new Question2ViewModel([3], _navigationStore, _homeNavigationService);
        }

        private Question2ViewModel CreateQuestion2ViewModelResponse2()
        {
            return new Question2ViewModel([2], _navigationStore, _homeNavigationService);
        }

        private Question2ViewModel CreateQuestion2ViewModelResponse1()
        {
            return new Question2ViewModel([1], _navigationStore, _homeNavigationService);
        }
    }
}
