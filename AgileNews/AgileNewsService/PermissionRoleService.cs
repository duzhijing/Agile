using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileNewsService
{
    using IAgileNewsService;
    using AgileNewsEntity;
    using Newtonsoft.Json;
    using AgileNewsCommon;
    using System.Net.Http;
    using AgileNewsCache;
    using Oracle.ManagedDataAccess.Client;
    using Oracle.ManagedDataAccess;
    using Dapper;
    public class PermissionRoleService : IPermissionRoleService
    {
        public List<PermissionRole> GetPermissionRoles()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from PermissionRole");
                var result = conn.Query<PermissionRole>(sql, null);
                return result.ToList<PermissionRole>();
            }
        }

       

        public int PermissionRoleAdd(PermissionRole permissionRole)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into PermissionRole values(@PermissionRoleID,@RolePID,@FunctionPID,@CreateData,@UpdateDate,getdate())");
                int i = conn.Execute(sql, permissionRole);
                return i;
            }
        }

        public int PermissionRoleDelete(int PermissionRoleID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete PermissionRole where PermissionRoleID=:PermissionRoleID");
                int i = conn.Execute(sql, new { PermissionRoleID = PermissionRoleID });
                return i;
            }
        }

        public int PermissionRoleUpdate(PermissionRole permissionRole)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update PermissionRole set  PermissionRoleID=@PermissionRoleID,RolePID=@RolePID,FunctionPID=@FunctionPID,CreateData=@CreateData,UpdateDate=@UpdateDate";
                int i = conn.Execute(sql, permissionRole);
                return i;

            }
        }
    }
}
