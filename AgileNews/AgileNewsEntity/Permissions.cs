using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsEntity
{
   public class Permissions
    {
       public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public string URLS { get; set; }
        public int IsDelete { get; set; }

        public string CreateTime { get; set; }
        public string UpdateTime { get; set; }
    }
}
