using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI_Movie.Models;

namespace WebAPI_Movie.Controllers
{
    public class RoomMovieController : Controller
    {
        // GET: RoomMovie
        private XemGiDoContext db = new XemGiDoContext();
        public ActionResult Index(string id)
        {
            
            if (db.Users.Any(p=>p.UserId.Equals(id)))
            {
                var user = db.Users.FirstOrDefault(p => p.UserId.Equals(id));

                return View(user);
            }
            else
                return HttpNotFound();
        }
        

        public ActionResult Cinema (string id, string roomid, string userid ,string role)
        {
            New room = new New();
            room.Movies = id;
            room.RoomId = roomid;
            room.UserId = userid;
            room.Role = role;
            return View(room);
        }
    }
}