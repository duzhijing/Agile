using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
  public  interface ICrawlerManageService
    {
        int CrawlerManageAdd(CrawlerManage crawlerManage);
        List<CrawlerManage> GetCrawlerManages();
        int CrawlerManageDelete(int CrawlerManageID);
        int CrawlerManageUpdate(CrawlerManage crawlerManage);
    }
}
