using KipperPro.API_ASP_CORE.DB.Base;
using Microsoft.EntityFrameworkCore;

namespace KipperPro.API_ASP_CORE.DB.Contexts
{
    public class MsContext : DbSetsBase
    {
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
