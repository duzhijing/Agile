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
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户的唯一标识
        /// </summary>
        public string Openid { get; set; }
        /// <summary>
        /// 用户令牌  session-key 本次登陆的会话密钥 
        /// </summary>
        public string Session_key { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public string Userbirthday { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string UserSex { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public string ModifyTime { get; set; }
    }
}
