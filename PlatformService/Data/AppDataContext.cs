using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDataContext : DbContext 
    {
        public AppDataContext(DbContextOptions<AppDataContext> opt) : base(opt)
        {

        }

        public DbSet<Platform> Platforms {get; set;}

    }
}