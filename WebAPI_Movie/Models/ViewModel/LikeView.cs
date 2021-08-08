using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Movie.Models.ViewModel
{
    public class LikeView
    {
        public string MovieId { get; set; }
        public string UserId { get; set; }
        public bool? StatusLike { get; set; }
    }
}