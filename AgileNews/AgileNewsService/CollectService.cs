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
    public class CollectService : ICollectService
    {
        public int CollectAdd(Collect collect)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into Collect(UserPID,NewsPID) values(:UserPID,:NewsPID)");
                int i = conn.Execute(sql, collect);
                return i;
            }
        }

        public int CollectDelete(int CollectID)
        {

            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete Collect where CollectID =:CollectID");
                int i = conn.Execute(sql, new { CollectID = CollectID });
                return i;
            }
        }

        public int CollectUpdate(Collect collect)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update Collect set  UserPID=@UserPID,NewsPID=@NewsPID,CollectCreate=@CollectCreate,CollectLast=@CollectLast";
                int i = conn.Execute(sql, collect);
                return i;

            }
        }

        public List<Collect> GetCollects()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format(@"select N.NEWSTITLE,N.NEWSSORT,N.NEWSPUBLISHDATE from Collect c, News n where NewsPID=NEWSID");
                var result = conn.Query<Collect>(sql, null);
                return result.ToList<Collect>();
            }
        }
    }
}
