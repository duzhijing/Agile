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
    public class UsersService : IUsersService
    {
        public List<Users> GetUsers()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from Users");
                var result = conn.Query<Users>(sql, null);
                return result.ToList<Users>();
            }
        }

        public int UsersAdd(Users users)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"insert into News(UserName,UserDesr,UserCreate,UserUpdate) values(:UserName,:UserDesr,:UserCreate,:UserUpdate)";
                return conn.Execute(sql, users);
            }
        }

        public int UsersDelete(int UsersID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete Users where UsersID=:UsersID");
                int i = conn.Execute(sql, new { UsersID = UsersID });
                return i;
            }
        }

        public int UsersUpdate(Users users)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update Users set UserName=@UserName,UserDesr=@UserDesr,UserCreate=@UserCreate,UserUpdate=@UserUpdate";
                int i = conn.Execute(sql, users);
                return i;

            }
        }
    }
}
