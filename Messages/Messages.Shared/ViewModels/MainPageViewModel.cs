using Caliburn.Micro;
using Messages.Messages;

namespace Messages.ViewModels
{
    public class MainPageViewModel: Screen, IHandle<string>
    {
        private readonly INavigationService _navigationService;

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                NotifyOfPropertyChange(() => Text);
            }
        }

        public MainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;

            eventAggregator.Subscribe(this);
        }

        public void GoToSecondPage()
        {
            _navigationService.NavigateToViewModel<DetailPageViewModel>();
        }

        public void Handle(SimpleMessage message)
        {
            Text = message.Text;
        }

        public void Handle(string message)
        {
            Text = message;
        }
    }
}
