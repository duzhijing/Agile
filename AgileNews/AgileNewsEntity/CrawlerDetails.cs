using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TCrawlerDetails")]
    public class CrawlerDetails
    {
        /// <summary>
        /// 爬虫明细表ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrawlerDetailsID { get; set; }
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
        /// 是否启用
        /// </summary>
        public int IsState { get; set; }
        /// <summary>
        /// 爬虫管理外键
        /// </summary>
        public int CrawlerManageID { get; set; }
    }
}
