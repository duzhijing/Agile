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
    public class RoleService : IRoleService
    {
        public List<Role> GetRoles()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from Role");
                var result = conn.Query<Role>(sql, null);
                return result.ToList<Role>();
            }
        }

        public int RoleAdd(Role role)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"insert into Function(RoleName,RoleUpdate,RoleCreate) values(:RoleName,:RoleUpdate,:RoleCreate)";
                return conn.Execute(sql, role);
            }
        }

        public int RoleDelete(int RoleID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete Role where RoleID=:RoleID");
                int i = conn.Execute(sql, new { RoleID = RoleID });
                return i;
            }
        }

        public int RoleUpdate(Role role)
        {
             using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update Role set  RoleName=@RoleName,RoleUpdateDate=@RoleUpdateDate,RoleCreate=@RoleCreate";
                int i = conn.Execute(sql, role);
                return i;

            }
        }
    }
}
