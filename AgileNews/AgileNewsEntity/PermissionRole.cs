using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TPermissionRole")]
    public class PermissionRole
    {
        public int PermissionRoleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RolePID { get; set; }
        /// <summary>
        /// 权限外键PID
        /// </summary>
        public int PermissionPID { get; set; }
        /// <summary>
        /// 模块创建时间
        /// </summary>
        public DateTime? CreateData { get; set; }
        /// <summary>
        /// 模块修改时间
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 权限状态
        /// </summary>
        //public int PermissionStatus { get; set; }
    }
}
