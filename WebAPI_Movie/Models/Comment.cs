namespace WebAPI_Movie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        [StringLength(8)]
        public string CommentId { get; set; }

        [StringLength(50)]
        public string GuestName { get; set; }

        [StringLength(50)]
        public string GuestAvatar { get; set; }

        [Column("Comment")]
        public string Comment1 { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(8)]
        public string MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
