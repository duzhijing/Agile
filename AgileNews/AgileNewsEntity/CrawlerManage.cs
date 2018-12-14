using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TCrawlerManage")]
    public class CrawlerManage
    {
        /// <summary>
        /// 爬虫管理主键ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrawlerManageID { get; set; }
        /// <summary>
        /// 爬虫名称
        /// </summary>
        public string CrawlerGrabName { get; set; }
        /// <summary>
        /// 执行时间
        /// </summary>
        public DateTime? CreateDateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Founder { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsState { get; set; }
        /// <summary>
        /// 爬虫抓取外键
        /// </summary>
        public int CrawlerGrabID { get; set; }

        public object GetCrawlerManages(string typeids)
        {
            throw new NotImplementedException();
        }
    }
}
