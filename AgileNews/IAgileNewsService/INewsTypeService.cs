using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    /// <summary>
    /// 新聞接口
    /// </summary>
    public interface INewsTypeService
    {
        int NewsTypeAdd(NewsType newsType);
        List<NewsType> GetNewsTypes();
        int NewsTypeDelete(int newsTypeId);
        int NewsTypeUpdate(NewsType newsType);
        List<News> GetNewsByIds(string typeids);
    }
}

