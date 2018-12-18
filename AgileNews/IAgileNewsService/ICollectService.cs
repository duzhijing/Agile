using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    public interface ICollectService
    {
        int CollectAdd(Collect collect);
        List<Collect> GetCollects();
        int CollectDelete(int CollectID);
        int CollectUpdate(Collect collect);
    }
}
