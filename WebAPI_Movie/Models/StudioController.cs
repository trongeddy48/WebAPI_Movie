using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Movie.Models;
using WebAPI_Movie.Models.ViewModel;

namespace WebAPI_Movie.Models
{
    public class StudioController : ApiController
    {
        private XemGiDoContext db = new XemGiDoContext();

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
    }
}
