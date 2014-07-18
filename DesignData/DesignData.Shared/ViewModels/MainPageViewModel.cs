using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using DesignData.Entities;
using DesignData.Services;

namespace DesignData.ViewModels
{
    public class MainPageViewModel : Screen
    {
        private readonly IFeedService _feedService;

        public MainPageViewModel(IFeedService feedService)
        {
            _feedService = feedService;
        }

        public MainPageViewModel()
        {
            if (Execute.InDesignMode)
            {
                News = new List<FeedItem>
                {
                    new FeedItem
                    {
                        Title = "First news",
                        Description = "First news",
                        PublishDate = new DateTimeOffset(DateTime.Now)
                    },
                    new FeedItem
                    {
                        Title = "Second news",
                        Description = "Second news",
                        PublishDate = new DateTimeOffset(DateTime.Now)
                    },
                    new FeedItem
                    {
                        Title = "Third news",
                        Description = "Third news",
                        PublishDate = new DateTimeOffset(DateTime.Now)
                    }
                };
            }
        }

        private List<FeedItem> _news;

        public List<FeedItem> News
        {
            get { return _news; }
            set
            {
                _news = value;
                NotifyOfPropertyChange(() => News);
            }
        }

        protected override async void OnActivate()
        {
            IEnumerable<FeedItem> items = await _feedService.GetNews("http://feeds.feedburner.com/qmatteoq_eng");
            News = items.ToList();
        }
    }
}
