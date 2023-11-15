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

    }
}
