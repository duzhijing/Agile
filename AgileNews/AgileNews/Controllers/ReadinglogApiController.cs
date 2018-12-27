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

    public class ReadinglogApiController : ApiController
    {
        IReadinglogService _readinglogService = null;
        public ReadinglogApiController(IReadinglogService readinglogService)
        {
            _readinglogService = readinglogService;
        }

        /// <returns></returns>
        [HttpGet]
        [Route("GetReadinglogs")]
        public List<Readinglog> GetReadinglogs(DateTime? datetime1, DateTime? datetime2)
        {
            //当两个时间都为空时，获取当前时间的月份的第一天，和最后一天
            if (datetime1 == null)
            {
                //获取当前时间的月份的第一天
                datetime1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
            if (datetime2 == null)
            {
                //获取当前时间的月份最后一天
                int day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                datetime2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);
            }
            var readingloglist = _readinglogService.GetReadinglogs(datetime1, datetime2);
            return readingloglist;
        }
    }
}

