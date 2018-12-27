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
    public class LogServiceController : ApiController//AuthorizeAttribute
    {
        


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
