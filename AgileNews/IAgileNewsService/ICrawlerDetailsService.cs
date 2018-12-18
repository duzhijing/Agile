using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    public interface ICrawlerDetailsService
    {
        int CrawlerDetailsAdd(CrawlerDetails crawlerDetails);
        List<CrawlerDetails> GetCrawlerDetails();
        int CrawlerDetailsDelete(int CrawlerDetailsID);
        int CrawlerDetailsUpdate(CrawlerDetails crawlerDetails);
    }
}
