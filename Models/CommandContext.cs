using Microsoft.EntityFrameworkCore;

namespace cmdapi.Models
{
    public class CommandContext : DbContext 
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base (options)
        {

        }
        public DbSet<Command> CommandItems {get; set;}
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
            
        //     optionsBuilder.UseNpgsql();
        // }
    }
}
