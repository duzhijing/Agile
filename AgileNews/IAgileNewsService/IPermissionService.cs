using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public interface IPermissionService
    {
        int AddPermission(Permissions permissions);
        int DeletePermission(int PermissionID);
        int UpdatePermission(Permissions permissions);
        List<Permissions> GetPermissions();
        List<Permissions> GetPermissionsByID(int PermissionID);


    }
}
