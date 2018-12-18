using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TComment")]
    public class Comment
    {
        /// <summary>
        /// 评论ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }
        /// <summary>
        /// 用户PID
        /// </summary>
        public int UserPID { get; set; }
        /// <summary>
        /// 新闻PID
        /// </summary>
        public int NewsPID { get; set; }
        /// <summary>
        /// 评论创建时间
        /// </summary>
        public string CommentCreate { get; set; }
        /// <summary>
        /// 评论修改时间
        /// </summary>
        public DateTime? CommentUpdate { get; set; }
        /// <summary>
        /// 评论修改内容
        /// </summary>
        public string CommentContent { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete { get; set; }
    }
}
