using Windows.UI.Xaml.Controls;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237
using Navigation.Common;

namespace Navigation.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class DetailPageView : Page
    {
        private NavigationHelper navigationHelper;

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        public DetailPageView()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
        }
    }
}
