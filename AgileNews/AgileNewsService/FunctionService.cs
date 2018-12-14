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
    public class FunctionService : IFunctionService
    {
        public int FunctionAdd(Function function)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"insert into Function(FunctionName,FunctionStatus) values(:FunctionName,:FunctionStatus)";
                return conn.Execute(sql, function);
            }
        }

        public int FunctionDelete(int FunctionID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete Function where FunctionID=:FunctionID");
                int i = conn.Execute(sql, new { FunctionID = FunctionID });
                return i;
            }
        }

        public int FunctionUpdate(Function function)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update Function set  FunctionName=@FunctionName,FunctionPID=@FunctionPID,FunctionStatus=@FunctionStatus,FunctionURL=@FunctionURL,FunctionUpdateDate=@FunctionUpdateDate,FunctionCreate=@FunctionCreate,FunctionDesr=@FunctionDesr";
                int i = conn.Execute(sql, function);
                return i;

            }
        }

        public List<Function> GetFunctions()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from Function");
                var result = conn.Query<Function>(sql, null);
                return result.ToList<Function>();
            }
        }
    }
}
