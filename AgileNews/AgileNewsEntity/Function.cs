using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("TFunction")]
    public class Function
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FunctionID { get; set; }
        /// <summary>
        /// 模块名称
        /// </summary>
        public string FunctionName { get; set; }
        /// <summary>
        /// 模块外键ID
        /// </summary>
        public string FunctionPID { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int FunctionStatus { get; set; }
        /// <summary>
        /// 模块排序
        /// </summary>
        //public int FunctionSort { get; set; }
        /// <summary>
        /// 模块URL
        /// </summary>
        public string FunctionURL { get; set; }
        /// <summary>
        /// 模块修改时间
        /// </summary>
        public string FunctionUpdateDate { get; set; }
        /// <summary>
        /// 模块创建时间
        /// </summary>
        public string FunctionCreate { get; set; }
        /// <summary>
        /// 模块描述
        /// </summary>
        public string FunctionDesr { get; set; }
    }
}
