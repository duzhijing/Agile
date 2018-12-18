using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public interface ILikesService
    {
        int LikesAdd(Likes likes);
        List<Likes> GetLikes();
        int LikesDelete(int LikesID);
        int LikesUpdate(Likes likes);
    }
}
