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
    public class CommentsService : ICommentsService
    {
        public int CommentsAdd(Comment comment)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into Commente(UserID,NewsPID,CommentCreate,CommentContent) values(:UserID,:NewsPID,:CommentCreate,:CommentContent)");
                int i = conn.Execute(sql, comment);
                return i;
            }
        }

        public int CommentsUpdate(Comment comment)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update Comment set UserPID=@UserPID,NewsPID=@NewsPID,CommentCreate=@CommentCreate,CommentUpdate=@CommentUpdate,CommentContent=@CommentContent,IsDelete=@IsDelete";
                int i = conn.Execute(sql, comment);
                return i;

            }
        }

        public int ConmmentsDelete(int CommentsID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete Comments where CommentsID =:CommentsID");
                int i = conn.Execute(sql, new { CommentsID = CommentsID });
                return i;
            }
        }

        public List<Comment> GetComments()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from Comment");
                var result = conn.Query<Comment>(sql, null);
                return result.ToList<Comment>();
            }
        }
    }
}
