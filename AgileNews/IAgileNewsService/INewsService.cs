using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    public  interface INewsService
    {
        int NewsAdd(News news);
        List<News> GetNews();
        int NewsDelete(int newsId);
        int NewsUpdate(News news);
    }
}
