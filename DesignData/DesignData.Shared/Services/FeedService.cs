using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Syndication;
using DesignData.Entities;

namespace DesignData.Services
{
    public class FeedService: IFeedService
    {
        public async Task<IEnumerable<FeedItem>> GetNews(string feedUrl)
        {
            SyndicationClient client = new SyndicationClient();
            SyndicationFeed feed = await client.RetrieveFeedAsync(new Uri(feedUrl, UriKind.Absolute));
            List<FeedItem> feedItems = feed.Items.Select(x => new FeedItem
            {
                Title = x.Title.Text,
                Description = x.Summary.Text,
                PublishDate = x.PublishedDate
            }).ToList();

            return feedItems;
        }
    }
}
