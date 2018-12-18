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



    [RoutePrefix("Users")]
    public class UsersServiceController : ApiController //AuthorizeAttribute
    {

        


        [Dependency]
        public IUsersService UsersService { get; set; }


        [HttpGet]
        public List<Users> GetUsers()
        {
            var UsersList = UsersService.GetUsers();
            return UsersList;
        }
        [HttpPost]
        public int UsersAdd(Users users)
        {
            var result = UsersService.UsersAdd(users);
            return result;
        }
        [HttpDelete]
        public int UsersDelete(int UsersID)
        {
            var result = UsersService.UsersDelete(UsersID);
            return result;
        }
        [HttpPut]
        public int UsersUpdate(Users users)
        {
            var result = UsersService.UsersUpdate(users);
            return result;
        }
    }
}
