using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    public interface ICommentsService
    {
        int CommentsAdd(Comment comment);
        List<Comment> GetComments();

        int ConmmentsDelete(int CommentsID);
        int CommentsUpdate(Comment comment);
    }
}
