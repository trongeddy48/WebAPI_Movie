namespace WebAPI_Movie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Likings = new HashSet<Liking>();
            Saveds = new HashSet<Saved>();
        }

        [StringLength(8)]
        public string UserId { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(30)]
        public string Password { get; set; }

        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public string Address { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        public string Email { get; set; }

        [StringLength(50)]
        public string Avatar { get; set; }

        [Column(TypeName = "money")]
        public decimal? Wallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liking> Likings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saved> Saveds { get; set; }
    }
}
