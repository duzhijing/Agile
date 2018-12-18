using AgileNewsEntity;
using IAgileNewsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgileNews.Controllers
{
    public class RoleController : ApiController
    {
        IRoleService iroleService = null;
        public RoleController(IRoleService roleService)
        {
            iroleService = roleService;
        }
        [HttpPost]
        [Route("AddRole")]
        public int AddRole([FromBody]Role r)
        {
            var result = iroleService.AddRole(r);
            return result;
        }
        [HttpGet]
        [Route("GetRole")]
        public List<Role> GetRole()
        {
            var result = iroleService.GetRole();
            return result;
        }
        [HttpGet]
        [Route("DeleteRole")]
        public int DeleteRole(int Id)
        {
            var result = iroleService.DeleteRole(Id);
            return result;
        }
        [HttpGet]
        [Route("GetRoleById")]
        public List<Role> GetRoleById(int Id)
        {
            var result = iroleService.GetRoleById(Id);
            return result;
        }
        [HttpPost]
        [Route("UpdateRole")]
        public int UpdateRole(Role role)
        {

            var result = iroleService.UpdateRole(role);
            return result;
        }
    }
}

