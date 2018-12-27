using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
   public  class Readinglog
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 新闻Id
        /// </summary>
        public int NewsID { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 新闻名称
        /// </summary>
        public string NewsName { get; set; }
        /// <summary>
        /// 新闻阅读量
        /// </summary>
        public int NewsReader { get; set; }
    }
}
