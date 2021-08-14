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
            MovieAndRoom room = new MovieAndRoom();
            if (id != "")
            {
                XemGiDoContext db = new XemGiDoContext();
                var item = db.Movies.FirstOrDefault(p => p.MovieId.Equals(id));
                room.Movies = item.MovieId;
            }
            else room.Movies =  "";
            
            room.RoomId = roomid;
            room.UserId = userid;
            return View(room);
        }
    }
}