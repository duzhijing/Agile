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
    public class LikesService : ILikesService
    {
        public List<Likes> GetLikes()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from Likes");
                var result = conn.Query<Likes>(sql, null);
                return result.ToList<Likes>();
            }
        }

        public int LikesAdd(Likes likes)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into Likes values(@UserPID,@NewsPID,@LikeCreate,@LikeUpdate)");
                int i = conn.Execute(sql, likes);
                return i;
            }
        }

        public int LikesDelete(int LikesID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete Likes where LikesID=:LikesID");
                int i = conn.Execute(sql, new { LikesID = LikesID });
                return i;
            }
        }

        public int LikesUpdate(Likes likes)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update Likes set UserPID=@UserPID,NewsPID=@NewsPID,LikeCreate=@LikeCreate,LikeUpdate=@LikeUpdate";
                int i = conn.Execute(sql, likes);
                return i;

            }
        }
    }
}
