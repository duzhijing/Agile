using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TRole")]
    public class Role
    {
        /// <summary>
        /// 角色ID
        /// </summary>  
        public int RoleID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 角色修改时间
        /// </summary>
        public string RoleUpdate{ get; set; }
        /// <summary>
        /// 角色创建时间
        /// </summary>
        public string RoleCreate { get; set; }
        /// <summary>
        /// 角色标识
        /// </summary>
        //public string RoleCode { get; set; }
        /// <summary>
        /// 角色描述
        /// </summary>
        //public string RoleDesr { get; set; }
        /// <summary>
        /// 角色外键
        /// </summary>
        //public int RolePID { get; set; }
    }
}
