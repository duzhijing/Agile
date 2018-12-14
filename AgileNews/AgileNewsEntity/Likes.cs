using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TLikes")]
    public class Likes
    {
        /// <summary>
        /// 点赞ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LikeTableID { get; set; }
        /// <summary>
        /// 用户PID
        /// </summary>
        public int UserPID { get; set; }
        /// <summary>
        /// 新闻PID
        /// </summary>
        public int NewsPID { get; set; }
        /// <summary>
        /// 点赞创建时间
        /// </summary>
        public DateTime LikeCreate { get; set; }
        /// <summary>
        /// 点赞修改时间
        /// </summary>
        public DateTime LikeUpdate { get; set; }
    }
}
