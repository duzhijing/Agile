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
    public class LogService : ILogService
    {
        public List<Log> GetLogs()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from Log");
                var result = conn.Query<Log>(sql, null);
                return result.ToList<Log>();
            }
        }

        public int LogAdd(Log log)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into Log values(@LogContent,@LogType,@DataID,@LogCreate,@UserIP)");
                int i = conn.Execute(sql, log);
                return i;
            }
        }

        public int LogDelete(int LogID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete Log where CollectID=:CollectID");
                int i = conn.Execute(sql, new { LogID = LogID });
                return i;
            }
        }

        public int LogUpdate(Log log)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update Log set  LogContent=@LogContent,LogType=@LogType,DataID=@DataID,LogCreate=@LogCreate,UserIP=@UserIP";
                int i = conn.Execute(sql, log);
                return i;

            }
        }
    }
}
