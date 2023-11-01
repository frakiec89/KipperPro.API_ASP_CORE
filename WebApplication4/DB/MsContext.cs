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
    }
}
