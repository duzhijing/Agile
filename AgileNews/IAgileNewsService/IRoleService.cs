using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public interface IRoleService
    {
        int RoleAdd(Role role);
        List<Role> GetRoles();
        int RoleDelete(int RoleID);
        int RoleUpdate(Role role);
    }
}
