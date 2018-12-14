using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TUsers")]
    public class Users
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户描述
        /// </summary>
      
        public string UserDesr { get; set; }
        /// <summary>
        /// 用户创建时间
        /// </summary>
        public DateTime? UserCreate { get; set; }
        /// <summary>
        /// 用户修改时间
        /// </summary>
        public DateTime? UserUpdate { get; set; }
    }
}
