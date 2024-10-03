using Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    public class CatalogContext:DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) { }
        //public CatalogContext(DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
