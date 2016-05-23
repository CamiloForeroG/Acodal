using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcodalCongress.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        CongresoAcodalEntities db = new CongresoAcodalEntities();

        public JsonResult GetUsuarios() {
            var results = db.Usuarios;
            return Json(results, JsonRequestBehavior.AllowGet);
        }
    }
}