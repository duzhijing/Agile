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


    [RoutePrefix("Log")]
    public class LogServiceController : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //从http请求的头里面获取身份验证信息，验证token值是否有效
            var authorization = actionContext.Request.Headers.Authorization;

            if ((authorization != null) && (authorization.Parameter != null))
            {
                //验证token值是否有效
                var encryptTicket = authorization.Parameter;
                var clientinfo = RedisHelper.Get<Log>(encryptTicket);
                if (clientinfo != null)
                {
                    base.IsAuthorized(actionContext);
                }
                else
                {
                    base.HandleUnauthorizedRequest(actionContext);
                }
            }
            else//如果取不到token值，并且不允许匿名访问，则返回未验证401
            {
                var attributes = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().OfType<AllowAnonymousAttribute>();
                bool isAnonymous = attributes.Any(a => a is AllowAnonymousAttribute);//验证当前动作是否允许匿名访问
                if (isAnonymous)
                {
                    base.OnAuthorization(actionContext);
                }
                else
                {
                    base.HandleUnauthorizedRequest(actionContext);
                }
            }
        }


        [Dependency]
        public ILogService LogService { get; set; }

        [HttpPost]
        public List<Log> GetLogs()
        {
            var LogList = LogService.GetLogs();
            return LogList;


        }
        [HttpGet]
        public int LogAdd(Log log)
        {
            var result = LogService.LogAdd(log);
            return result;
        }
        [HttpDelete]
        public int LogDelete(int LogID)
        {
            var result = LogService.LogDelete(LogID);
            return result;
        }
        [HttpPut]
        public int LogUpdate(Log log)
        {
            var resule = LogService.LogUpdate(log);
            return resule;
        }
    }
}
