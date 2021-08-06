namespace WebAPI_Movie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Saved")]
    public partial class Saved
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string SaveId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MovieId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string UserId { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual User User { get; set; }
    }
}
