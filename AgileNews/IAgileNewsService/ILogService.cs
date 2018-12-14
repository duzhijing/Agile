using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public interface ILogService
    {
        int LogAdd(Log log);
        List<Log> GetLogs();
        int LogDelete(int LogID);
        int LogUpdate(Log log);
    }
}
