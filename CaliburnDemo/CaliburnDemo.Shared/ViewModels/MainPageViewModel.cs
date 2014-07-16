using Caliburn.Micro;

namespace CaliburnDemo.ViewModels
{
    public class MainPageViewModel : PropertyChangedBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanConfirm);
            }
        }

        private string greetings;
        public string Greetings
        {
            get { return greetings; }
            set
            {
                greetings = value;
                NotifyOfPropertyChange(() => Greetings);
            }
        }

        public bool CanConfirm
        {
            get { return !string.IsNullOrWhiteSpace(Name); }
        }

        public void Confirm()
        {
            Greetings = string.Format("Hello, {0}!", Name);
        }
    }
}
