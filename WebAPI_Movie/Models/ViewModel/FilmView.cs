using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Movie.Models.ViewModel
{
    public class FilmView
    {
        public string FilmId { get; set; }

        public string URL { get; set; }

        public int? Ep { get; set; }
    }
}