using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI_Movie.Models
{
    public partial class XemGiDoContext : DbContext
    {
        public XemGiDoContext()
            : base("name=XemGiDoContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Liking> Likings { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Saved> Saveds { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.CommentId)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.MovieId)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.FilmId)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.MovieId)
                .IsUnicode(false);

            modelBuilder.Entity<Liking>()
                .Property(e => e.LikeId)
                .IsUnicode(false);

            modelBuilder.Entity<Liking>()
                .Property(e => e.MovieId)
                .IsUnicode(false);

            modelBuilder.Entity<Liking>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.MovieId)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Episodes)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Thumbnails)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Fee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movie>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.StudioId)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.SeriesId)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Likings)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Saveds)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomId)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User1)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User2)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User3)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User4)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User5)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User6)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User7)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User8)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User9)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.User10)
                .IsUnicode(false);

            modelBuilder.Entity<Saved>()
                .Property(e => e.SaveId)
                .IsUnicode(false);

            modelBuilder.Entity<Saved>()
                .Property(e => e.MovieId)
                .IsUnicode(false);

            modelBuilder.Entity<Saved>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Series>()
                .Property(e => e.SeriesId)
                .IsUnicode(false);

            modelBuilder.Entity<Studio>()
                .Property(e => e.StudioId)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Wallet)
                .HasPrecision(19, 4);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Likings)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Saveds)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
