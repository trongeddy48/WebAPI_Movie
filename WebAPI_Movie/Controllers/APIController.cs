using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Movie.Models;
using WebAPI_Movie.Models.ViewModel;

namespace WebAPI_Movie.Controllers
{
    public class APIController : ApiController
    {
        private XemGiDoContext db = new XemGiDoContext();
        //Lay tat ca the loai
        [HttpGet]
        [Route("api/Category")]
        public IHttpActionResult Category()
        {
            try
            {
                List<Category> CategoryList = db.Categories.ToList();
                List<CategoryView> List = new List<CategoryView>();
                CategoryList.ForEach((e) => {
                    CategoryView CateView = new CategoryView();
                    CateView.CategoryId = e.CategoryId;
                    CateView.Name = e.Name;
                    List.Add(CateView);
                });
                return Json(new
                {
                    CategoryList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay tat ca nha san xuat
        [HttpGet]
        [Route("api/Studio")]
        public IHttpActionResult Studio()
        {
            try
            {
                List<Studio> StudioList = db.Studios.ToList();
                List<StudioView> List = new List<StudioView>();
                StudioList.ForEach((e) => {
                    StudioView StuView = new StudioView();
                    StuView.StudioId = e.StudioId;
                    StuView.Name = e.Name;
                    List.Add(StuView);
                });
                return Json(new
                {
                    StudioList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay danh sach tat ca phim(trang chu)
        [HttpGet]
        [Route("api/Movie")]
        public IHttpActionResult Movie()
        {
            try
            {
                List<Movie> MovieList = db.Movies.ToList();
                List<MovieView> List = new List<MovieView>();
                MovieList.ForEach((e) => {
                    MovieView MovView = new MovieView();
                    MovView.MovieId = e.MovieId;
                    MovView.Name = e.Name;
                    MovView.Views = e.Views;
                    MovView.Episodes = e.Episodes;
                    MovView.Years = e.Years.Value.ToString("yyyy");
                    MovView.Description = e.Description;
                    MovView.Thumbnails = e.Thumbnails;
                    MovView.Fee = e.Fee;
                    List.Add(MovView);
                });
                return Json(new
                {
                    MovieList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay tat ca bo phim theo the loai
        [HttpGet]
        [Route("api/MovieByCate")]
        public IHttpActionResult MovieCate(string id)
        {
            try
            {
                List<Movie> MovieList = db.Movies.Where(p => p.CategoryId.Equals(id)).ToList();
                List<MovieView> List = new List<MovieView>();
                MovieList.ForEach((e) => {
                    MovieView MovView = new MovieView();
                    MovView.MovieId = e.MovieId;
                    MovView.Name = e.Name;
                    MovView.Views = e.Views;
                    MovView.Episodes = e.Episodes;
                    MovView.Years = e.Years.Value.ToString("yyyy");
                    MovView.Description = e.Description;
                    MovView.Thumbnails = e.Thumbnails;
                    MovView.Fee = e.Fee;
                    List.Add(MovView);
                });
                return Json(new
                {
                    MovieList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay tat ca bo phim theo nha san xuat
        [HttpGet]
        [Route("api/MovieByStu")]
        public IHttpActionResult MovieStu(string id)
        {
            try
            {
                List<Movie> MovieList = db.Movies.Where(p => p.StudioId.Equals(id)).ToList();
                List<MovieView> List = new List<MovieView>();
                MovieList.ForEach((e) => {
                    MovieView MovView = new MovieView();
                    MovView.MovieId = e.MovieId;
                    MovView.Name = e.Name;
                    MovView.Views = e.Views;
                    MovView.Episodes = e.Episodes;
                    MovView.Years = e.Years.Value.ToString("yyyy");
                    MovView.Description = e.Description;
                    MovView.Thumbnails = e.Thumbnails;
                    MovView.Fee = e.Fee;
                    List.Add(MovView);
                });
                return Json(new
                {
                    MovieList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay tat ca bo phim theo seri
        [HttpGet]
        [Route("api/MovieBySeri")]
        public IHttpActionResult MovieSeri(string id)
        {
            try
            {
                List<Movie> MovieList = db.Movies.Where(p => p.SeriesId.Equals(id)).ToList();
                List<MovieView> List = new List<MovieView>();
                MovieList.ForEach((e) => {
                    MovieView MovView = new MovieView();
                    MovView.MovieId = e.MovieId;
                    MovView.Name = e.Name;
                    MovView.Views = e.Views;
                    MovView.Episodes = e.Episodes;
                    MovView.Years = e.Years.Value.ToString("yyyy");
                    MovView.Description = e.Description;
                    MovView.Thumbnails = e.Thumbnails;
                    MovView.Fee = e.Fee;
                    List.Add(MovView);
                });
                return Json(new
                {
                    MovieList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay tat ca tap phim theo bo phim
        [HttpGet]
        [Route("api/FilmByMovieId")]
        public IHttpActionResult Film(string id)
        {
            try
            {
                List<Film> FilmList = db.Films.Where(p => p.MovieId.Equals(id)).ToList();
                List<FilmView> List = new List<FilmView>();
                FilmList.ForEach((e) => {
                    FilmView FView = new FilmView();
                    FView.FilmId = e.FilmId;
                    FView.URL = e.URL;
                    FView.Ep = e.Ep;
                    List.Add(FView);
                });
                return Json(new
                {
                    FilmList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay 1 nguoi dung
        [HttpGet]
        [Route("api/User")]
        public IHttpActionResult User(string id)
        {
            try
            {
                User user = db.Users.SingleOrDefault(p => p.UserId.Equals(id));
                UserView userView = new UserView();
                userView.UserId = user.UserId;
                userView.Username = user.Username;
                userView.Password = user.Password;
                userView.FullName = user.FullName;
                userView.Birthday = user.Birthday.Value.ToString("dd/MM/yyyy");
                userView.Address = user.Address;
                userView.Phone = user.Phone;
                userView.Email = user.Email;
                userView.Avatar = user.Avatar;
                userView.Wallet = user.Wallet;
                return Json(new
                {
                    User = userView
                });
            }
            catch(Exception e)
            {
                return NotFound();
            }
        }
        //Lay tat ca comment theo bo phim
        [HttpGet]
        [Route("api/Comment")]
        public IHttpActionResult Comment(string id)
        {
            try
            {
                List<Comment> CommentList = db.Comments.Where(p => p.MovieId.Equals(id)).ToList();
                List<CommentView> List = new List<CommentView>();
                CommentList.ForEach((e) =>
                {
                    CommentView commentView = new CommentView();
                    commentView.CommentId = e.CommentId;
                    commentView.GuestName = e.GuestName;
                    commentView.GuestAvatar = e.GuestAvatar;
                    commentView.Comment1 = e.Comment1;
                    commentView.Created = e.Created.Value.ToString("dd/MM/yyyy HH:mm");
                    List.Add(commentView);
                });
                return Json(new
                {
                    CommentList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay 1 bo phim
        [HttpGet]
        [Route("api/SingleMovie")]
        public IHttpActionResult SingleMovie(string id)
        {
            try
            {
                List<Movie> MovieList = db.Movies.Where(p => p.MovieId.Equals(id)).ToList();
                List<MovieView> List = new List<MovieView>();
                MovieList.ForEach((e) => {
                    MovieView MovView = new MovieView();
                    MovView.MovieId = e.MovieId;
                    MovView.Name = e.Name;
                    MovView.Views = e.Views;
                    MovView.Episodes = e.Episodes;
                    MovView.Years = e.Years.Value.ToString("yyyy");
                    MovView.Description = e.Description;
                    MovView.Thumbnails = e.Thumbnails;
                    MovView.Fee = e.Fee;
                    List.Add(MovView);
                });
                return Json(new
                {
                    MovieList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay 1 tap phim
        [HttpGet]
        [Route("api/SingleFilm")]
        public IHttpActionResult SingleFilm(string id)
        {
            try
            {
                List<Film> FilmList = db.Films.Where(p => p.FilmId.Equals(id)).ToList();
                List<FilmView> List = new List<FilmView>();
                FilmList.ForEach((e) => {
                    FilmView FView = new FilmView();
                    FView.FilmId = e.FilmId;
                    FView.URL = e.URL;
                    FView.Ep = e.Ep;
                    List.Add(FView);
                });
                return Json(new
                {
                    FilmList = List
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        //Lay 1 phong
        [HttpGet]
        [Route("api/Room")]
        public IHttpActionResult Room(string id)
        {
            try
            {
                Room room = db.Rooms.SingleOrDefault(p => p.RoomId.Equals(id));
                RoomView roomView = new RoomView();
                roomView.RoomId = room.RoomId;
                roomView.User1 = room.User1;
                roomView.User2 = room.User2;
                roomView.User3 = room.User3;
                roomView.User4 = room.User4;
                roomView.User5 = room.User5;
                roomView.User6 = room.User6;
                roomView.User7 = room.User7;
                roomView.User8 = room.User8;
                roomView.User9 = room.User9;
                roomView.User10 = room.User10;
                return Json(new
                {
                    Room = room
                });
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        //Luu phim
        [HttpGet]
        [Route("api/SaveMovie")]
        public IHttpActionResult Save( SaveView s)
        {
            if(s != null)
            {
                DateTime time = DateTime.Now;
                string day = DateTime.Now.ToString("dd");
                string month = DateTime.Now.ToString("MM");
                string year = DateTime.Now.ToString("yyyy");
                string Min = DateTime.Now.ToString("mm");
                string sec = DateTime.Now.ToString("ss");
                string SaveId = month + "" + day + "" + Min + "" + sec;

                string MovieId = s.MovieId;
                string UserId = s.UserId;

                if(db.Saveds.Any(p => p.MovieId.Equals(MovieId)&& p.UserId.Equals(UserId)))
                {
                    return Json(new
                    {
                        message = "luu roi"
                    });
                }
                else 
                { 
                    Saved save = new Saved();
                    save.SaveId = SaveId;
                    save.MovieId = MovieId;
                    save.UserId = UserId;
                    db.Saveds.Add(save);
                    db.SaveChanges();
                
                    return Json(new
                    {
                        message = "ok"
                    });
                }
            }
            else
            {
                return Json(new
                {
                    message = "nguloz"
                });
            }
        }

        //Thich
        [HttpGet]
        [Route("api/LikeMovie")]
        public IHttpActionResult Like(LikeView l)
        {
            if(l != null)
            {
                DateTime time = DateTime.Now;
                string day = DateTime.Now.ToString("dd");
                string month = DateTime.Now.ToString("MM");
                string year = DateTime.Now.ToString("yyyy");
                string Min = DateTime.Now.ToString("mm");
                string sec = DateTime.Now.ToString("ss");

                string LikeId =  month + "" + day + "" + Min + "" + sec;
                string MovieId = l.MovieId;
                string UserId = l.UserId;
                bool status= true;

               
                if (db.Likings.Any(p => p.MovieId.Equals(l.MovieId) && p.UserId.Equals(l.UserId)))
                { 
                    var liked = db.Likings.FirstOrDefault(p => p.MovieId.Equals(l.MovieId) && p.UserId.Equals(l.UserId));
                    status = (bool)liked.StatusLike;
                    liked.StatusLike = !status;
                    db.SaveChanges();
                    return Json(new
                    {
                        message = "update"
                    });
                }
                else
                {
                    Liking liking = new Liking();
                    liking.LikeId = LikeId;
                    liking.MovieId = MovieId;
                    liking.UserId = UserId;
                    liking.StatusLike = l.StatusLike;
                    db.Likings.Add(liking);
                    db.SaveChanges();
                    return Json(new
                    {
                        message = "ok"
                    });
                }
            }
            else
            {
                return Json(new
                {
                    message = "nguloz"
                });
            }
        }

        //Dang ki
        [HttpPost]
        [Route("api/Register")]
        public IHttpActionResult Register(UserView u)
        {
            if(u != null)
            {
                DateTime time = DateTime.Now;
                string day = DateTime.Now.ToString("dd");
                string month = DateTime.Now.ToString("MM");
                string year = DateTime.Now.ToString("yyyy");
                string Min = DateTime.Now.ToString("mm");
                string sec = DateTime.Now.ToString("ss");

                string UserId = month + "" + day + "" + Min + "" + sec;

                if(db.Users.Any(p => p.Username.Equals(u.Username)))
                {
                    return Json(new
                    {
                        message = "not ok"
                    });
                }
                else
                {
                    User user = new User();
                    user.UserId = UserId;
                    user.Username = u.Username;
                    user.Password = u.Password;
                    user.FullName = u.FullName;
                    user.Birthday = DateTime.Parse(u.Birthday);
                    user.Address = u.Address;
                    user.Phone = u.Phone;
                    user.Email = u.Email;
                    user.Avatar = u.Avatar;
                    user.Wallet = u.Wallet;
                    db.Users.Add(user);
                    db.SaveChanges();
                    return Json(new
                    {
                        message = "ok"
                    });
                }
            }
            else
            {
                return Json(new
                {
                    message = "nguloz"
                });
            }
        }

        //Dang nhap
        [HttpPost]
        [Route("api/Login")]
        public IHttpActionResult Login(UserView i)
        {
            if (db.Users.Any(p => p.Username.Equals(i.Username) && p.Password.Equals(i.Password)))
            {
                var User = db.Users.First(p => p.Username.Equals(i.Username));
                return Json(new
                {
                    message = User
                });
            }
            else
            {
                return Json(new
                {
                    message = "not ok"
                });
            }
        }
    }
}
