using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TCollect")]
    public class Collect
    {
        /// <summary>
        /// 收藏ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CollectID { get; set; }
        /// <summary>
        /// 用户PID
        /// </summary>
        public int UserPID { get; set; }
        /// <summary>
        /// 新闻PID
        /// </summary>
        public int NewsPID { get; set; }
        /// <summary>
        /// 收藏时间
        /// </summary>
        public DateTime? CollectCreate { get; set; }
        /// <summary>
        /// 收藏修改时间
        /// </summary>
        public DateTime? CollectLast { get; set; }
    }
}
