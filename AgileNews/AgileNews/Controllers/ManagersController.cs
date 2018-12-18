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
    public class ManagersController : ApiController
    {
        //页面尺寸
        private const int PageCount = 3;

        public IManagerService _managerservice = null;
        /// <summary>
        /// 构造函数注入点
        /// </summary>
        /// <param name="managerService"></param>
        public ManagersController(IManagerService managerService)
        {
            _managerservice = managerService;
        }

        /// <summary>
        /// 后台显示方法
        /// </summary>
        /// <param name="ManagersName"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [Route("GetManagers")]
        [HttpGet]
        public List<Managers> GetManagers()
        {
            var result = _managerservice.GetManagers();
            return result;
        }
        [HttpGet]
        [Route("HouTaiLogin")]
        public Managers Login(string ManagersName, string ManagersPsw)
        {

            return _managerservice.Login(ManagersName, ManagersPsw);
        }
        [HttpPost]
        [Route("AddManagers")]
        public int AddManagers(Managers managers)
        {
            var result = _managerservice.AddManagers(managers);
            return result;
        }
        [HttpGet]
        [Route("DeleteManagers")]
        public int DeleteManagers(int Id)
        {
            var result = _managerservice.DeleteManagers(Id);
            return result;
        }
        [HttpPost]
        [Route("UpdateManagers")]
        public int UpdateManagers(Managers managers)
        {
            var result = _managerservice.UpdateManagers(managers);
            return result;
        }
        [HttpGet]
        [Route("GetManagersById")]
        public List<Managers> GetManagersById(int Id)
        {
            var result = _managerservice.GetManagersById(Id);
            return result;
        }


    }
}
