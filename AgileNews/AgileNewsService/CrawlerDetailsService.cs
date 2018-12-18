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
    public class CrawlerDetailsService : ICrawlerDetailsService
    {
        public int CrawlerDetailsAdd(CrawlerDetails crawlerDetails)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into CrawlerDetails values(@WebsiteName,@Website,@ChannelName,@ChannelURL,@IsState,@CrawlerManageID)");
                int i = conn.Execute(sql, crawlerDetails);
                return i;
            }
        }

        public int CrawlerDetailsDelete(int CrawlerDetailsID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete CrawlerDetails where CrawlerDetailsID=:CrawlerDetailsID");
                int i = conn.Execute(sql, new { CrawlerDetailsID = CrawlerDetailsID });
                return i;
            }
        }

        public int CrawlerDetailsUpdate(CrawlerDetails crawlerDetails)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update CrawlerDetails set WebsiteName=@WebsiteName,Website=@Website,ChannelName=@ChannelName,ChannelURL=@ChannelURL,IsState=@IsState,CrawlerManageID=@CrawlerManageID";
                int i = conn.Execute(sql, crawlerDetails);
                return i;

            }
        }

        public List<CrawlerDetails> GetCrawlerDetails()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from CrawlerDetails");
                var result = conn.Query<CrawlerDetails>(sql, null);
                return result.ToList<CrawlerDetails>();
            }
        }
    }
}
