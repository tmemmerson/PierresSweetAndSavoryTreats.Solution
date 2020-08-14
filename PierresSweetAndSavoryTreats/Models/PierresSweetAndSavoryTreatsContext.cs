using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresSweetAndSavoryTreats.Models
{
  public class PierresSweetAndSavoryTreats : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public PierresSweetAndSavoryTreatsContext(DbContextOptions options) : base(options) { }
  }
}