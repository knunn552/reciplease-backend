using Microsoft.EntityFrameworkCore;
using reciplease_backend.Data.Models;

namespace reciplease_backend.Data
{
    public class NpgsqlDbContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Cookware> Cookware { get; set; }
        public DbSet<Appliance> Appliances { get; set; }
        public DbSet<Utensil> Utensils { get; set; }



    }
}
