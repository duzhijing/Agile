using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public interface IAdminPersonService
    {
        int AdminPersonAdd(AdminPerson adminPerson);
        List<AdminPerson> GetAdminPerson();
        int AdminPersonDelete(int AdminPersonID);
        int AdminPersinUpdate(AdminPerson adminPerson);
        bool AdminLogin(string AdminPersonName, string AdminPersonPassword);
    }
}
