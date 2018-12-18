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
    public class NewsTypeService : INewsTypeService
    {
        public List<News> GetNewsByIds(string typeids)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from News where NewsTypeName=:NewsTypeName";
                var conditon = new { NewsTypeName = typeids };
                var result = conn.Query<News>(sql, conditon);
                return result.ToList<News>();
            }
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<NewsType> GetNewsTypes()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from NewsType");
                var resurt = conn.Query<NewsType>(sql, null);
                return resurt.ToList<NewsType>();
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="newsType"></param>
        /// <returns></returns>
        public int NewsTypeAdd(NewsType newsType)
        {
            
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                //DynamicParameters dynamicParameters = new DynamicParameters();
                //dynamicParameters.AddDynamicParams(newsType.NewsTypeName);
                string sql = string.Format("insert into NewsType(NewsTypeName) values(:NewsTypeName)");
                var dd = new { NewsTypeName= newsType.NewsTypeName };
                int i = conn.Execute(sql, dd);
                return i;
            }
        }
      /// <summary>
      /// 删除
      /// </summary>
      /// <param name="newsTypeId"></param>
      /// <returns></returns>
        public int NewsTypeDelete(int newsTypeId)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete from NewsType where NewsTypeID=:NewsTypeID");
                int i = conn.Execute(sql,new { newsTypeId = newsTypeId });
                return i;
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="newsType"></param>
        /// <returns></returns>
        public int NewsTypeUpdate(NewsType newsType)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update NewsType set NewsTypeName=@NewsTypeName where id=NewsTypeId ";
                int i = conn.Execute(sql, newsType);
                return i;
            }
        }

    }
}
