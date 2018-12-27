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


    [RoutePrefix("Picture")]
    public class PictureServiceController : ApiController //AuthorizeAttribute
    {

        



        [Dependency]
        public IPictureService  PictureService { get; set; }


        [HttpGet]
        public List<Picture> GetPictures()
        {
            var PictureList = PictureService.GetPictures();
               
            return PictureList;
        }

        ///图片表
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        [HttpPost]
        public int PictureAdd(Picture picture)
        {
            var result = PictureService.PictureAdd(picture);
            return result;
            
        }
       
        [HttpDelete]
        public int PictureDelete(int PictureID)
        {
            var result = PictureService.PictureDelete(PictureID);
            return result;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        [HttpPut]
        public int PictureUpdate(Picture picture)
        {
            var result = PictureService.PictureUpdate(picture);
            return result;
        }
        }
    }

