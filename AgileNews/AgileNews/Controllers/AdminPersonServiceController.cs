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
    using System.Web;
    using System.Web.Http.Controllers;
    

    [RoutePrefix("AdminPersonService")]
    public class AdminPersonServiceController :AuthorizeAttribute
    {



        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //从http请求的头里面获取身份验证信息，验证token值是否有效
            var authorization = actionContext.Request.Headers.Authorization;

            if ((authorization != null) && (authorization.Parameter != null))
            {
                //验证token值是否有效
                var encryptTicket = authorization.Parameter;
                var clientinfo = RedisHelper.Get<AdminPerson>(encryptTicket);
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


       public IAdminPersonService AdminPersonService { get; set; }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="adminPerson"></param>
        /// <returns></returns>

        [HttpPut]
        public int AdminPersinUpdate(AdminPerson adminPerson)
        {
            var result = AdminPersonService.AdminPersinUpdate(adminPerson);
            return result;
        }
        [HttpPost]
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="adminPerson"></param>
        /// <returns></returns>
        public int AdminPersonAdd(AdminPerson adminPerson)
        {
            var result = AdminPersonService.AdminPersonAdd(adminPerson);
            return result;
        }
        [HttpDelete]
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="AdminPersonID"></param>
        /// <returns></returns>
        
        public int AdminPersonDelete(int AdminPersonID)
        {
            var result = AdminPersonService.AdminPersonDelete(AdminPersonID);
            return result;
          
        }
        [HttpGet]
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<AdminPerson> GetAdminPerson()
        {
            var AdminPersonList = AdminPersonService.GetAdminPerson();
            return AdminPersonList;

        }
       
    }
}
