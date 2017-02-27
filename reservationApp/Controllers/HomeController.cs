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
        public ActionResult Index(string location, string chkIn, string chkOut, string roomQty)
        {
            string loc = location;
            reservationModel setData = new reservationModel();
            setData.loc = location;
            setData.chkInDate = chkIn;
            setData.chkOutDate = chkOut;
            setData.room_Qty = roomQty;

            using (DatabaseEntities  db = new DatabaseEntities())
            {
               d
               
            }

            return View();
        }
    }
}