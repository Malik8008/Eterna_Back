using Eterna_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna_BackEnd.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Setting>()
                .HasIndex(u => u.Key)
                .IsUnique();

            base.OnModelCreating(builder);
        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProgressBar> Progresses { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<HomeFirstCard> homeFirstCards { get; set; }
        public DbSet<HomeSecondCard> homeSecondCards { get; set; }
        public DbSet<Brand> brands { get; set; }

    }

}
