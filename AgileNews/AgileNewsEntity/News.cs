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
        /// 新闻排序
        /// </summary>
        public int NewsSort { get; set; }
        /// <summary>
        /// 新闻阅读人数
        /// </summary>
        public int NewsReader { get; set; }
        /// <summary>
        /// 新闻修改时间
        /// </summary>
        public DateTime? NewsUpdateDate { get; set; }
        /// <summary>
        /// 新闻类型外键
        /// </summary>
        public int NewsTypeID { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete { get; set; }
        /// <summary>
        /// 点赞次数外键
        /// </summary>
        public int LikeTablePid { get; set; }


    }
}
