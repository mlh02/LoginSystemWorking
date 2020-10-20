using System;
using Microsoft.EntityFrameworkCore;

namespace ParentCHildRelationshipPT1.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

    }
}
