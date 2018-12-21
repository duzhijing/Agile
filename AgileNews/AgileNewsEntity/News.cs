using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TNews")]
    public class News
    {
        /// <summary>
        /// 新闻ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NewsID { get; set; }
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string NewsTitle { get; set; }
        /// <summary>
        /// 新闻发布人
        /// </summary>
        public string NewsPublisher { get; set; }
        /// <summary>
        /// 新闻发布时间
        /// </summary>
        public DateTime? NewsPublishDate { get; set; }
        /// <summary>
        /// 新闻细节
        /// </summary>
        public string NewsDetails { get; set; }
        /// <summary>
        /// 新闻摘自
        /// </summary>
        public string  NewsSort { get; set; }
        /// <summary>
        /// 新闻阅读人数
        /// </summary>
        public int NewsReader { get; set; }
        /// <summary>
        /// 新闻修改时间
        /// </summary>
        public DateTime? NewsUpdateDate { get; set; }
        /// <summary>
        /// 新闻类型
        /// </summary>
        public string  NewsTypeName { get; set; }
        /// <summary>
        /// 新闻摘要
        /// </summary>
        public string IsDelete { get; set; }
        /// <summary>
        /// 点赞次数外键
        /// </summary>
        public int LikeTablePid { get; set; }
       ///关键字
        /// </summary>
        public string Category { get; set; }
        public String Image { get; set; }


    }
}
