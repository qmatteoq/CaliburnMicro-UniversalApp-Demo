using System;
using System.Collections.Generic;
using System.Text;

namespace DesignData.Entities
{
    public class FeedItem
    {
        public string Title { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public string Description { get; set; }
    }
}
