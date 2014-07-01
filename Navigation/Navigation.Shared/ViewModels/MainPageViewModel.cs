using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.UI.Popups;
using Caliburn.Micro;
using Navigation.Entities;

namespace Navigation.ViewModels
{
    public class MainPageViewModel : Screen
    {
        private readonly INavigationService _navigationService;
        private readonly ILog _log;

        public MainPageViewModel(INavigationService navigationService, ILog log)
        {
            _navigationService = navigationService;
            _log = log;
        }

        private ObservableCollection<Movie> movies;

        public ObservableCollection<Movie> Movies
        {
            get { return movies; }
            set
            {
                movies = value;
                NotifyOfPropertyChange(() => Movies);
            }
        }

        public void GoToDetail(Movie movie)
        {
            _navigationService.NavigateToViewModel<DetailPageViewModel>(movie);
        }

        protected override void OnActivate()
        {
            Movies = new ObservableCollection<Movie>
            {
                new Movie {Title = "The Avengers", Director = "Joss Whedon"},
                new Movie {Title = "Transformers", Director = "Michael Bay"},
                new Movie {Title = "X-Men Days of the future past", Director = "Bryan Synger"}
            };
        }
    }
}

