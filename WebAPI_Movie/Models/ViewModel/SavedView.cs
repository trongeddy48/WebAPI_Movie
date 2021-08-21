using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Movie.Models.ViewModel
{
    public class SavedView
    {
        public string SaveId { get; set; }
        
        public string MovieId { get; set; }

        public string UserId { get; set; }
    }
}