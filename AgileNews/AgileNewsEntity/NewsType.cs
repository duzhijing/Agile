using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TNewsType")]
    public class NewsType
    {
        /// <summary>
        /// 新闻类型ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NewsTypeID { get; set; }
        /// <summary>
        /// 新闻类型名称
        /// </summary>
        public string NewsTypeName { get; set; }
        /// <summary>
        /// 新闻类型描述
        /// </summary>
        public string NewsTypeDesr { get; set; }
        /// <summary>
        /// 新闻类型修改
        /// </summary>
        public DateTime? NewsTypeUpdateDate { get; set; }
        /// <summary>
        /// 新闻类型外键
        /// </summary>
        public int NewsTypePID { get; set; }
        /// <summary>
        /// 新闻类型创建时间
        /// </summary>
        public DateTime? NewsTypeCreate { get; set; }
        /// <summary>
        /// 新闻类型修改时间
        /// </summary>
        public DateTime? NewsTypeUpdate { get; set; }
    }
}
