using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TLog")]
    public class Log
    {
        /// <summary>
        /// LogID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogID { get; set; }
        /// <summary>
        /// 日志内容
        /// </summary>
        public string LogContent { get; set; }
        /// <summary>
        /// 日志类型
        /// </summary>
        public string LogType { get; set; }
        /// <summary>
        /// 数据ID
        /// </summary>
        public string DataID { get; set; }
        /// <summary>
        /// 日志创建时间
        /// </summary>
        public DateTime? LogCreate { get; set; }
    
        /// <summary>
        /// 用户IP
        /// </summary>
        public string UserIP { get; set; }
    }
}
