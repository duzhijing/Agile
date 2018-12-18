using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TCrawlerGrab")]
    public class CrawlerGrab
    {
        /// <summary>
        /// 爬虫ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrawlerGrabID { get; set; }
        /// <summary>
        /// 爬虫URL
        /// </summary>
        public string CrawlerGrabURL { get; set; }
        /// <summary>
        /// 爬取标题
        /// </summary>
        public string CrawlerGrabTitle { get; set; }
        /// <summary>
        /// 爬取内容
        /// </summary>
        public string CrawlerGrabContent { get; set; }
        /// <summary>
        /// 爬取图片
        /// </summary>
        public string CrawlerGrabPicture { get; set; }
        /// <summary>
        /// 爬取第一张图片URL
        /// </summary>
        public string FirstPictureURL { get; set; }
        /// <summary>
        /// 爬取时间
        /// </summary>
        public DateTime? CrawlerGrabCreateDate { get; set; }
        /// <summary>
        /// 爬取修改时间
        /// </summary>
        public DateTime? CrawlerGrabUpdateDate { get; set; }
        /// <summary>
        /// 新闻作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 新闻发布时间
        /// </summary>
        public DateTime? NewsReleaceDate { get; set; }
        /// <summary>
        /// 新闻来源
        /// </summary>
        public string NewsSource { get; set; }
        /// <summary>
        /// 新闻转载
        /// </summary>
        public string NewsMark { get; set; }
        /// <summary>
        /// 新闻类型ID
        /// </summary>
        public int NewsTypeID { get; set; }
    }
}
