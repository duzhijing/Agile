using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgileNewsView.Controllers
{
    using AgileNewsService;
    using AgileNewsEntity;
    using IAgileNewsService;
    using System.Runtime.CompilerServices;
    using Unity.Attributes;

    public class AdminPersonController : BaseController
    {
       [Unity.Attributes.Dependency]
        public IAdminPersonService AdminPersonService { get; set; }
       
      // GET: AdminPerson
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public int AdminPersonAdd(AdminPerson u)
        {
            var result = AdminPersonService.AdminPersonAdd(u);
            return result;
        }
        //[HttpPost]
        //public int Update(string AdminPersonPassword)
        //{
        //    int Id = Convert.ToInt32(Session["AdminPersonID"]);
        //    var result = AdminPersonService.AdminPersinUpdate(, AdminPersonPassword);
        //    return result;
        //}
        [HttpPost]
        public int Query(string AdminPersonName)
        {
            var result = AdminPersonService.GetAdminPerson().Where(m => m.Equals(AdminPersonName)).ToList();
            return result.Count;
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public int AdminLogin(string AdminPersonName,string AdminPersonPassword)
        {
            var result = AdminPersonService.AdminLogin(AdminPersonName, AdminPersonPassword);
            if(result)
            {
                Session["aAdminPersonName"] = AdminPersonName;
                Session["AdminPersonPassword"] = AdminPersonPassword;
                Session["aAdminPersonID"] = result;
            }
            return 1;
        }
    }
}