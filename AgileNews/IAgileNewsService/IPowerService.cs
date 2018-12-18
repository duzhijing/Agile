using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
    public interface IPowerService
    {
        List<Power> GetPowers();
        int AddPowers(Power p);
        int DeletePower(int Id);
        List<Power> GetPowersById(int Id);
        int UpdatePowers(Power p);
    }
}
