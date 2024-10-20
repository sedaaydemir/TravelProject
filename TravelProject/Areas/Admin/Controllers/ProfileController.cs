using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Context;
using TravelProject.Entities;

namespace TravelProject.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        TravelContext context= new TravelContext();
        // GET: Admin/Profile
        public ActionResult Index()
        {
            var a =Session["x"];
            var values =context.Admins.Where(x=>x.Username==a).FirstOrDefault();
            return View(values);
        }
    }
}