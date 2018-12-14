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
    public class CrawlerGrabService : ICrawlerGrabService
    {
        public int CrawlerGrabAdd(CrawlerGrab crawlerGrab)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into CrawlerGrab values(@CrawlerGrabURL,@CrawlerGrabTitle,@CrawlerGrabContent,@CrawlerGrabPicture,@FirstPictureURL,@CrawlerGrabCreateDate,@CrawlerGrabUpdateDate,@Author,@NewsReleaceDate,@NewsSource,@NewsMark,@NewsTypeID)");
                int i = conn.Execute(sql, crawlerGrab);
                return i;
            }
        }

        public int CrawlerGrabDelete(int CrawlerGrabID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete CrawlerGrab where CrawlerGrabID=:CrawlerGrabID");
                int i = conn.Execute(sql, new { CrawlerGrabID = CrawlerGrabID });
                return i;
            }
        }

        public int CrawlerGrabUpdate(CrawlerGrab crawlerGrab)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update CrawlerGrab set CrawlerGrabURL=@CrawlerGrabURL,CrawlerGrabTitle=@CrawlerGrabTitle,CrawlerGrabContent=@CrawlerGrabContent,CrawlerGrabPicture=@CrawlerGrabPicture,FirstPictureURL=@FirstPictureURL,CrawlerGrabCreateDate=@CrawlerGrabCreateDate,CrawlerGrabUpdateDate=@CrawlerGrabUpdateDate,Author=@Author,NewsReleaceDate=@NewsReleaceDate,NewsSource=@NewsSource,NewsMark=@NewsMark,@NewsTypeID";
                int i = conn.Execute(sql, crawlerGrab);
                return i;

            }
        }

        public List<CrawlerGrab> GetCrawlerGrabs()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from CrawlerGrab");
                var result = conn.Query<CrawlerGrab>(sql, null);
                return result.ToList<CrawlerGrab>();
            }
        }
    }
}
