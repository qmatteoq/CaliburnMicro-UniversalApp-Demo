using Caliburn.Micro;
using Messages.Messages;

namespace Messages.ViewModels
{
    public class DetailPageViewModel: Screen
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;

        public DetailPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
        }

        public async void SendMessage()
        {
            SimpleMessage message = new SimpleMessage("This is a simple message");
            await _eventAggregator.PublishOnUIThreadAsync(message);
        }

        public void GoBack()
        {
            _navigationService.GoBack();
        }
    }
}
