using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI_Movie.Models;

namespace WebAPI_Movie.Controllers
{
    public class VerController : Controller
    {
        public XemGiDoContext db = new XemGiDoContext();
        // GET: Ver
        public ActionResult Ver()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ver(Verapp v)
        {
            try
            {
                db.Verapps.Add(v);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
            
        }
    }
}