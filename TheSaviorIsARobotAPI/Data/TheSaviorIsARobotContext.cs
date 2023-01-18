using Microsoft.EntityFrameworkCore;
using TheSaviorIsARobotAPI.Entities;

namespace TheSaviorIsARobotAPI.Data
{
    public class TheSaviorIsARobotContext : DbContext
    {
        public TheSaviorIsARobotContext(DbContextOptions<TheSaviorIsARobotContext> options) : base(options)
        { }

        public DbSet<World> Worlds { get; set; }
    }
}
