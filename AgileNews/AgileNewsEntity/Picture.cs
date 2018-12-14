using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TPicture")]
    public class Picture
    {
        /// <summary>
        /// 图片ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PictureID { get; set; }
        /// <summary>
        /// 图片实际名称
        /// </summary>
        public string PictureActualName { get; set; }
        /// <summary>
        /// 图片显示名称
        /// </summary>
        public string PictureDisplayName { get; set; }
        /// <summary>
        /// 图片绝对路径
        /// </summary>
        public string PictureAbsolute { get; set; }
        /// <summary>
        /// 图片所属新闻
        /// </summary>
        public string PictureNewsDept { get; set; }
        /// <summary>
        /// 图片所属新闻类型
        /// </summary>
        public int PictureNewsTypeDept { get; set; }
        /// <summary>
        /// 图片创建时间
        /// </summary>
        public DateTime? PictureCreate { get; set; }
        /// <summary>
        /// 图片修改时间
        /// </summary>
        public DateTime? PictureUpdate { get; set; }
    }
}
