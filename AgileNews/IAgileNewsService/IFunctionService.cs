using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public interface IFunctionService
    {
        int FunctionAdd(Function function);
        List<Function> GetFunctions();
        int FunctionDelete(int FunctionID);
        int FunctionUpdate(Function function);
    }
}
