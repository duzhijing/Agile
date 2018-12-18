using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgileNewsService
{
    using AgileNewsEntity;
   public interface IUsersService
    {
        int UsersAdd(Users users);
        List<Users> GetUsers();
        int UsersDelete(int UsersID);
        int UsersUpdate(Users users);
    }
}
