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


    [RoutePrefix("PermissionRole")]
    public class PermissionRoleServiceController :ApiController //AuthorizeAttribute
    {


    


        [Dependency]
        public IPermissionRoleService PermissionRoleService { get; set; }
        [HttpPost]


        public List<PermissionRole> GetPermissionRoles()
        {
            var PermissionRoleList = PermissionRoleService.GetPermissionRoles();
            return PermissionRoleList;
        }


        [HttpPost]
        public int PermissionRoleAdd(PermissionRole permissionRole)
        {
            var result = PermissionRoleService.PermissionRoleAdd(permissionRole);
            return result;
        }
        [HttpDelete]
        public int PermissionRoleDelete(int PermissionRoleID)
        {
            var result = PermissionRoleService.PermissionRoleDelete(PermissionRoleID);
            return result;
        }
        [HttpPut]
        public int PermissionRoleUpdate(PermissionRole permissionRole)
        {
            var result = PermissionRoleService.PermissionRoleUpdate(permissionRole);
            return result;
        }

    }
}
