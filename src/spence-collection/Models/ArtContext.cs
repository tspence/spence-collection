using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spence_collection.Models
{
    public class ArtContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtworkAttribute> ArtworkAttributes { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Story> Stories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./SpenceCollection.db");
        }
    }
}
