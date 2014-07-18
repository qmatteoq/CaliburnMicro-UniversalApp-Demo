using System.Collections.Generic;
using System.Threading.Tasks;
using DesignData.Entities;

namespace DesignData.Services
{
    public interface IFeedService
    {
        Task<IEnumerable<FeedItem>> GetNews(string feedUrl);
    }
}
