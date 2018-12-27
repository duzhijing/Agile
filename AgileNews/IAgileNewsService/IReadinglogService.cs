using AgileNewsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
  public  interface IReadinglogService
    {
        List<Readinglog> GetReadinglogs(DateTime? datetime1, DateTime? datetime2);
    }
}
