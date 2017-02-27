using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reservationApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult setValues(string location, string chkIn, string chkOut, string roomQty)
        {
            string loc = location;
            return Content(location);
        }
    }
}