using az_webapp_kaycee.Models;
using Microsoft.EntityFrameworkCore;

namespace az_webapp_kaycee.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
         
    public DbSet<Person> Persons { get; set; }
}