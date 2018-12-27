using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgileNews.Controllers
{
    using IAgileNewsService;
    using AgileNewsEntity;
    using Newtonsoft.Json;
    using AgileNewsCommon;
    using System.Net.Http;
    using AgileNewsCache;
    using Unity.Attributes;
    using System.Web.Http.Controllers;


    [RoutePrefix("CrawlerDetails")]
    public class CrawlerDetailsServiceController : ApiController//AuthorizeAttribute
    {




        [Dependency]
        public ICrawlerDetailsService CrawlerDetailsService { get; set; }

        [HttpPost]
        public int CrawlerDetailsAdd(CrawlerDetails crawlerDetails)
        {
            var result = CrawlerDetailsService.CrawlerDetailsAdd(crawlerDetails);
            return result;
        }
        [HttpDelete]
        public int CrawlerDetailsDelete(int CrawlerDetailsID)
        {
            var result = CrawlerDetailsService.CrawlerDetailsDelete(CrawlerDetailsID);
            return result;

        }
        [HttpPut]
        public int CrawlerDetailsUpdate(CrawlerDetails crawlerDetails)
        {
            var result = CrawlerDetailsService.CrawlerDetailsUpdate(crawlerDetails);
            return result;
        }
        [HttpGet]
        public List<CrawlerDetails> GetCrawlerDetails()
        {
            var CrawlerDetailsList = CrawlerDetailsService.GetCrawlerDetails();
            return CrawlerDetailsList;
        }

    }
}
