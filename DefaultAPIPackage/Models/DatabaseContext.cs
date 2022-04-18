using DefaultAPIPackage.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DefaultAPIPackage.API.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Language> Languages { get; set; }
        public DbSet<TextResourceCategory> TextResourceCategories { get; set; }
        public DbSet<TextResourceKey> TextResourceKeys { get; set; }
        public DbSet<TextResourceKeyValue> TextResourceKeyValues { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<TenantScreen> TenantScreens { get; set; }
    }
}
