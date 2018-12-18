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
    public class AdminRoleService : IAdminRoleService
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="adminRole"></param>
        /// <returns></returns>
        public int AdminRoleAdd(Comments adminRole)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into AdminRole values(@RolePID,@SuperAdminPID,@CreateDate,@UpdateDate,getdate()");
                int i = conn.Execute(sql, adminRole);
                return i;

            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="AdminRoleID"></param>
        /// <returns></returns>
        public int AdminRoleDelete(int AdminRoleID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete AdminRole where AdminRoleID =:AdminRoleID");
                int i = conn.Execute(sql, new { AdminRoleID = AdminRoleID });
                return i;
            }
        }

        public int AdminRoleUpdate(Comments adminRole)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update News setRolePID=@setRolePID,SuperAdminPID=@SuperAdminPID,CreateDate=@CreateDate,UpdateDate=@UpdateDate";
                int i = conn.Execute(sql, adminRole);
                return i;

            }
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Comments> GetAdminRoles()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from AdminRole");
                var result = conn.Query<Comments>(sql, null);
                return result.ToList<Comments>();
            }
        }
    }
}
