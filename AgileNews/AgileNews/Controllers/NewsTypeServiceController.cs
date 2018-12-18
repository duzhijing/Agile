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

    [RoutePrefix("NewsTypeService")]
    public class NewsTypeServiceController : ApiController//AuthorizeAttribute
    {
        //public override void OnAuthorization(HttpActionContext actionContext)
        //{
        //    //从http请求的头里面获取身份验证信息，验证token值是否有效
        //    var authorization = actionContext.Request.Headers.Authorization;

        //    if ((authorization != null) && (authorization.Parameter != null))
        //    {
        //        //验证token值是否有效
        //        var encryptTicket = authorization.Parameter;
        //        var clientinfo = RedisHelper.Get<NewsType>(encryptTicket);
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
        public INewsTypeService NewsTypeService { get; set; }
        [Route("GetNewsTypes")]
        [HttpGet]
        public List<NewsType> GetNewsTypes()
        {
            var NewsTypeList = NewsTypeService.GetNewsTypes();
            return NewsTypeList;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="newsType"></param>
        /// <returns></returns>
        [Route("NewsTypeAdd")]
        [HttpPost]
        public int NewsTypeAdd(NewsType newsType)
        {
            var result = NewsTypeService.NewsTypeAdd(newsType);
            return result;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="newsTypeId"></param>
        /// <returns></returns>
        [Route("NewsTypeDelete")]
        [HttpGet]
        public int NewsTypeDelete(int newsTypeId)
        {
            var result = NewsTypeService.NewsTypeDelete(newsTypeId);
            return result;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="newsType"></param>
        /// <returns></returns>
        [HttpPut]
        public int NewsTypeUpdate(NewsType newsType)
        {
            var result = NewsTypeService.NewsTypeUpdate(newsType);
            return result;
        }
        [Route("GetNewsByIds")]
        [HttpGet]
        public List<News> GetNewsByIds(string typeids)
        {
            var result = NewsTypeService.GetNewsByIds(typeids);
            return result;
        }
    }
}
