using Microsoft.EntityFrameworkCore;

namespace KipperPro.API_ASP_CORE.DB.Base;

public class DbSetsBase : DbContext
{
    protected IConfiguration _config;
    
    public DbSet<AttendsGroups> AttendsGroups { get; set; }
    public DbSet<AttendsPersonally> AttendsPersonally { get; set;}
    public DbSet<Department> Department { get; set; }
    public DbSet<Division> Divisions { get; set; }
    public DbSet<User> Users { get; set; }   
    public DbSet<Visitor> Visitors { get; set; }
}