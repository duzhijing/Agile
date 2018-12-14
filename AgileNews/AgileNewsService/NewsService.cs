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
    public class NewsService : INewsService
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<News> GetNews()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from News");
                var result = conn.Query<News>(sql, null);
                return result.ToList<News>();
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int NewsAdd(News news)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                //string sql = string.Format(@"insert into News(NewsTitle,NewsPublisher,NewsPublishDate,NewsDetails,NewsSort) values(:NewsTitle,NewsPublisher,NewsPublishDate,NewsDetails,NewsSort)");
                //var dd = new { NewsTitle = news.NewsTitle, news.NewsPublisher, news.NewsPublishDate, news.NewsDetails, news.NewsSort};
                //int i = conn.Execute(sql, dd);
                //return i;
                string sql = @"insert into News(NewsTitle,NewsPublisher,NewsPublishDate,NewsDetails,NewsSort,NewsReader,NewsUpdateDate,NewsTypeID,IsDelete,LikeTablePid) values(:NewsTitle,:NewsPublisher,:NewsPublishDate,:NewsDetails,:NewsSort,:NewsReader,:NewsUpdateDate,:NewsTypeID,:IsDelete,:LikeTablePid)";
                return conn.Execute(sql, news);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        public int NewsDelete(int newsId)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete News where NewsID=:NewsID");
                int i = conn.Execute(sql, new { newsId = newsId });
                return i;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int NewsUpdate(News news)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"Update News set  NewsTitle=:NewsTitle,NewsPublisher=:NewsPublisher,NewsPublishDate=:NewsPublishDate,NewsDetails=:NewsDetails,NewsSort=:NewsSort,NewsReader=:NewsReader,NewsUpdateDate=:NewsUpdateDate,NewsTypeID=:NewsTypeID,IsDelete=:IsDelete where LikeTablePid=:LikeTablePid";
                int i = conn.Execute(sql, news);
                return i;

            }
        }
    }
}
