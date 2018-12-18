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
    public class PictureService : IPictureService
    {
        /// <summary>
        /// 显示图片
        /// </summary>
        /// <returns></returns>
        public List<Picture> GetPictures()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select *from picture");
                var result = conn.Query<Picture>(sql, null);
                return result.ToList<Picture>();

            }
        }

        ///图片表
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        public int PictureAdd(Picture picture)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into Picture values(@PictureActualName,@PictureDisplayName,@PictureAbsolute,@PictureNewsDept,@PictureNewsTypeDept,@PictureCreate,@PictureUpdate)");
                int i = conn.Execute(sql, picture);
                return i;
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="PictureID"></param>
        /// <returns></returns>
        public int PictureDelete(int PictureID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format(@"delete Picture where PictureID=:PictureID");
                int i = conn.Execute(sql ,new {Picture=PictureID});
                return i;
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        public int PictureUpdate(Picture picture)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "Update Picture set PictureActualName=@PictureActualName,PictureDisplayName=@PictureDisplayName,PictureAbsolute=@PictureAbsolute,PictureNewsDept=@PictureNewsDept,PictureNewsTypeDept=@PictureNewsTypeDept,PictureCreate=@PictureCreate where PictureUpdate=@PictureUpdate";
                int i = conn.Execute(sql, picture);
                return i;
            }
        }
    }
}
