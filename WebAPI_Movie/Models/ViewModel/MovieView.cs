using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Movie.Models.ViewModel
{
    public class MovieView
    {
        public string MovieId { get; set; }

        public string Name { get; set; }

        public int? Views { get; set; }

        public string Episodes { get; set; }

        public string Years { get; set; }

        public string Description { get; set; }

        public string Thumbnails { get; set; }

        public decimal? Fee { get; set; }
    }
}