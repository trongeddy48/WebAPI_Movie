using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI_Movie.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Verapp> Verapps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Verapp>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Verapp>()
                .Property(e => e.URLVer)
                .IsUnicode(false);
        }
    }
}
