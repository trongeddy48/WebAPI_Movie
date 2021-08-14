using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI_Movie.Models;

namespace WebAPI_Movie.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
       
        public ActionResult RoomMovie(string id, string roomid ,string userid)
        {
            XemGiDoContext db = new XemGiDoContext();
            var item = db.Movies.FirstOrDefault(p => p.MovieId.Equals(id));
            MovieAndRoom room = new MovieAndRoom();
            room.Movies = item;
            room.RoomId = roomid;
            room.UserId = userid;
            return View(room);
        }
    }
}