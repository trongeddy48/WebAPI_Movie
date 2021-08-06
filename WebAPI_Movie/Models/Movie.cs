namespace WebAPI_Movie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            Comments = new HashSet<Comment>();
            Films = new HashSet<Film>();
            Likings = new HashSet<Liking>();
            Saveds = new HashSet<Saved>();
        }

        [StringLength(8)]
        public string MovieId { get; set; }

        public string Name { get; set; }

        public int? Views { get; set; }

        [StringLength(5)]
        public string Episodes { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Years { get; set; }

        public string Description { get; set; }

        public string Thumbnails { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fee { get; set; }

        [StringLength(8)]
        public string CategoryId { get; set; }

        [StringLength(8)]
        public string StudioId { get; set; }

        [StringLength(8)]
        public string SeriesId { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Film> Films { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liking> Likings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saved> Saveds { get; set; }

        public virtual Studio Studio { get; set; }

        public virtual Series Series { get; set; }
    }
}
