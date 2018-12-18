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
    using System.Data;

    public class AdminPersonService : IAdminPersonService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="AdminPersonName"></param>
        /// <param name="AdminPersonPassword"></param>
        /// <returns></returns>
        public bool AdminLogin(string AdminPersonName, string AdminPersonPassword)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string strSql = string.Format("select * from AdminPerson where AdminPersonName='"+AdminPersonName+ "' and AdminPersonPassword='" + AdminPersonPassword + "'");
                var result = conn.Query<AdminPerson>(strSql,null).SingleOrDefault();
                return result != null;              
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="adminPerson"></param>
        /// <returns></returns>
        public int AdminPersinUpdate(AdminPerson adminPerson)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update News set AdminPersonName=@AdminPersonName,AdminPersonPassword=@AdminPersonPassword where AdminPersonID=@";
                int i = conn.Execute(sql, adminPerson);
                return i;

            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="adminPerson"></param>
        /// <returns></returns>
        public int AdminPersonAdd(AdminPerson adminPerson)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into AdminPerson values(@AdminPersonName,@AdminPersonPassword,getdate())");
                int i = conn.Execute(sql, adminPerson);

                return i;
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="AdminPersonID"></param>
        /// <returns></returns>
        public int AdminPersonDelete(int AdminPersonID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete from AdminPerson where AdminPersonID =:AdminPersonID");
                int i = conn.Execute(sql, new { AdminPersonID = AdminPersonID });
                return i;
            }
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<AdminPerson> GetAdminPerson()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select *from AdminPerson");
                var result = conn.Query<AdminPerson>(sql, null);
                return result.ToList<AdminPerson>();
            }
        }

    }
}
