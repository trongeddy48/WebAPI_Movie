namespace WebAPI_Movie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [StringLength(8)]
        public string FilmId { get; set; }

        public string URL { get; set; }

        public int? Ep { get; set; }

        [StringLength(8)]
        public string MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
