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

    [RoutePrefix("NewsService")]
    public class NewsServiceController  :ApiController//: AuthorizeAttribute
    {

        //public override void OnAuthorization(HttpActionContext actionContext)
        //{
        //    //从http请求的头里面获取身份验证信息，验证token值是否有效
        //    var authorization = actionContext.Request.Headers.Authorization;

        //    if ((authorization != null) && (authorization.Parameter != null))
        //    {
        //        //验证token值是否有效
        //        var encryptTicket = authorization.Parameter;
        //        var clientinfo = RedisHelper.Get<News>(encryptTicket);
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
        public INewsService NewsService { get; set; }
        [Route("GetNews")]
        [HttpGet]
        public List<News> GetNews()
        {
            var NewsList = NewsService.GetNews();
            return NewsList;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        [Route("NewsAdd")]
        [HttpPost]
        public int NewsAdd(News news)
        {
            var result = NewsService.NewsAdd(news);
            return result;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        [Route("NewsDelete")]
        [HttpGet]
        public int NewsDelete(int newsId)
        {
            var result = NewsService.NewsDelete(newsId);
            return result;
          
        }
        /// <summary>
        /// 根据ID获取信息
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("getAloneNews")]
        public News getAloneNews(int newsId)
        {
            var result = NewsService.GetAloneNews(newsId);

            return result;
        }



        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
       [HttpPost]
        public int NewsUpdate(News news)
        {
            var result = NewsService.NewsUpdate(news);
            return result;
           
        }
    }
}
