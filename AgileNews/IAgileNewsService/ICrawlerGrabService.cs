using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    
   public interface ICrawlerGrabService
    {
        int CrawlerGrabAdd(CrawlerGrab crawlerGrab);
        List<CrawlerGrab> GetCrawlerGrabs();
        int CrawlerGrabDelete(int CrawlerGrabID);
        int CrawlerGrabUpdate(CrawlerGrab crawlerGrab);
    }
}
