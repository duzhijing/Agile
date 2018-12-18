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
    public class CrawlerManageService : ICrawlerManageService
    {
      

      

        public int CrawlerManageAdd(CrawlerManage crawlerManage)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into CrawlerManage values(@CrawlerGrabName,@CreateDateTime,@Founder,@IsState,@CrawlerGrabID)");
                int i = conn.Execute(sql, crawlerManage);
                return i;
            }
        }

        public int CrawlerManageDelete(int CrawlerManageID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete CrawlerManage where CrawlerManageID=:CrawlerManageID");
                int i = conn.Execute(sql, new { CrawlerManageID = CrawlerManageID });
                return i;
            }
        }

        public int CrawlerManageUpdate(CrawlerManage crawlerManage)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update CrawlerManage set CrawlerGrabName=@CrawlerGrabName,CreateDateTime=@CreateDateTime,Founder=@Founder,IsState=@IsState,CrawlerGrabID=@CrawlerGrabID";
                int i = conn.Execute(sql, crawlerManage);
                return i;

            }
        }

        public List<CrawlerManage> GetCrawlerManages()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from CrawlerManage");
                var result = conn.Query<CrawlerManage>(sql, null);
                return result.ToList<CrawlerManage>();
            }
        }
    }
}
