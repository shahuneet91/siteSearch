using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reservationApp.Models;
namespace reservationApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

      [HttpPost]
        public ActionResult setValues(string location, string chkIn, string chkOut, string roomQty)
        {
            reservationTable setData = new reservationTable();

            using (DatabaseEntities  db = new DatabaseEntities())
            {
                setData.location = location;
                setData.chkInDate = chkIn;
                setData.chkOutdate = chkOut;
                setData.roomQty = roomQty;
                db.reservationTables.Add(setData);
                db.SaveChanges();

               
            }
            return View();
        }
    }
}