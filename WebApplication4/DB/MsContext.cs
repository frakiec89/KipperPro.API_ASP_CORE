using Microsoft.EntityFrameworkCore;
namespace KipperPro.API_ASP_CORE.DB
{
    public class MsContext : DbContext
    {
        private IConfiguration _config;
        public MsContext(IConfiguration configuration)
        {
            _config = configuration;
            Database.MigrateAsync();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config["connectionStringSql"]);
        }

        public DbSet<AttendsGroups> AttendsGroups { get; set; }
        public DbSet<AttendsPersonally> AttendsPersonally { get; set;}
        public DbSet<Department> Department { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<User> Users { get; set; }   
        public DbSet<Visitor> Visitors { get; set; }

    }
}
