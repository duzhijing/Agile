using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TCrawlerWebsite")]
    public class CrawlerWebsite
    {
        /// <summary>
        /// 爬虫网站管理ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrawlerWebsiteID { get; set; }
        /// <summary>
        /// 网站名称
        /// </summary>
        public string WebsiteName { get; set; }
        /// <summary>
        /// 网站URL
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// 频道名称
        /// </summary>
        public string ChannelName { get; set; }
        /// <summary>
        /// 频道URL
        /// </summary>
        public string ChannelURL { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Founder { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsState { get; set; }
        /// <summary>
        /// 爬虫外键明细表
        /// </summary>
        public int CrawlerDetailsID { get; set; }
    }
}
