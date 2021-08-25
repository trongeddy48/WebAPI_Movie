namespace WebAPI_Movie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Verapp")]
    public partial class Verapp
    {
        [StringLength(8)]
        public string Id { get; set; }

        public int? Ver { get; set; }

        public string URLVer { get; set; }
    }
}
