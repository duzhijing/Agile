using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public interface IPermissionRoleService
    {
        int PermissionRoleAdd(PermissionRole permissionRole);
        List<PermissionRole> GetPermissionRoles();
        int PermissionRoleDelete(int PermissionRoleID);
        int PermissionRoleUpdate(PermissionRole permissionRole);
    }
}
