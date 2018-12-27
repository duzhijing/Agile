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
    using Dapper;

    public class ReadinglogService : IReadinglogService
    {
        public List<Readinglog> GetReadinglogs(DateTime? datetime1, DateTime? datetime2)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = "select b.newsname,a.NewsReader from (select newsId,NewsReader from (select newsId,count(ID) as NewsReader from Readinglog where createtime between to_date(to_char(:datetime1, 'yyyy-MM-dd'),'yyyy-mm-dd') and to_date(to_char(:datetime2, 'yyyy-MM-dd'),'yyyy-mm-dd') group by newsId order by count(id) desc) a where rownum <10) a inner join news b on a.newsId=b.id";
                var conditon = new { datetime1 = datetime1, datetime2 = datetime2 };
                var readingloglist = conn.Query<Readinglog>(sql, conditon);
                return readingloglist.ToList();
            }
        }
    }
}
