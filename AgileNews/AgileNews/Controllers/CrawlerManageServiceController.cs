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

    [RoutePrefix("CrawlerMange")]
    public class CrawlerManageServiceController : ApiController//AuthorizeAttribute
    {
        //public override void OnAuthorization(HttpActionContext actionContext)
        //{
        //    //从http请求的头里面获取身份验证信息，验证token值是否有效
        //    var authorization = actionContext.Request.Headers.Authorization;

        //    if ((authorization != null) && (authorization.Parameter != null))
        //    {
        //        //验证token值是否有效
        //        var encryptTicket = authorization.Parameter;
        //        var clientinfo = RedisHelper.Get<CrawlerManage>(encryptTicket);
        //        if (clientinfo != null)
        //        {
        //            base.IsAuthorized(actionContext);
        //        }
        //        else
        //        {
        //            base.HandleUnauthorizedRequest(actionContext);
        //        }
        //    }
        //    else//如果取不到token值，并且不允许匿名访问，则返回未验证401
        //    {
        //        var attributes = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().OfType<AllowAnonymousAttribute>();
        //        bool isAnonymous = attributes.Any(a => a is AllowAnonymousAttribute);//验证当前动作是否允许匿名访问
        //        if (isAnonymous)
        //        {
        //            base.OnAuthorization(actionContext);
        //        }
        //        else
        //        {
        //            base.HandleUnauthorizedRequest(actionContext);
        //        }
        //    }
        //}


        [Dependency]
        public ICrawlerManageService CrawlerManageService { get; set; }


        [HttpPost]
        public int CrawlerManageAdd(CrawlerManage crawlerManage)
        {
            var result = CrawlerManageService.CrawlerManageAdd(crawlerManage);
            return result;
        }
        [HttpDelete]
        public int CrawlerManageDelete(int CrawlerManageID)
        {
            var result = CrawlerManageService.CrawlerManageDelete(CrawlerManageID);
            return result;
        }
        [HttpPut]
        public int CrawlerManageUpdate(CrawlerManage crawlerManage)
        {
            var result = CrawlerManageService.CrawlerManageUpdate(crawlerManage);
            return result;

        }
        [HttpGet]
        public List<CrawlerManage> GetCrawlerManages()
        {
            var CrawlerManageList = CrawlerManageService.GetCrawlerManages();
            return CrawlerManageList;
        }
    }
}
