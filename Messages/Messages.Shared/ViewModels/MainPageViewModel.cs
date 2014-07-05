using Caliburn.Micro;
using Messages.Messages;

namespace Messages.ViewModels
{
    public class MainPageViewModel: Screen, IHandle<string>, IHandle<SimpleMessage>
    {
        private readonly INavigationService _navigationService;

        private string _messageContent;

        public string MessageContent
        {
            get { return _messageContent; }
            set
            {
                _messageContent = value;
                NotifyOfPropertyChange(() => MessageContent);
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
            MessageContent = message.Text;
        }

        public void Handle(string message)
        {
            MessageContent = message;
        }
    }
}
