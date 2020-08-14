using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierresSweetAndSavoryTreats.Models
{
  public class PierresSweetAndSavoryTreatsContextFactory : IDesignTimeDbContextFactory<PierresSweetAndSavoryTreatsContext>
  {

    PierresSweetAndSavoryTreatsContext IDesignTimeDbContextFactory<PierresSweetAndSavoryTreatsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PierresSweetAndSavoryTreatsContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new PierresSweetAndSavoryTreatsContext(builder.Options);
    }
  }
}