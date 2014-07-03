using Caliburn.Micro;
using Messages.Messages;

namespace Messages.ViewModels
{
    public class MainPageViewModel: Screen, IHandle<SimpleMessage>
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;

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
            _eventAggregator = eventAggregator;

            _eventAggregator.Subscribe(this);
        }

        public void GoToSecondPage()
        {
            _navigationService.NavigateToViewModel<DetailPageViewModel>();
        }

        public void Handle(SimpleMessage message)
        {
            Text = message.Text;
        }
    }
}
