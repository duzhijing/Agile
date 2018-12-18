using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TAdminPerson")]
    //管理员表
   public class AdminPerson
    {
        /// <summary>
        /// 管理员ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminPersonID { get; set; }
        /// <summary>
        /// 管理员名称
        /// </summary>
        public string AdminPersonName { get; set; }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPersonPassword { get; set; }
        /// <summary>
        /// 角色外键PID
        /// </summary>
       // public int RolePID { get; set; }
        /// <summary>
        /// 模块外键ID
        /// </summary>
        //public string FunctionPID { get; set; }
        /// <summary>
        /// 超级管理员创建时间
        /// </summary>
        public DateTime? AdminCreateDate { get; set; }
        /// <summary>
        /// 超级管理员修改
        /// </summary>
        public DateTime? AdminUpdate { get; set; }
        /// <summary>
        /// 超级管理员信息
        /// </summary>
        public string AdminInfo { get; set; }
     
    }
}
