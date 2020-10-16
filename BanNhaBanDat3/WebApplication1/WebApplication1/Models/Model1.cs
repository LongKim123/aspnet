namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<News> News { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.News)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CateId);

            modelBuilder.Entity<News>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
