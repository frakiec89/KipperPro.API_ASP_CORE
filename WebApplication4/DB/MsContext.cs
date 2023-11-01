using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KipperPro.API_ASP_CORE.DB
{
    public class MsContext : DbContext
    {
        private string cs = $"Data Source=(LocalDb)\\MSSQLLocalDB;database = KiperPRO_DB;Integrated Security=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

        public DbSet<DB.AttendsGroups> AttendsGroups { get; set; }
        public DbSet<DB.AttendsPersonally> AttendsPersonally { get; set;}
        public DbSet<DB.Department> Department { get; set; }
        public DbSet<DB.Division> Divisions { get; set; }
        public DbSet<DB.User> Users { get; set; }   
        public DbSet<DB.Visitor> Visitors { get; set; }

    }
}
