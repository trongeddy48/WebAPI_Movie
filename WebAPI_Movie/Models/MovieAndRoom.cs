using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Movie.Models
{
    public class MovieAndRoom
    {
        public Movie Movies { get; set; }
        public string RoomId { get; set; }
        public string UserId { get; set; }
    }
}