using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public  interface IAdminRoleService
    {
        int AdminRoleAdd(Comments adminRole);
        List<Comments> GetAdminRoles();
        int AdminRoleDelete(int AdminRoleID);
        int AdminRoleUpdate(Comments adminRole);
    }
}
