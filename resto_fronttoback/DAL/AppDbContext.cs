using Microsoft.EntityFrameworkCore;
using resto_fronttoback.Models;

namespace resto_fronttoback.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<AboutSpecialRecipe> AboutSpecialRecipes { get; set; }
        public DbSet<Specialties> Specialties { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
