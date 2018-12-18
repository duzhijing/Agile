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
    [RoutePrefix("Power")]
    public class PowerController : ApiController
    {

        IPowerService ipowerservice = null;
        public PowerController(IPowerService powerservice)
        {
            ipowerservice = powerservice;
        }
        [HttpPost]
        [Route("AddPowers")]
        public int AddPowers(Power p)
        {
            return ipowerservice.AddPowers(p);
        }
        [HttpGet]
        [Route("Delete")]
        public int DeletePower(int Id)
        {
            return ipowerservice.DeletePower(Id);
        }
        [HttpGet]
        [Route("GetPowers")]
        public List<Power> GetPowers()
        {
            return ipowerservice.GetPowers();
        }
        [HttpGet]
        [Route("GetPowersById")]
        public List<Power> GetPowersById(int Id)
        {
            return ipowerservice.GetPowersById(Id);
        }
        [HttpGet]
        [Route("UpdatePowers")]
        public int UpdatePowers(Power p)
        {
            return ipowerservice.UpdatePowers(p);
        }
    }
}
