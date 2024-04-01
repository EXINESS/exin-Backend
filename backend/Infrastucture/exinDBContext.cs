using backend.Domain.Cores;
using backend.Domain.Cores.AchiveAggregate;
using backend.Domain.Cores.FeedbackAggregate;
using backend.Domain.Cores.SubTaskAggregate;
using backend.Domain.Cores.TargetAggregate;
using backend.Domain.Cores.TokenAggregate;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace backend.Infrastucture
{
    public class exinDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public exinDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("exinDB"));
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //    modelBuilder.Entity<Token>()
        //                     .HasIndex(e => e.token).IsUnique();

        //}

        //public DbSet<User> Users { get; set; }
        public DbSet<Target> Target { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Achive> Achives { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
