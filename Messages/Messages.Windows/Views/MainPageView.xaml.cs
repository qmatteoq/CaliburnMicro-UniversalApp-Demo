using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Navigation;
using Caliburn.Micro;
using Messages.Messages;

namespace Messages.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPageView : Page, IHandle<SimpleMessageForView>, IHandle<SimpleMessageInBackground>
    {
        public MainPageView()
        {
            this.InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;

            WinRTContainer container = (Application.Current as App).container;

            IEventAggregator eventAggregator = container.GetInstance<IEventAggregator>();

            eventAggregator.Subscribe(this);
        }


        public void Handle(SimpleMessageForView message)
        {
            MessageContent.Text = message.Text;
        }

        public void Handle(SimpleMessageInBackground message)
        {
            Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                MessageContent.Text = message.Text;
            });
        }
    }
}
